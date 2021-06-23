using System;

namespace Week03Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Arrayin olcusunu daxil edin: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[arraySize];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("{0}-ci adi daxil edin: ", i + 1);
                names[i] = Console.ReadLine();
            }

            Console.Write("Daxil edilen adlardan birini secin: ");
            string chosenName = Console.ReadLine();
            int numOfChosenName = 0;

            foreach (string name in names)
            {
                if (name==chosenName)
                {
                    numOfChosenName++;
                }
            }
            Console.WriteLine("Secilmis ad: {0}, Secilmis ad sayisi: {1}",chosenName,numOfChosenName);
             
        }
    }
}
