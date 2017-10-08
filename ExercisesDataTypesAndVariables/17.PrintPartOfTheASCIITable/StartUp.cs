namespace _17.PrintPartOfTheASCIITable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (; startNumber <= endNumber; startNumber++)
            {
                Console.Write($"{(char)startNumber} ");
            }
            Console.WriteLine();
        }
    }
}
