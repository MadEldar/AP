using System;

namespace FinalExercise2
{
    class Program
    {
        public delegate void PrimeNumberFinder(int number);

        private static event PrimeNumberFinder OnPrimeNumber;
        
        static void Main(string[] args)
        {
            if (OnPrimeNumber == null)
            {
                OnPrimeNumber += DisplayMessage;
            }
            
            for (int i = 1; i <= 10; i++)
            {
                if (IsPrime(i))
                {
                    OnPrimeNumber(i);
                }
            }
        }

        private static bool IsPrime(int number)
        {
            if (number <= 2)
            {
                return false;
            }

            int i = 2;

            while (i <= number/2)
            {
                if (number % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        private static void DisplayMessage(int number)
        {
            Console.WriteLine(number + "\n");
        }
    }
}