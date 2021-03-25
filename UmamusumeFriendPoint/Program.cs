using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Umamusume;
using Umamusume.Model;
using System.Linq;
using System.Threading;
namespace UmamusumeFriendPoint
{
    class Program
    {
        const int GlobalRequestInterval = 800;
        const int ThreadPreUser = 8;
        static readonly string CurrentPath = Environment.CurrentDirectory;
        static Dictionary<int, bool> TaskFlag = new Dictionary<int, bool>();
        static Object TaskFlagLock = new Object();
        static Dictionary<int, bool> UserStatus = new Dictionary<int, bool>();
        static Object UserStatusLock = new Object();
        static Dictionary<int, Object> UserFarmDataLock = new Dictionary<int, Object>();
        static void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]:{message}");
        }
        static void Main(string[] args)
        {
            if (!Directory.Exists(Path.Combine(CurrentPath, "data")))
            {
                Directory.CreateDirectory(Path.Combine(CurrentPath, "data"));
                Log("未找到数据文件夹，将自动创建");
            }
            if (!File.Exists(Path.Combine(CurrentPath, "account.json")))
            {
                var fa = new FarmAccount();
                fa.viewer_id_list.Add("0", new FarmAccountData(10000));
                File.WriteAllText(Path.Combine(CurrentPath, "account.json"), JsonConvert.SerializeObject(fa));
                Log("未找到用户文件，将自动创建并退出程序");
                return;
            }
            for (int i = 0; i < 32; i++)
            {
                TaskFlag[i] = false;
            }
            var jsonStr = File.ReadAllText(Path.Combine(CurrentPath, "account.json"));
            var accounts = JsonConvert.DeserializeObject<FarmAccount>(jsonStr).viewer_id_list;
            Log("初始化成功");
            foreach (var data in accounts)
            {
                lock (UserStatusLock)
                {
                    UserStatus.Add(Convert.ToInt32(data.Key), false);
                    UserFarmDataLock.Add(Convert.ToInt32(data.Key), new Object());
                }
                new Thread(new ThreadStart(() => StartFarmTask(Convert.ToInt32(data.Key), data.Value.max_friend_point, ThreadPreUser))).Start();
                Thread.Sleep(2000);
            }
            Log("所有账号已经被添加至队列");
            while (true)
            {
                Thread.Sleep(10000);
                int notFinishCount = 0;
                lock (UserStatusLock)
                {
                    foreach (var status in UserStatus)
                    {
                        if (status.Value == false)
                            notFinishCount++;
                    }
                    if (notFinishCount == 0)
                    {
                        Log("任务完成，程序即将退出");
                        break;
                    }
                    else
                    {
                        Log($"还有{notFinishCount}个任务未完成");
                    }
                }
            }
            Console.ReadLine();
        }

        static void StartFarmTask(int viewer_id, int target_point, int max_thread = 1)
        {
            int currentNeedThread = max_thread;
            while (currentNeedThread != 0)
            {
                lock (TaskFlagLock)
                {
                    for (int i = 0; i < 32; i++)
                    {
                        if (TaskFlag[i] == false && currentNeedThread > 0)
                        {
                            new Thread(new ThreadStart(() => FarmTask(viewer_id, target_point, i))).Start();
                            //FarmTask(viewer_id, target_point, i);
                            currentNeedThread--;
                            TaskFlag[i] = true;
                            Thread.Sleep(1000);
                        }
                    }
                }
                Thread.Sleep(1000);
            }
        }
        static void FarmTask(int viewer_id, int target_point, int thread_id)
        {
            int currentTaskId = thread_id;
            Log($"开始执行账号{viewer_id}农场任务,位于线程{currentTaskId}");
            var dataFilePath = Path.Combine(CurrentPath, "data", $"{viewer_id}.json");
            FarmData farmData;
            lock (UserFarmDataLock[viewer_id])
            {
                if (!File.Exists(dataFilePath))
                {
                    farmData = new FarmData();
                    File.WriteAllText(dataFilePath, JsonConvert.SerializeObject(farmData));
                    Log($"用户{viewer_id}不存在农场数据，将新建");

                }
                else
                {
                    var farmDataStr = File.ReadAllText(dataFilePath);
                    farmData = JsonConvert.DeserializeObject<FarmData>(farmDataStr);
                    Log($"成功读取用户{viewer_id}的农场数据");
                }
            }
            UmamusumeClient client = null;
            try
            {
                client = new UmamusumeClient(new SimpleLz4Frame(currentTaskId));
                client.Signup();
                client.StartSession();
                Thread.Sleep(GlobalRequestInterval / 2);
                client.Login();
                Thread.Sleep(GlobalRequestInterval / 2);
                client.Request(new TutorialSkipRequest());
                Thread.Sleep(GlobalRequestInterval / 2);
                client.StartSession();
                Thread.Sleep(GlobalRequestInterval / 2);
                client.Login();
                Thread.Sleep(GlobalRequestInterval / 2);
                var presents = client.ReceivePresents().reward_summary_info.add_item_list;
            }
            catch (Exception e)
            {
                Log($"线程{currentTaskId}创建用户发生错误");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                lock (TaskFlagLock)
                {
                    TaskFlag[currentTaskId] = false;
                }
                return;
            }
            int retryCount = 0;
            int remain_friend_chara_count = 3;
            bool isFirstRun = true;
            while (farmData.friend_point_count < target_point && retryCount < 5)
            {
                try
                {
                    Thread.Sleep(GlobalRequestInterval);
                    lock (UserFarmDataLock[viewer_id])
                    {
                        var farmDataStr = File.ReadAllText(dataFilePath);
                        farmData = JsonConvert.DeserializeObject<FarmData>(farmDataStr);
                    }
                    int friend_support_card_id = 0;
                    int friend_trained_chara_id = 0;
                    int chara_1_trained_chara_id = 0;
                    int chara_2_trained_chara_id = 0;
                    bool isNewAccount = false;
                    client.StartSession();
                    Thread.Sleep(GlobalRequestInterval / 2);
                    client.Login();
                    Log($"线程{currentTaskId}当前使用账户:{client.Account.ViewerId}，当前剩余钻石:{client.FCoin}，当前剩余金币:{client.current_money}，当前剩余体力:{client.tpInfo.current_tp}");
                    Log($"线程{currentTaskId}当前服务用户:{viewer_id}，当前友情点状态:{farmData.friend_point_count}/{target_point}，当前皇冠状态:{farmData.crown_point_count}/100");
                    var trained_chara = client.LoginResp.data.trained_chara;
                    if ((int)client.tpInfo.current_tp < 30)
                    {
                        if (client.FCoin >= 10)
                        {
                            Thread.Sleep(GlobalRequestInterval / 2);
                            client.RetryRequest(new RecoveryTrainerPointRequest
                            {
                                count = 1,
                                client_own_num = client.FCoin
                            });
                            client.Login();
                        }
                        else
                        {
                            isNewAccount = true;
                            client.ResetAccount();
                            try
                            {
                                Thread.Sleep(GlobalRequestInterval / 2);
                                client.Signup();
                                Thread.Sleep(GlobalRequestInterval / 2);
                                client.StartSession();
                                Thread.Sleep(GlobalRequestInterval / 2);
                                client.Login();
                                Thread.Sleep(GlobalRequestInterval / 2);
                                client.Request(new TutorialSkipRequest());
                                Thread.Sleep(GlobalRequestInterval / 2);
                                client.StartSession();
                                Thread.Sleep(GlobalRequestInterval / 2);
                                client.Login();
                                var presents = client.ReceivePresents().reward_summary_info.add_item_list;
                            }
                            catch (Exception e)
                            {
                                Log($"线程{currentTaskId}创建用户发生错误");
                                Console.WriteLine(e.Message);
                                Console.WriteLine(e.StackTrace);
                            }
                        }
                    }
                    foreach (var item in trained_chara)
                    {
                        if (chara_1_trained_chara_id == 0 && item.card_id == 100801)
                        {
                            chara_1_trained_chara_id = (int)item.trained_chara_id;
                        }
                        if (chara_2_trained_chara_id == 0 && item.card_id == 100901)
                        {
                            chara_2_trained_chara_id = (int)item.trained_chara_id;
                        }
                    }
                    Thread.Sleep(GlobalRequestInterval);
                    if (isNewAccount || isFirstRun)
                    {
                        client.RetryRequest(new FriendLoadRequest());
                        Thread.Sleep(GlobalRequestInterval);
                        var friendSearchResp = client.RetryRequest(new FriendSearchRequest
                        {
                            friend_viewer_id = viewer_id
                        });
                        Thread.Sleep(GlobalRequestInterval);
                        var followResp = client.RetryRequest(new FriendFollowRequest
                        {
                            friend_viewer_id = viewer_id
                        });
                        Thread.Sleep(GlobalRequestInterval);
                        isFirstRun = false;
                    }
                    var rentalInfoResp = client.RetryRequest(new SingleModeRentalInfoRequest());
                    Thread.Sleep(GlobalRequestInterval);
                    foreach (var info in rentalInfoResp.data.friend_support_card_data.summary_user_info_array)
                    {
                        if (info.viewer_id == viewer_id)
                        {
                            friend_support_card_id = (int)info.user_support_card.support_card_id;
                            friend_trained_chara_id = (int)info.user_trained_chara.trained_chara_id;
                        }
                    }
                    if (friend_support_card_id == 0)
                    {
                        Log($"线程{currentTaskId}发生错误：找不到支援卡");
                        continue;
                    }
                    SingleModeStartChara singleModeStartChara = new SingleModeStartChara();
                    singleModeStartChara.card_id = 100701;
                    int[] supprot_card_array = {
                        10027,
                        10032,
                        10005,
                        10009,
                        10010
                    };
                    singleModeStartChara.support_card_ids = supprot_card_array;
                    SingleModeFriendSupportCardInfo singleModeFriendSupportCardInfo = new SingleModeFriendSupportCardInfo();
                    singleModeFriendSupportCardInfo.support_card_id = friend_support_card_id;
                    singleModeFriendSupportCardInfo.viewer_id = viewer_id;
                    singleModeStartChara.friend_support_card_info = singleModeFriendSupportCardInfo;
                    bool can_use_friend_chara = false;
                    if (remain_friend_chara_count > 0 && farmData.crown_point_count < 100)
                    {
                        can_use_friend_chara = true;
                        remain_friend_chara_count--;
                    }
                    if (can_use_friend_chara)
                    {
                        singleModeStartChara.succession_trained_chara_id_1 = 4;
                        singleModeStartChara.succession_trained_chara_id_2 = 0;
                        SingleModeRentalSuccessionChara singleModeRentalSuccessionChara = new SingleModeRentalSuccessionChara();
                        singleModeRentalSuccessionChara.viewer_id = viewer_id;
                        singleModeRentalSuccessionChara.trained_chara_id = friend_trained_chara_id;
                        singleModeRentalSuccessionChara.is_circle_member = false;
                        singleModeStartChara.rental_succession_trained_chara = singleModeRentalSuccessionChara;
                    }
                    else
                    {
                        singleModeStartChara.succession_trained_chara_id_1 = 4;
                        singleModeStartChara.succession_trained_chara_id_2 = 1;
                        SingleModeRentalSuccessionChara singleModeRentalSuccessionChara = new SingleModeRentalSuccessionChara();
                        singleModeRentalSuccessionChara.viewer_id = 0;
                        singleModeRentalSuccessionChara.trained_chara_id = 0;
                        singleModeRentalSuccessionChara.is_circle_member = false;
                        singleModeStartChara.rental_succession_trained_chara = singleModeRentalSuccessionChara;
                    }
                    singleModeStartChara.scenario_id = 1;
                    var singleModeStartResp = client.RetryRequest(new SingleModeStartRequest
                    {
                        start_chara = singleModeStartChara,
                        tp_info = client.tpInfo,
                        current_money = client.current_money
                    });
                    UserSupportCardDeckForUpdateParty[] support_card_deck_array = new UserSupportCardDeckForUpdateParty[10];
                    for (int i = 0; i < 10; i++)
                    {
                        if (i == 1)
                        {
                            support_card_deck_array[i] = new UserSupportCardDeckForUpdateParty
                            {
                                deck_id = i + 1,
                                support_card_id_array = supprot_card_array
                            };
                        }
                        else
                        {
                            support_card_deck_array[i] = new UserSupportCardDeckForUpdateParty
                            {
                                deck_id = i + 1,
                                support_card_id_array = new int[] { 0, 0, 0, 0, 0 }
                            };
                        }
                    }
                    client.RetryRequest(new SupportCardDeckChangePartyRequest
                    {
                        support_card_deck_array = support_card_deck_array
                    });
                    Log($"线程{currentTaskId}开始训练成功");
                    Thread.Sleep(GlobalRequestInterval);
                    var uncheckedEvent = singleModeStartResp.data.unchecked_event_array[0];
                    var singleModeCheckEventResp = client.RetryRequest(new SingleModeCheckEventRequest
                    {
                        event_id = uncheckedEvent.event_id,
                        chara_id = uncheckedEvent.chara_id,
                        choice_number = 0,
                        current_turn = 1
                    });
                    if (singleModeCheckEventResp.data == null)
                    {

                    }
                    Thread.Sleep(GlobalRequestInterval);
                    while (singleModeCheckEventResp.data.unchecked_event_array != null && singleModeCheckEventResp.data.unchecked_event_array.Length > 0)
                    {
                        foreach (var ev in singleModeCheckEventResp.data.unchecked_event_array)
                        {
                            Thread.Sleep(GlobalRequestInterval);
                            singleModeCheckEventResp = client.RetryRequest(new SingleModeCheckEventRequest
                            {
                                event_id = ev.event_id,
                                chara_id = ev.chara_id,
                                choice_number = 0,
                                current_turn = 1
                            });
                        }
                    }
                    Thread.Sleep(GlobalRequestInterval);
                    client.RetryRequest(new SingleModeFinishRequest
                    {
                        is_force_delete = true,
                        current_turn = 1
                    });
                    Log($"线程{currentTaskId}结束训练成功");
                    lock (UserFarmDataLock[viewer_id])
                    {
                        var farmDataStr = File.ReadAllText(dataFilePath);
                        farmData = JsonConvert.DeserializeObject<FarmData>(farmDataStr);
                        if (can_use_friend_chara && farmData.crown_point_count < 100) farmData.crown_point_count += 10;
                        farmData.friend_point_count += 10;
                        File.WriteAllText(dataFilePath, JsonConvert.SerializeObject(farmData));
                    }
                    Log($"线程{currentTaskId}数据成功保存");
                }
                catch (Exception e)
                {
                    Log($"线程{currentTaskId}发生错误");
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                    retryCount++;
                    Log($"线程{currentTaskId}第{retryCount}次重试");
                }
            }
            try
            {
                client.StartSession();
                client.Login();
                var unfollowResp = client.RetryRequest(new FriendUnFollowRequest
                {
                    friend_viewer_id = viewer_id
                });
            }
            catch (Exception e)
            {
                Log($"线程{currentTaskId}取消关注发生错误");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            if (retryCount == 5)
            {
                Log($"线程{currentTaskId}由于达到最大错误次数退出");
            }
            else
            {
                Log($"线程{currentTaskId}运行完成");
            }
            lock (TaskFlagLock)
            {
                TaskFlag[currentTaskId] = false;
            }
        }
    }
    class FarmAccountData
    {
        public FarmAccountData() { }
        public FarmAccountData(int max_friend_point)
        {
            this.max_friend_point = max_friend_point;
        }
        public int max_friend_point = 0;
    }

    class FarmAccount
    {
        public Dictionary<string, FarmAccountData> viewer_id_list = new Dictionary<string, FarmAccountData>();
    }
    class FarmData
    {
        public int friend_point_count = 0;
        public int crown_point_count = 0;
    }
}
