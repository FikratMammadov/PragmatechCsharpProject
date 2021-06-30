using System;
using System.Linq;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Random rnd = new Random();
            int numbersLength = numbers.Length;
            for (int i = 0; i < numbersLength; i++)
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
            Console.WriteLine("Arrayin elementleri: ");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Arrayin elementlerinin tersden duzulusu: ");
            //usul 1
            //for (int i = numbersLength-1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //usul 2
            Array.Reverse(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

             
        }
    }
}
