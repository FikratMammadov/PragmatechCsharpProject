using System;

namespace Task_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir soz daxil edin: ");
            string str = Console.ReadLine();
            Console.WriteLine(str.Length);
            string reverse = "";
            for (int i = str.Length-1; i >= 0; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine("Sozun tersi: {0}",reverse);
        }
    }
}
