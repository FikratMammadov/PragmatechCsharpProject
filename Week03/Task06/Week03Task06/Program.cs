using System;
using System.Linq;

namespace Week03Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            Console.Write("Daxil edeceyiniz adlarin sayi: ");
            arraySize = Convert.ToInt32(Console.ReadLine());
            while (arraySize%2!=0)
            {
                Console.Write("Zehmet olmasa cut eded daxil edin: ");
                arraySize = Convert.ToInt32(Console.ReadLine());
            }

            string[] names = new string[arraySize];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("{0}. adi daxil edin: ", i + 1);
                names[i] = Console.ReadLine();
                CheckArray:
                for (int j = 0; j < i; j++)
                {
                    if (names[i] == names[j])
                    {
                        Console.Write("Bu ad artiq daxil edilib, basqa eded daxil edin: ");
                        names[i] = Console.ReadLine();
                        goto CheckArray;
                    }
                }
            }
            Console.WriteLine("***********");

            string[] firstTeam = new string[arraySize / 2];
            string[] secondTeam = new string[arraySize / 2];

            Random rnd = new Random();

            Console.WriteLine("***********");
            Console.WriteLine("1. Komanda");
            for (int i = 0; i < firstTeam.Length; i++)
            {
                int rndNum = rnd.Next(arraySize);
                firstTeam[i] = names[rndNum];
                CheckFirst:
                for (int j = 0; j < i; j++)
                {
                    if (firstTeam[i] == firstTeam[j])
                    {
                        rndNum = rnd.Next(arraySize);
                        firstTeam[i] = names[rndNum];
                        goto CheckFirst;
                    }
                }
                Console.WriteLine(firstTeam[i]);
            }
            Console.WriteLine("***********");
            Console.WriteLine("2. Komanda");
            for (int i = 0; i < secondTeam.Length; i++)
            {
                int rndNum = rnd.Next(arraySize);
                secondTeam[i] = names[rndNum];
                CheckSecond:
                for (int j = 0; j < i; j++)
                {
                    if (secondTeam[i] == secondTeam[j])
                    {
                        rndNum = rnd.Next(arraySize);
                        secondTeam[i] = names[rndNum];
                        goto CheckSecond;
                    }
                }

                for (int j = 0; j < firstTeam.Length; j++)
                {
                    if (secondTeam[i]==firstTeam[j])
                    {
                        rndNum = rnd.Next(arraySize);
                        secondTeam[i] = names[rndNum];
                        goto CheckSecond;
                    }
                }
                Console.WriteLine(secondTeam[i]);
            }


        }
    }
}
