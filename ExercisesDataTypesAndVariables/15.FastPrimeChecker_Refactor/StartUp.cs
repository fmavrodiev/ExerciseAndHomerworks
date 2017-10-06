namespace _15.FastPrimeChecker_Refactor
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numberToCheck = int.Parse(Console.ReadLine());
            for (int range = 2; range <= numberToCheck; range++)
            {
                bool isPrime = true;
                for (int testNumber = 2; testNumber <= Math.Sqrt(range); testNumber++)
                {
                    if (range % testNumber == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{range} -> {isPrime}");
            }

        }
    }
}
