using System;

namespace Week03Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double num;
            do
            {
                Console.Write("Eded daxil edin: ");
                num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            } while (num != 0);
            Console.WriteLine("Cem: {0}", sum);
        }
    }
}
