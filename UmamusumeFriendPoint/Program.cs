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
        public long viewer_id, times;
    }

    class Program
    {
        private static int finish_count = 0;

        private static Queue<Job> viewer_ids = new Queue<Job>();
        private static Queue<Job> viewer_ids2 = new Queue<Job>();
        private static readonly object vidlock = new object();

        private static readonly object loglock = new object();

        private static readonly Dictionary<long, long> support_dict = MasterContext.Instance.SupportCardData
            .ToDictionary(card => card.Id, card => card.CharaId);

        private static readonly InteractServer interact = new (23456);

        private static void Log(string message)
        {
            var now = DateTime.Now;
            var msg = $"{now}] {message}\n";
            lock (interact) interact.Output(msg);
            lock (loglock) File.AppendAllText($"log-{now:MM-dd}.txt", msg);
        }

        private static void FarmTask(int id)
        {
            Dictionary<long, UserInfoAtFriend> infoCache = new Dictionary<long, UserInfoAtFriend>();
            UmamusumeClient client = new UmamusumeClient(new SimpleLz4Frame(id))
            {
                LogPrefix = $"[Thread #{id}]"
            };
            long vid = 0, vid2 = 0, times;
            bool do_support_chara = false;
            Queue<long> curfriend = new Queue<long>();

            while (true)
            {
                try
                {
                    resignup:
                    Console.WriteLine($"[Thread #{id}] signing up");
                    times = 3;
                    curfriend.Clear();
                    infoCache.Clear();
                    client.ResetAccount();
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
                            if (client.FCoin < 200) break;
                            Console.WriteLine($"[Thread #{id}] recovering tp");
                            client.RetryRequest(new RecoveryTrainerPointRequest
                            {
                                count = 20,
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
                                        if (job.times <= 0)
                                        {
                                            Log($"done 1 for {viewer_ids.Peek().viewer_id}");
                                            viewer_ids.Dequeue();
                                        }
                                        break;
                                    }
                                }
                                Thread.Sleep(1000);
                            }
                        }
                        if (vid2 == 0)
                        {
                            lock (vidlock)
                            {
                                do_support_chara = viewer_ids2.Count > 0;
                                if (do_support_chara)
                                {
                                    var job = viewer_ids2.Peek();
                                    vid2 = job.viewer_id;
                                    --job.times;
                                    if (job.times == 0)
                                    {
                                        Log($"done 2 for {viewer_ids2.Peek().viewer_id}");
                                        viewer_ids2.Dequeue();
                                    }
                                }
                            }
                        }
                        else do_support_chara = true;

                        if (do_support_chara) --times;

                        if (!curfriend.Contains(vid))
                        {
                            try
                            {
                                client.RetryRequest(new FriendFollowRequest
                                {
                                    friend_viewer_id = vid
                                });
                            }
                            catch (ApiException e) when (e.ResultCode == GallopResultCode.FRIEND_FOLLOW_USER_FOLLOW_COUNT_OVER_ERROR || e.ResultCode == GallopResultCode.DB_ERROR)
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
                            catch (ApiException e) when (e.ResultCode == GallopResultCode.FRIEND_FOLLOW_USER_FOLLOW_COUNT_OVER_ERROR || e.ResultCode == GallopResultCode.DB_ERROR)
                            {
                                Log($"error when trying to follow {vid2}");
                                ForceRemove(vid2);
                                vid2 = 0;
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

                        var support = infoCache[vid]?.user_support_card?.support_card_id ?? 0;

                        if (support == 0)
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
                        var card_id = login.data.card_list.First(c => c.card_id / 100 != exclude_chara).card_id;

                        var support_cards = new List<int>();
                        var exclude_charas = new HashSet<long>();
                        var cards = new List<TrainedChara>();

                        long exclude_support = 0;
                        if (support_dict.TryGetValue(support, out var val))
                            exclude_support = val;
                        else
                            Console.WriteLine($"[Thread #{id}] support card {support} for {vid} not present in database, error may occured.");

                        if (do_support_chara)
                        {
                            exclude_charas.Add(exclude_chara);
                            cards.Add(null);
                        }
                        exclude_charas.Add(exclude_support);

                        while (cards.Count < 3)
                        {
                            var card = login.data.trained_chara.First(c => !exclude_charas.Contains(c.card_id / 100));
                            exclude_charas.Add(card.card_id / 100);
                            cards.Add(card);
                        }

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
                                start_chara = do_support_chara ?
                                    new SingleModeStartChara
                                    {
                                        succession_trained_chara_id_1 = cards[1].trained_chara_id,
                                        succession_trained_chara_id_2 = 0,
                                        rental_succession_trained_chara = new SingleModeRentalSuccessionChara
                                        {
                                            is_circle_member = false,
                                            trained_chara_id = infoCache[vid2].user_trained_chara.trained_chara_id,
                                            viewer_id = vid2
                                        },
                                        card_id = cards[2].card_id,
                                        support_card_ids = support_cards.ToArray(),
                                        friend_support_card_info = new SingleModeFriendSupportCardInfo
                                        {
                                            support_card_id = support,
                                            viewer_id = vid
                                        },
                                        scenario_id = 1,
                                        selected_difficulty_info = new SingleModeSelectedDifficultyInfo
                                        {
                                            difficulty_id = 0,
                                            difficulty  = 200
                                        }
                                    } :
                                    new SingleModeStartChara
                                    {
                                        succession_trained_chara_id_1 = cards[1].trained_chara_id,
                                        succession_trained_chara_id_2 = cards[0].trained_chara_id,
                                        rental_succession_trained_chara = new SingleModeRentalSuccessionChara
                                        {
                                            is_circle_member = false,
                                            trained_chara_id = 0,
                                            viewer_id = 0
                                        },
                                        card_id = cards[2].card_id,
                                        support_card_ids = support_cards.ToArray(),
                                        friend_support_card_info = new SingleModeFriendSupportCardInfo
                                        {
                                            support_card_id = support,
                                            viewer_id = vid
                                        },
                                        scenario_id = 1,
                                        selected_difficulty_info = new SingleModeSelectedDifficultyInfo
                                        {
                                            difficulty_id = 0,
                                            difficulty = 200
                                        }
                                    },
                                tp_info = client.tpInfo,
                                current_money = client.current_money
                            });
                        }
                        catch (ApiException e) when (e.ResultCode == GallopResultCode.PARAM_ERROR)
                        {
                            Console.WriteLine($"error for support card {support} for {vid} or support chara {(vid2 == 0 ? null : infoCache[vid2].user_trained_chara.card_id)} of {vid2}");

                            if (exclude_support == 0)
                            {
                                Log($"param error when unknown support card {support} for {vid}, force removing");
                                ForceRemove1(vid);
                                vid = 0;
                            }
                            else if (vid2 != 0)
                            {
                                Log($"unknown error for support card {support} for {vid} or support chara {infoCache[vid2].user_trained_chara.card_id} of {vid2}, force removing");
                                ForceRemove2(vid2);
                                vid2 = 0;
                            }
                            else
                            {
                                Log($"unknown error for support card {support} for {vid}, force removing");
                                ForceRemove1(vid);
                                vid = 0;
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
                        Interlocked.Increment(ref finish_count);
                        if (times == 0) throw new Exception("resign for crown point");
                    }

                }
                catch (ApiException apie) when (apie.ResultCode == GallopResultCode.SESSION_ERROR)
                {
                    Console.WriteLine($"[Thread #{id}] Session Error");
                    client.ResetAccount();
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
                    long vid22 = curfriend.Dequeue();
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

                try
                {
                }
                catch
                {

                }

                client.ResetAccount();
            }
        }

        private static void ForceRemove1(long vid)
        {
            lock (vidlock)
            {
                var count = viewer_ids.Where(j => j.viewer_id == vid).Sum(j => j.times);
                if (count > 0)
                    Log($"ForceRemove1: removing {count} times for {vid}");
                viewer_ids = new Queue<Job>(viewer_ids.Where(j => !(j.viewer_id == vid)));
            }
        }

        private static void ForceRemove2(long vid)
        {
            lock (vidlock)
            {
                var count = viewer_ids2.Where(j => j.viewer_id == vid).Sum(j => j.times);
                if (count > 0)
                    Log($"ForceRemove2: removing {count} times for {vid}");
                viewer_ids2 = new Queue<Job>(viewer_ids2.Where(j => !(j.viewer_id == vid)));
            }
        }

        private static void ForceRemove(long vid)
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

        private static int speed;
        private static double req_speed;

        public static void Main(string[] args)
        {
            ThreadPool.SetMaxThreads(1024, 1024);
            ThreadPool.SetMinThreads(256, 256);

            //AccountContext.context.Database.EnsureCreated();


            Load();
            var rnd = new Random();

            new Thread(() =>
            {
                while (true)
                {
                    Save();
                    Thread.Sleep(10000);

                    lock (viewer_ids)
                    {
                        if (viewer_ids.Count == 0) Console.WriteLine($"[Watchdog] current job: None");
                        else Console.WriteLine($"[Watchdog] current job: {viewer_ids.Peek().times} times for {viewer_ids.Peek().viewer_id}");
                        var count = viewer_ids.Sum(j => j.times);
                        Console.WriteLine($"[Watchdog] remaining jobs {count} for vid = ");
                        speed = Interlocked.Exchange(ref finish_count, 0);
                        req_speed = UmamusumeClient.Reqnum / 10.0;
                        Console.WriteLine($"[Watchdog] current speed {speed * 0.36:f1} wpt/h, {req_speed:f1} req/s");
                        if (speed != 0)
                        {
                            var timeneed = new TimeSpan(0, 0, (int)(count * 10 / speed));
                            Console.WriteLine($"[Watchdog] etc {timeneed}, finished in {DateTime.Now + timeneed}");
                        }
                        else
                            Console.WriteLine($"[Watchdog] etc --, finished in --");
                    }
                }
            }).Start();

            new Thread(() =>
            {
                while (true)
                {
                    DoText(Console.ReadLine());
                }
            }).Start();

            interact.Input += s =>
            {
                foreach (var x in s.Split("\n")) DoText(x);
            };

            for (int i = 0; i < 80; ++i)
            {
                Thread.Sleep(rnd.Next(0, 1000));
                int j = i;
                new Thread(() => FarmTask(j)).Start();
            }

        }

        private static void DoText(string msg)
        {
            try
            {
                if (msg == "status")
                {
                    var sb = new StringBuilder();
                    lock (viewer_ids)
                    {
                        sb.AppendLine(viewer_ids.Count == 0
                            ? $"[Watchdog] current job: None"
                            : $"[Watchdog] current job: {viewer_ids.Peek().times} times for {viewer_ids.Peek().viewer_id}");
                        var count = viewer_ids.Sum(j => j.times);
                        sb.AppendLine($"[Watchdog] remaining jobs {count} for vid =");
                        sb.AppendLine($"[Watchdog] current speed {speed * 0.36:f1} wpt/h, {req_speed:f1} req/s");
                        if (speed != 0)
                        {
                            var timeneed = new TimeSpan(0, 0, (int)(count * 10 / speed));
                            sb.AppendLine($"[Watchdog] etc {timeneed}, finished in {DateTime.Now + timeneed}");
                        }
                        else
                            sb.AppendLine($"[Watchdog] etc --, finished in --");
                    }

                    Log(sb.ToString());
                    return;
                }
                if (msg.StartsWith("del"))
                {
                    var vid = long.Parse(msg.Substring(3));
                    ForceRemove(vid);
                    return;
                }
                var splits = msg.Split(' ');
                Console.WriteLine($"adding job for viewer_id = {splits[0]}, times = {splits[1]}");
                Log($"adding job for viewer_id = {splits[0]}, times = {splits[1]}");
                lock (viewer_ids) viewer_ids.Enqueue(new Job
                {
                    viewer_id = long.Parse(splits[0]),
                    times = int.Parse(splits[1])
                });
                lock (viewer_ids2) viewer_ids2.Enqueue(new Job
                {
                    viewer_id = long.Parse(splits[0]),
                    times = 15
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Log(e.ToString());
            }
        }
    }

}
