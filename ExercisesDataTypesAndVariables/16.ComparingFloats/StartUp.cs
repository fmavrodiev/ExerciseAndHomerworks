namespace _16.ComparingFloats
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal difference = Math.Max(firstNumber, secondNumber) - Math.Min(firstNumber, secondNumber);

            if (Math.Abs(difference) >= 0.000001m)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
