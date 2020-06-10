using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var rangeOfArray = new RangeOfArray(6, 10);
            rangeOfArray[6] = 10;
            rangeOfArray[7] = 70;
            rangeOfArray[8] = 8;
            rangeOfArray[9] = 1;
            rangeOfArray[10] = 44;

            Console.WriteLine($"array size = {rangeOfArray.GetSize()}");

            for (int i = rangeOfArray.GetStartIndex(); i < rangeOfArray.GetEndIndex(); i++)
            {
                Console.WriteLine($"{rangeOfArray[i]}");
            }
            Console.WriteLine();
        }
    }
}
