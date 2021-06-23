using System;

namespace Week03Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int factorial=1;
            do
            {
                Console.Write("Bir eded daxil edin: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num<0)
                {
                    Console.WriteLine("menfi olmayan tam eded secin.");
                }
                      
            } while (num<0);

            if (num==0)
            {
                factorial = 1;
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
            }
            Console.WriteLine("{0}! = {1}", num, factorial);

        }
    }
}
