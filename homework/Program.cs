using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int sizeOfArray;
            Console.Write("Enter size of array: ");
            input = Console.ReadLine();
            sizeOfArray = int.Parse(input);
            double[] array = new double[sizeOfArray];

            ArrayIndexer(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        static public void ArrayIndexer(double[] arr)
        {
            string input;
            double tmp;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter {i + 1} element of array: ");
                input = Console.ReadLine();
                tmp = int.Parse(input);
                tmp = Math.Pow(tmp, 2);
                arr[i] = tmp;
            }
        }
    }
}
