namespace _10.CenturiesToNanoseconds
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            byte centurie = byte.Parse(Console.ReadLine());

            short years = (short)(centurie * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centurie} centuries = {years} " +
                $"years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = " +
                $"{milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
