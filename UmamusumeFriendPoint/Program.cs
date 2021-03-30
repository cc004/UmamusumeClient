using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Umamusume;
using Umamusume.Model;
using Umamusume.Model.Master;

namespace UmamusumeFriendPoint
{
    public class Job
    {
        public int viewer_id, times;
    }

    class Program
    {
        private static Queue<Job> viewer_ids = new Queue<Job>();
        private static Queue<Job> viewer_ids2 = new Queue<Job>();
        private static readonly object vidlock = new object();

        private static readonly object loglock = new object();

        private static readonly Dictionary<long, long> support_dict = MasterContext.Instance.SupportCardData
            .ToDictionary(card => card.Id, card => card.CharaId);

        private static void Log(string message)
        {
            lock (loglock) File.WriteAllText("log.txt", message + "\n");
        }

        private static void FarmTask(int id)
        {
            Dictionary<int, UserInfoAtFriend> infoCache = new Dictionary<int, UserInfoAtFriend>();
            UmamusumeClient client = new UmamusumeClient(new SimpleLz4Frame(id))
            {
                LogPrefix = $"[Thread #{id}]"
            };
            int vid = 0, vid2 = 0, times;
            bool do_support_chara = false;
            Queue<int> curfriend = new Queue<int>();

            while (true)
            {
                try
                {
                    Console.WriteLine($"[Thread #{id}] signing up");
                    times = 3;
                    client.Signup();
                    //var client = new UmamusumeClient(JsonConvert.DeserializeObject<Account>(File.ReadAllText("account.json")));
                    //File.WriteAllText("account.json", JsonConvert.SerializeObject(client.Account));
                    client.StartSession();
                    client.Login();
                    client.RetryRequest(new TutorialSkipRequest());

                    client.StartSession();
                    var login = client.Login();
                    var presents = client.ReceivePresents().reward_summary_info.add_item_list;

                    const int friend_max = 20;

                    while (true)
                    {
                        if (client.tpInfo.current_tp < 30)
                        {
                            if (client.FCoin < 100) break;
                            Console.WriteLine($"[Thread #{id}] recovering tp");
                            client.RetryRequest(new RecoveryTrainerPointRequest
                            {
                                count = 10,
                                client_own_num = client.FCoin
                            });
                        }

                        if (vid == 0)
                        {
                            while (true)
                            {
                                lock (vidlock)
                                {
                                    if (viewer_ids.Count > 0)
                                    {
                                        var job = viewer_ids.Peek();
                                        vid = job.viewer_id;
                                        --job.times;
                                        if (job.times == 0) viewer_ids.Dequeue();
                                        break;
                                    }
                                }
                                Thread.Sleep(1000);
                            }
                        }
                        if (vid2 == 0 && times > 0)
                        {
                            lock (vidlock)
                            {
                                if (do_support_chara = viewer_ids2.Count > 0)
                                {
                                    var job = viewer_ids2.Peek();
                                    vid2 = job.viewer_id;
                                    --job.times;
                                    if (job.times == 0) viewer_ids2.Dequeue();
                                }
                            }
                        }
                        else do_support_chara = false;

                        if (do_support_chara) --times; else vid2 = 0;

                        if (!curfriend.Contains(vid))
                        {
                            try
                            {
                                client.RetryRequest(new FriendFollowRequest
                                {
                                    friend_viewer_id = vid
                                });
                            }
                            catch (ApiException e) when (e.ResultCode == GallopResultCode.FRIEND_FOLLOW_USER_FOLLOW_COUNT_OVER_ERROR)
                            {
                                Log($"error when trying to follow {vid}");
                                ForceRemove(vid);
                                vid = 0;
                                throw;
                            }
                            curfriend.Enqueue(vid);
                        }

                        if (do_support_chara && !curfriend.Contains(vid2))
                        {
                            try
                            {
                                client.RetryRequest(new FriendFollowRequest
                                {
                                    friend_viewer_id = vid2
                                });
                            }
                            catch (ApiException e) when (e.ResultCode == GallopResultCode.FRIEND_FOLLOW_USER_FOLLOW_COUNT_OVER_ERROR)
                            {
                                Log($"error when trying to follow {vid}");
                                ForceRemove(vid);
                                vid = 0;
                                throw;
                            }
                            curfriend.Enqueue(vid2);
                        }

                        while (curfriend.Count > friend_max)
                        {
                            client.RetryRequest(new FriendUnFollowRequest
                            {
                                friend_viewer_id = curfriend.Dequeue()
                            });
                        }

                        if (!infoCache.ContainsKey(vid) || do_support_chara && !infoCache.ContainsKey(vid2))
                        {
                            foreach (var info in client.RetryRequest(new SingleModeRentalInfoRequest())
                                .data.friend_support_card_data.summary_user_info_array)
                                if (!infoCache.ContainsKey(info.viewer_id))
                                    infoCache.Add(info.viewer_id, info);
                        }

                        var support = infoCache[vid].user_support_card;

                        if (support.support_card_id == 0)
                        {
                            Log($"support card for {vid} is none, force removing");
                            ForceRemove1(vid);
                            vid = 0;
                            continue;
                        }

                        if (do_support_chara && infoCache[vid2].user_trained_chara.trained_chara_id == 0)
                        {
                            Log($"support chara for {vid2} is none, force removing");
                            ForceRemove2(vid2);
                            vid2 = 0;
                            continue;
                        }

                        var exclude_chara = do_support_chara ? infoCache[vid2].user_trained_chara.card_id / 100 : 0;
                        var support_cards = new HashSet<int>();
                        long exclude_support = 0;
                        if (support_dict.TryGetValue(support.support_card_id, out var val))
                            exclude_support = val;
                        else
                            Console.WriteLine($"[Thread #{id}] support card {support.support_card_id} for {vid} not present in database, error may occured.");

                        var exclude_charas = new HashSet<long>();
                        exclude_charas.Add(exclude_support);

                        while (support_cards.Count < 5)
                        {
                            var scard = login.data.support_card_list.First(c => !exclude_charas.Contains(support_dict[c.support_card_id])).support_card_id;
                            exclude_charas.Add(support_dict[scard]);
                            support_cards.Add(scard);
                        }    

                        SingleModeStartResponse resp;
                        try
                        {
                            resp = client.RetryRequest(new SingleModeStartRequest
                            {
                                start_chara = new SingleModeStartChara(do_support_chara ? infoCache[vid2] : null)
                                {
                                    card_id = login.data.card_list.First(c => c.card_id / 100 != exclude_chara).card_id,
                                    support_card_ids = support_cards.ToArray(),
                                    friend_support_card_info = new SingleModeFriendSupportCardInfo
                                    {
                                        support_card_id = support.support_card_id,
                                        viewer_id = vid
                                    },
                                    scenario_id = 1,
                                },
                                tp_info = client.tpInfo,
                                current_money = client.current_money
                            });
                        }
                        catch (ApiException e) when (e.ResultCode == GallopResultCode.PARAM_ERROR)
                        {
                            if (exclude_support == 0)
                            {
                                Log($"param error when unknown support card for {vid}, force removing");
                                ForceRemove1(vid);
                                vid = 0;
                            }
                            else if (vid2 != 0)
                            {
                                Log($"unknown error for support chara of {vid2}, force removing");
                                ForceRemove2(vid2);
                                vid2 = 0;
                            }
                            throw;
                        }
                        catch (ApiException e) when (e.ResultCode == GallopResultCode.FRIEND_RENTAL_SUCCESSION)
                        {
                            Log($"error when getting chara for {vid2}, force removing");
                            ForceRemove2(vid2);
                            vid2 = 0;
                            throw;
                        }

                        var @unchecked = resp.data.unchecked_event_array?.FirstOrDefault();

                        while (@unchecked != null)
                        {
                            @unchecked = client.RetryRequest(new SingleModeCheckEventRequest
                            {
                                event_id = @unchecked.event_id,
                                chara_id = @unchecked.chara_id,
                                choice_number = 0,
                                current_turn = 1
                            }).data.unchecked_event_array?.FirstOrDefault();
                        }

                        client.RetryRequest(new SingleModeFinishRequest
                        {
                            is_force_delete = true,
                            current_turn = 1
                        });

                        Console.WriteLine($"[Thread #{id}] done for ({vid}, {vid2})");
                        vid = 0; vid2 = 0;
                    }

                }
                catch (ApiException apie) when (apie.ResultCode == GallopResultCode.SESSION_ERROR)
                {
                    Console.WriteLine($"[Thread #{id}] Session Error, re-logining in");
                    client.StartSession();
                    client.Login();
                    continue;
                }
                catch (ApiException apie)
                {
                    Console.WriteLine($"[Thread #{id}] ApiException: {apie.ResultCode}");
                    client.ResetAccount();
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"[Thread #{id}] {e}");
                }

                while (curfriend.Count > 0)
                {
                    int vid22 = curfriend.Dequeue();
                    try
                    {
                        client.RetryRequest(new FriendUnFollowRequest
                        {
                            friend_viewer_id = vid22
                        });
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"exception caught when trying to unfollow {vid22}:\n{e}");
                    }
                }
                client.ResetAccount();
            }
        }

        private static void ForceRemove1(int vid)
        {
            lock (vidlock)
            {
                Log($"ForceRemove1: removing {viewer_ids.Where(j => j.viewer_id == vid).Sum(j => j.times)} times for {vid}");
                viewer_ids = new Queue<Job>(viewer_ids.Where(j => !(j.viewer_id == vid)));
            }
        }

        private static void ForceRemove2(int vid)
        {
            lock (vidlock)
            {
                Log($"ForceRemove2: removing {viewer_ids2.Where(j => j.viewer_id == vid).Sum(j => j.times)} times for {vid}");
                viewer_ids2 = new Queue<Job>(viewer_ids2.Where(j => !(j.viewer_id == vid)));
            }
        }

        private static void ForceRemove(int vid)
        {
            ForceRemove1(vid);
            ForceRemove2(vid);
        }

        private static void Load()
        {
            try
            {
                viewer_ids = new Queue<Job>(JsonConvert.DeserializeObject<Job[]>(File.ReadAllText("jobs.json")));
                viewer_ids2 = new Queue<Job>(JsonConvert.DeserializeObject<Job[]>(File.ReadAllText("jobs2.json")));
            }
            catch
            {

            }
        }

        private static void Save()
        {
            lock (viewer_ids)
                File.WriteAllText("jobs.json", JsonConvert.SerializeObject(viewer_ids.ToArray()));
            lock (viewer_ids2)
                File.WriteAllText("jobs2.json", JsonConvert.SerializeObject(viewer_ids2.ToArray()));
        }

        public static void Main(string[] args)
        {
            Load();
            var rnd = new Random();

            for (int i = 0; i < 1; ++i)
            {
                Thread.Sleep(rnd.Next(0, 1000));
                int  j = i;
                new Thread(new ThreadStart(() => FarmTask(j))).Start();
            }

            new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    Save();
                    Thread.Sleep(10000);

                    lock (viewer_ids)
                    {
                        if (viewer_ids.Count == 0) Console.WriteLine($"[Watchdog] current job: None");
                        else Console.WriteLine($"[Watchdog] current job: {viewer_ids.Peek().times} times for {viewer_ids.Peek().viewer_id}");
                        Console.WriteLine($"[Watchdog] remaining jobs {viewer_ids.Sum(j => j.times)} for vid = {string.Join(',', viewer_ids.Select(j => j.viewer_id))}");
                    }
                }
            })).Start();

            while (true)
            {
                try
                {
                    var splits = Console.ReadLine().Split(' ');
                    Console.WriteLine($"adding job for viewer_id = {splits[0]}, times = {splits[1]}");
                    lock (viewer_ids) viewer_ids.Enqueue(new Job
                    {
                        viewer_id = int.Parse(splits[0]),
                        times = int.Parse(splits[1])
                    });
                    lock (viewer_ids2) viewer_ids2.Enqueue(new Job
                    {
                        viewer_id = int.Parse(splits[0]),
                        times = 10
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

    }
}
