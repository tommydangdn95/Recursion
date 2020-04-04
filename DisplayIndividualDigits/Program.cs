using System;

namespace DisplayIndividualDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayIndividualNumber(1234);
        }

        private static void DisplayIndividualNumber(int n)
        {
            if(n < 10)
            {
                Console.Write($"{n} ");
                return;
            }

            DisplayIndividualNumber(n / 10);
            Console.Write($"{n % 10} ");
        }
    }
}
