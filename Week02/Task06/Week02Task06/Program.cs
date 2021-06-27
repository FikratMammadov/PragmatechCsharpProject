using System;

namespace Week02Task06
{
    struct Person
    {
        public string _name;
        public string _surname;
        public int _age;

        public Person(string Name,string Surname)
        {
            this._name = Name;
            this._surname = Surname;
            Console.Write("Yasiniz: ");
            this._age = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adiniz: ");
            string name = Console.ReadLine();
            Console.Write("Soyadiniz: ");
            string surname = Console.ReadLine();

            Person p = new Person("Fikrat", "Mammadov");

            if (p._name==name && p._surname==surname)
            {
                if (p._age>=18)
                {
                    Console.WriteLine("Sizin yasiniz uygundur.");
                }
                else
                {
                    Console.WriteLine("Sizin yasiniz uygun deyil.");
                }
            }
            else
            {
                Console.WriteLine("Ad ve ya soyad yalnisdir.");
            }
        }
    }
}
