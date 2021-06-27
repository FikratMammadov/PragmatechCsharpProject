using System;

namespace Week03Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 11);
            //Console.WriteLine(rndNum);
            int chance = 5;
            int userChoice;
            do
            {
                Console.Write("1 ve 10 arasinda bir eded texmin edin: ");
                userChoice = Convert.ToInt32(Console.ReadLine());
                chance--;
    
                if (chance == 0 && userChoice!=rndNum)
                {
                    Console.WriteLine("Sizin texmin haqqiniz bitmisdir.");
                }
                else
                {
                    if (userChoice == rndNum)
                    {
                        Console.WriteLine("Tebrikler siz duz tapdiniz.");
                        break;
                    }
                    else if (userChoice > rndNum)
                    {
                        Console.WriteLine("Daxil etdiyiniz eded nezerde tutulan ededden boyukdur.");
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded nezerde tutulan ededden kicikdir.");
                    }
                }

            } while (chance!=0);
        }
    }
}
