using System;

namespace Week03Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] saitler = new char[]{ 'a', 'ı', 'o', 'u', 'e', 'ə', 'i', 'ö', 'ü'};
            Console.Write("Bir soz daxil edin: ");
            string soz = Console.ReadLine();
            int saitSayi = 0;

            for (int i = 0; i < soz.Length; i++)
            {
                for (int j = 0; j < saitler.Length; j++)
                {
                    if (soz[i]==saitler[j])
                    {
                        saitSayi++;
                    }
                }
            }

            if (saitSayi==0)
            {
                Console.WriteLine("Bu sozde sait isledilmemisdir.");
            }
            else
            {
                Console.WriteLine("{0} sait isledilmisdir.", saitSayi);
            }
        }
    }
}
