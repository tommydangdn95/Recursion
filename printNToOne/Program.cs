using System;

namespace printNToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNTo1(10);
        }

        private static void PrintNTo1(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                PrintNTo1(n-1);
            }
        }
    }
}
