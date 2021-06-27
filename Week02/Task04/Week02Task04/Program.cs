using System;

namespace Week02Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ");
            double eded = Convert.ToDouble(Console.ReadLine());

            if (eded>0)
            {
                Console.WriteLine("Eded musbetdir.");
            }
            else if (eded<0)
            {
                Console.WriteLine("Eded menfidir.");
            }
            else
            {
                Console.WriteLine("Eded ne menfidir, ne de musbetdir.");
            }

        }
    }
}
