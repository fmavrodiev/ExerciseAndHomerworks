namespace _18.DifferentIntegersSize
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string numberToParse = Console.ReadLine();

            if (sbyte.TryParse(numberToParse, out sbyte numSbyte))
            {
                Console.WriteLine("* sbyte");
            }
            if (byte.TryParse(numberToParse, out byte numByte))
            {
                Console.WriteLine("* byte");
            }
            if (short.TryParse(numberToParse, out short numShort))
            {
                Console.WriteLine("* short");
            }
            if (ushort.TryParse(numberToParse, out ushort numUshort))
            {
                Console.WriteLine("* ushort");
            }
            if (int.TryParse(numberToParse, out int numInt))
            {
                Console.WriteLine("* int");
            }
            if (uint.TryParse(numberToParse, out uint numUint))
            {
                Console.WriteLine("* uint");
            }
            if (long.TryParse(numberToParse, out long numLong))
            {
                Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine($"{numberToParse} can't fit in any type");
            }
        }
    }
}
