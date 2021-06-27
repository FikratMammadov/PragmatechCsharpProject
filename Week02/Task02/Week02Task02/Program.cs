using System;

namespace Week02Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-ci ededi daxil edin: ");
            double eded1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2-ci ededi daxil edin: ");
            double eded2 = Convert.ToDouble(Console.ReadLine());

            if (eded1>eded2)
            {
                Console.WriteLine("1-ci eded 2-ci ededden boyukdur.");
            }
            else if (eded1<eded2)
            {
                Console.WriteLine("2-ci eded 1-ci ededden boyukdur.");
            }
            else
            {
                Console.WriteLine("1-ci ve 2-ci ededler beraberdirler.");
            }
        }
    }
}
