using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Random rnd = new Random();
            int numbersLen = numbers.Length;

            for (int i = 0; i < numbersLen; i++)
            {
                int rndNum = rnd.Next(1, 11);
                if (numbers.Contains(rndNum))
                {
                    i--;
                }
                else
                {
                    numbers[i] = rndNum;
                }
            }

            Console.WriteLine("Array elementleri: ");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            //usul 1
            //int sum = 0;
            //foreach (int num in numbers)
            //{
            //    sum += num;
            //}
            //Console.WriteLine("Elementlerin Cemi: {0}",sum);

            //usul 2
            int sum = numbers.Sum();
            Console.WriteLine("Elementlerin Cemi: {0}", sum);


        }
    }
}
