namespace _11.ConvertSpeedUnits
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int timeInhours = int.Parse(Console.ReadLine());
            int timeInMinutes = int.Parse(Console.ReadLine());
            int timeInSeconds = int.Parse(Console.ReadLine());

            int totalTime = 0;
            int meterPerSecond = 0;
            int kilometerPerHour = 0;
            int milesPerHour = 0;

            totalTime = timeInhours + timeInMinutes / 60 + timeInSeconds / 3600;

            kilometerPerHour = distanceInMeters / 1000 / totalTime;
            meterPerSecond = kilometerPerHour * 1000 / 3600;
            milesPerHour = distanceInMeters / 1609 / totalTime;
            
            Console.WriteLine(meterPerSecond);
            Console.WriteLine(kilometerPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
