namespace _13.VowelOrDigit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string something = Console.ReadLine().ToLower();

            bool isDigit = int.TryParse(something, out int digit);

            if (isDigit)
            {
                Console.WriteLine("digit");
                return;
            }
            if (something == "a" || something == "e" || something == "i" || something == "o" || something == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
