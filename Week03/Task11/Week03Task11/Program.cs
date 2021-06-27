using System;

namespace Week03Task11
{
    class Program
    {
        static void Main(string[] args)
        {
             
            for (int i = 2; i <= 100; i++)
            {
                int divisor = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i%j==0)
                    {
                        divisor++;
                    }
                }

                if (divisor==2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
