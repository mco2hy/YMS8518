using System;

namespace Deputation
{
    class Program
    {

        static void Main(string[] args)
        {


























            ////////Action<string, string> testDelegate2 = Concat;
            ////////testDelegate2("x", "y");

            ////////Console.WriteLine("Singleton'dan Gelen Nesne: " + ConcattedString);

            ////////Console.ReadLine();



























            //////Func<string, string, string> testDelegate;
            //////testDelegate = delegate (string x, string y)
            //////{
            //////    return y + x;
            //////};

            //////string output = testDelegate("bilge", "adam");
            //////Console.WriteLine(output);

            ////testDelegate = Concat;
            ////output = testDelegate("bilge", "adam");
            ////Console.WriteLine(output);

            ////Console.ReadLine();

























            //Func<int, int, int> testDelegate = Bol;
            //int output = testDelegate(2, 3);
            //Console.WriteLine(output);

            //testDelegate = Carp;
            //output = testDelegate(4, 5);

            //Console.WriteLine(output);
            //Console.ReadLine();
        }
        ////////public static string ConcattedString = string.Empty;
        ////////public static void Concat(string ilk, string son)
        ////////{
        ////////    ConcattedString = ilk + son ;
        ////////    Console.WriteLine( ilk + son);
        ////////} 
        ////public static string Concat(string ilk, string son)
        ////{
        ////    return ilk + son;
        ////} 
        //public static int Carp(int x, int y)
        //{
        //    return x * y;
        //}
        //public static int Bol(int x, int y)
        //{
        //    return x / y;
        //}
    }
}
