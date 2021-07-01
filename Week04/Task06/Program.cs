using System;
using System.Linq;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 32, 12, 54, 4, 23, 56, 34, 12, 54 };

            // Usul 1
            //int min = numbers[0];
            //int numbersLen = numbers.Length;
            //for (int i = 0; i < numbersLen; i++)
            //{
            //    if (numbers[i]<min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            //Console.WriteLine("Minimum: {0}",min);

            // Usul 2
            int min = numbers.Min();
            Console.WriteLine("Minimum: {0}", min);
        }
    }
}
