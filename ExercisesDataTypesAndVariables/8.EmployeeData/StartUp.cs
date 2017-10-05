namespace _8.EmployeeData
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string employeeFirstName = Console.ReadLine();
            string employeeLastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalId = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {employeeFirstName}");
            Console.WriteLine($"Last name: {employeeLastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalId}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");
        }
    }
}
