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
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int rndNum = rnd.Next(0, 10);
                numbers[i] = rndNum;
                CheckNumbers:
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        rndNum = rnd.Next(0, 10);
                        numbers[i] = rndNum;
                        count++;
                        goto CheckNumbers;
                    }
                }
            }

            Console.WriteLine("Array elementleri:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Tekrar sayi: {0}",count);
        }
    }
}
