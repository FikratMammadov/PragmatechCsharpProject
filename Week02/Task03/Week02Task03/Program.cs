using System;

namespace Week02Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ");
            int eded = Convert.ToInt32(Console.ReadLine());

            if (eded == 0)
            {
                Console.WriteLine("Eded ne tekdir, ne de cutdur.");
            }
            else if (eded % 2 == 0)
            {
                Console.WriteLine("Eded cutdur.");
            }
            else
            {
                Console.WriteLine("Eded tekdir.");
            }

        }
    }
}
