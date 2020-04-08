using System;

namespace CountTheNumberDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = countDigit(123);
            Console.Write(count);
        }

        static int countDigit(long n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return 1 + countDigit(n / 10);
        }
    }
}
