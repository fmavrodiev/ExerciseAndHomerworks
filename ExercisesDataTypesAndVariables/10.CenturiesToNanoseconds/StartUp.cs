namespace _10.CenturiesToNanoseconds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            byte centurie = byte.Parse(Console.ReadLine());

            int years = 0;
            int days = 0;
            int hours = 0;
            int minutes = 0;
            ulong seconds = 0;
            ulong milliseconds = 0;
            ulong microseconds = 0;
            ulong nanoseconds = 0;
            
            years = centurie * 100;
            days = (int)(years * 365.2422);
            hours = days * 24;
            minutes = hours * 60;
            seconds = (ulong)minutes * 60;
            milliseconds = seconds * 1000;
            microseconds = milliseconds * 1000;
            nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centurie} centuries = {years} " +
                $"years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = " +
                $"{milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
