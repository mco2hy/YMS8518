using System;
using System.Threading;

namespace MultiThreadingApp
{
    class Program
    {
        public class Threading
        {
            public bool CancelThreads = false;
            public int Thread2Turn = 1;
            public bool Thread1Running = false;
            public bool Thread2Running = false;

            public void Thread1()
            {
                Thread1Running = true;
                int i = 1;
                while (true)
                {
                    if (CancelThreads)
                    {
                        Thread1Running = false;
                        break;
                    }
                    //if (i == 10)
                    //{
                    //    Program.CancelThread2 = true;
                    //}
                    Console.WriteLine(i + "Thread 1: " + DateTime.Now.Ticks);
                    Console.WriteLine(Program.Thread2Turn + "Thread 2: " + DateTime.Now.Ticks);
                    Thread.Sleep(1000);
                    i++;
                }
            }
            public void Thread2(object id)
            {
                Thread2Running = true;
                Program.Thread2Turn = 1;
                while (true)
                {
                    if (CancelThreads)
                    {
                        Thread2Running = false;
                        break;
                    }
                    //if (Program.CancelThread2 == true)
                    //{
                    //    break;
                    //}
                    //Console.WriteLine(i + "Thread 2 " + DateTime.Now.Ticks);
                    Thread.Sleep((int)id);
                    Thread2Turn++;
                }
            }
        }
        public static int Thread2Turn = 1;
        //public static bool CancelThread2 = false;
        static void Main(string[] args)
        {
            Console.WriteLine("H3110 IRRAQ!");
            Threading threading = new Threading();
            new Thread(threading.Thread1).Start();
            new Thread(threading.Thread2).Start(1000);

            //Threading threading2 = new Threading();
            //new Thread(threading2.Thread1).Start();
            //new Thread(threading2.Thread2).Start(300);

            Console.WriteLine("MAIN THREAD BEKLİYOR: ENTER' A BASARAK DİĞER BLOĞA GEÇİNİZ.");
            Console.ReadLine();
            Console.WriteLine("DİĞER BLOK");
            threading.CancelThreads = true;

            while (true)
            {
                if (!threading.Thread1Running && !threading.Thread2Running)
                {
                    threading.CancelThreads = false;
                    break;
                }

            }

            new Thread(threading.Thread1).Start();
            new Thread(threading.Thread2).Start(1000);
            Console.ReadLine();

        }
    }
}
