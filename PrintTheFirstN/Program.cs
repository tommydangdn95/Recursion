using System;

namespace PrintTheFirstN
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFirstN(0, 10);
        }

        static void PrintFirstN(int index, int n)
        {
            if( index <= n)
            {
                Console.Write($"{index} ");
                PrintFirstN(index + 1, n);
            }
        }
    }
}
