﻿using System;
using System.Threading;

namespace ThreadingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Thread(Item).Start();
            new Thread(Item).Start();
            new Thread(Item).Start();
            new Thread(Item).Start();
            new Thread(Item).Start();
            new Thread(Item).Start();

            int completedThreadCount = 0;
            while (true)
            {
                if (completedThreadCount < Count)
                {
                    Console.WriteLine("İşini Bitiren Thread sayısı: " + Count);
                    completedThreadCount = Count;
                }
                Thread.Sleep(500);
            }
            Console.ReadLine();
        }

        private static int Count = 0;
        private static readonly object Locker = new object();

        public static void Item()
        {
            lock (Locker)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(millisecondsTimeout: 2000);
            }
            Count++;
        }
    }
}
