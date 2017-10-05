namespace _6.StringsAndObjects
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            object helloWorld = firstWord + " " + secondWord;
            Console.WriteLine((string)helloWorld);
        }
    }
}
