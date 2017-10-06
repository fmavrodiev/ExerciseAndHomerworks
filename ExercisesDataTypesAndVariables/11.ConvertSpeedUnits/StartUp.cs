namespace _11.ConvertSpeedUnits
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float timeInhours = float.Parse(Console.ReadLine());
            float timeInMinutes = float.Parse(Console.ReadLine());
            float timeInSeconds = float.Parse(Console.ReadLine());

            float totalTime = 0;
            float meterPerSecond = 0;
            float kilometerPerHour = 0;
            float milesPerHour = 0;

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
