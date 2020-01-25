using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ZarAtma
{
    class Program
    {
        static int playerNum;
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç kişi oynayacak");
            playerNum = Convert.ToInt32(Console.ReadLine());

   
            for (int i = 1; i <= playerNum; i++)
            {
                rollStats.Add(new RollStat() {
                    Id = i,
                    Count = 0,
                    Value = 0
                });
                new Thread(Roll).Start(i);
            }
            new Thread(Referee).Start();

        }
        public class RollStat
        {
            public int Id { get; set; }
            public int Count { get; set; }

            public int Value { get; set; }
        }
        private static bool CancelThreads = false;
        private static Random _random = new Random();
        private static List<RollStat> rollStats = new List<RollStat>();
        private static Tuple<int, int, int> Stats = new Tuple<int, int, int>(0,0,0);
        private static void Roll(object id)
        {
            while (true)
            {
                if (CancelThreads)
                {
                    break;
                }
                var selfStat = rollStats.Single(a => a.Id == (int)id);
                if (selfStat.Count < rollStats.OrderByDescending(a => a.Count).First().Count 
                    || rollStats.Count(a => a.Count == selfStat.Count) == playerNum)
                {
                    int result = _random.Next(1, 10);
                    selfStat.Count++;
                    selfStat.Value += result;
                }
                Thread.Sleep(1000);
            }
        }
        private static void Referee()
        {
            int turn = 0;
            while (true)
            {
                
                if (rollStats.Count(a => a.Count == turn) == playerNum)
                {
                    string stats = string.Empty;


                    foreach (RollStat rollStat in rollStats)
                    {
                        stats += rollStat.Id + ": " + rollStat.Value + " |";
                    }

                    Console.WriteLine(stats);

                    if (rollStats.Any(a => a.Value >= 100))
                    {
                        CancelThreads = true;

                        List<RollStat> winners = rollStats.Where(a => a.Value >= 100).ToList();
                        Console.WriteLine("Kazanan belli oldu! " + string.Join(",", winners.Select(a => a.Id)));
                    }
                    turn++;
                }
            }
        }
    }
}
