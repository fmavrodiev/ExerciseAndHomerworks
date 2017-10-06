namespace _12.RectangleProperties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt((width * width) + (height * height));
            double area = width * height;
            double perimeter = (width + height) * 2;

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
