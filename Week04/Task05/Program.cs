using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 2, 52, 21, 34, 26, 11, 32 };

            int numbersLen = numbers.Length;
            int count = 0;
            for (int i = 0; i < numbersLen; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    count++;
                }
            }
            int[] oddNumbers = new int[count];
            int index = 0;
            for (int i = 0; i < numbersLen; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    oddNumbers[index] = numbers[i];
                    index++;
                }
            }

            Console.WriteLine("Tek ededlerin siyahisi: ");
            foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
