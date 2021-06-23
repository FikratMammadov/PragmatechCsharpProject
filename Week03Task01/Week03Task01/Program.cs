using System;

namespace Week03Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            while (num <= 100)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                    sum += num;
                }
                num++;
            }
            Console.WriteLine("Cem: {0}",sum);
        }
    }
}
