using System;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adiniz: ");
            string f_name = Console.ReadLine();
            Console.Write("Soyadiniz: ");
            string l_name = Console.ReadLine();
            Console.Write("Yasiniz: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Universitet: ");
            string university = Console.ReadLine();
            Console.WriteLine("Ad: {0}, Soyad: {1}, Yas: {2}, Universitet: {3}", f_name, l_name, age, university);
            Console.ReadLine();

        }
    }
}
