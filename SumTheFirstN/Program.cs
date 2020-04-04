using System;

namespace SumTheFirstN
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = SumTheFirstN(10);
            Console.WriteLine(sum);
        }

        private static int SumTheFirstN(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return n + SumTheFirstN(n - 1);
        }
    }
}
