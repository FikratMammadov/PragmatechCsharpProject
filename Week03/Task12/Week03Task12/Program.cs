using System;

namespace Week03Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. ededi daxil edin: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. ededi daxil edin: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} ve {1} arasindaki sade ededler: ",num1,num2);
            for (int i = num1; i <= num2; i++)
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
