namespace _14.IntegerToHexAndBinary
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string myHex = number.ToString();
            string myBinary = number.ToString();

            myHex = Convert.ToString(number, 16);
            myBinary = Convert.ToString(number, 2);

            Console.WriteLine(myHex.ToUpper());
            Console.WriteLine(myBinary);
        }
    }
}
