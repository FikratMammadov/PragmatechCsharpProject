using System;
using System.Linq;

namespace Week03Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random rnd = new Random();

            CheckNumbers:
            for (int i = 0; i < numbers.Length; i++)
            {
                int rndNum = rnd.Next(1, 11);
                numbers[i] = rndNum;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        rndNum = rnd.Next(1, 11);
                        numbers[i] = rndNum;
                        goto CheckNumbers;
                    }
                }
            }

            Console.WriteLine("Array elementleri:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
