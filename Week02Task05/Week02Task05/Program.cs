using System;

namespace Week02Task05
{
    struct Student
    {
        public int Grade;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Topladiginiz bal: ");
            byte grade = Convert.ToByte(Console.ReadLine());

            Student s = new Student();
            s.Grade = grade;

            if (s.Grade>=91 && s.Grade<=100)
            {
                Console.WriteLine("Tebrikler siz A aldiniz.");
            }
            else if (s.Grade >= 81 && s.Grade <= 90)
            {
                Console.WriteLine("Tebrikler siz B aldiniz.");
            }
            else if (s.Grade >= 71 && s.Grade <= 80)
            {
                Console.WriteLine("Tebrikler siz C aldiniz.");
            }
            else if (s.Grade >= 61 && s.Grade <= 70)
            {
                Console.WriteLine("Tebrikler siz B aldiniz.");
            }
            else if (s.Grade >= 51 && s.Grade <= 60)
            {
                Console.WriteLine("Tebrikler siz B aldiniz.");
            }
            else if (s.Grade <= 50)
            {
                Console.WriteLine("Kesildiniz.");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded bal sistemine uygun deyil.");
            }
        }
    }
}
