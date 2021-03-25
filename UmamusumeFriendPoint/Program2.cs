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

namespace UmamusumeFriendPoint
{
    public class Job
    {
        public int viewer_id, times;
    }

    class Program2
    {
        private static Queue<Job> viewer_ids = new Queue<Job>();
        private static Queue<Job> viewer_ids2 = new Queue<Job>();

        private static readonly int[] support_cards = new int[]
        {
            10027,
            10032,
            10005,
            10009,
            10010
        };
        private const int interval = 800;

        private static void FarmTask(int id)
        {
            Dictionary<int, UserInfoAtFriend> infoCache = new Dictionary<int, UserInfoAtFriend>();
            UmamusumeClient client = new UmamusumeClient(new SimpleLz4Frame(id))
            {
                LogPrefix = $"[Thread #{id}]"
            };
            int vid = 0, vid2 = 0, times;
            bool do_support_chara = false;

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
                    client.Request(new TutorialSkipRequest());

                    client.StartSession();
                    client.Login();
                    var presents = client.ReceivePresents().reward_summary_info.add_item_list;

                    Queue<int> curfriend = new Queue<int>();
                    const int friend_max = 20;

                    while (true)
                    {
                        if (client.tpInfo.current_tp < 30)
                        {
                            if (client.FCoin < 10) break;
                            Console.WriteLine($"[Thread #{id}] recovering tp");
                            Thread.Sleep(interval);
                            client.RetryRequest(new RecoveryTrainerPointRequest
                            {
                                count = 1,
                                client_own_num = client.FCoin
                            });
                        }

                        if (vid == 0)
                        {
                            while (true)
                            {
                                lock (viewer_ids)
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
                            lock (viewer_ids2)
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
                            Thread.Sleep(interval);
                            client.Request(new FriendFollowRequest
                            {
                                friend_viewer_id = vid
                            });
                            curfriend.Enqueue(vid);
                        }

                        if (do_support_chara && !curfriend.Contains(vid2))
                        {
                            Thread.Sleep(interval);
                            client.Request(new FriendFollowRequest
                            {
                                friend_viewer_id = vid2
                            });
                            curfriend.Enqueue(vid2);
                        }

                        while (curfriend.Count > friend_max)
                        {
                            Thread.Sleep(interval);
                            client.Request(new FriendUnFollowerRequest
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

                        Thread.Sleep(interval);
                        var support = infoCache[vid].user_support_card;

                        client.Request(new LoginRequest());

                        var resp = client.RetryRequest(new SingleModeStartRequest
                        {
                            start_chara = new SingleModeStartChara(do_support_chara ? infoCache[vid2] : null)
                            {
                                card_id = 100701,
                                support_card_ids = support_cards,
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

                        var @unchecked = resp.data.unchecked_event_array?.FirstOrDefault();

                        while (@unchecked != null)
                        {
                            Thread.Sleep(interval);
                            @unchecked = client.RetryRequest(new SingleModeCheckEventRequest
                            {
                                event_id = @unchecked.event_id,
                                chara_id = @unchecked.chara_id,
                                choice_number = 0,
                                current_turn = 1
                            }).data.unchecked_event_array?.FirstOrDefault();
                        }

                        Thread.Sleep(interval);
                        client.RetryRequest(new SingleModeFinishRequest
                        {
                            is_force_delete = true,
                            current_turn = 1
                        });

                        Console.WriteLine($"[Thread #{id}] done for ({vid}, {vid2})");
                        vid = 0; vid2 = 0;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine($"[Thread #{id}] {e}");
                }
                client.ResetAccount();
            }
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

            for (int i = 0; i < 16; ++i)
            {
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
        }

    }
}
