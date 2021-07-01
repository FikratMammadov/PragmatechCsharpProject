using System;
using System.Collections;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList members = new ArrayList();
            Console.WriteLine("Sport komplekse qeydiyyat sistemi");
            Console.WriteLine("********************************");
        Begin:
            Console.WriteLine("1-Uzv daxil edin \n2-Uzvu qeydiyyatdan silin \n3-Uzvlerin siyahisini" +
                " gorun\n4-Uzvlerin siyahini ters cevirin\n5-Uzvlerin qeydiyyatda olub olmamasini yoxlayin" +
                "\n6-Uzvlerin siyahisini bashdan sona siralayin\n7-Butun uzvlerin qeydiyyatini silin" +
                "\n8-Sport komlekse qeydiyyat sisteminden cixin");
            Console.Write("Edeceyiniz emeliyyati secin: ");
            char choice = Convert.ToChar(Console.ReadLine());
            string msg = "Emeliyyat ugurla basa catdi.";
            string member, answer;
            int membersLength;

            switch (choice)
            {
                case '1':
                    Console.Write("Daxil edilecek uzv sayi: ");
                    int memberNum = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < memberNum; i++)
                    {
                        Console.Write("{0}. Uzv: ",i+1);
                        member = Console.ReadLine();
                        members.Add(member);
                    }
                    Console.WriteLine(msg);
                    Console.Write("Emeliyyatlara davam etmek isteyirsinizmi? Beli? Xeyr?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "beli")
                    {
                        goto Begin;
                    }
                    else
                    {
                        break;
                    }

                case '2':
                    Console.WriteLine("Uzvlerin Siyahisi: ");
                    membersLength = members.Count;
                    for (int i = 0; i < membersLength; i++)
                    {
                        Console.WriteLine("{0} - {1}", i + 1, members[i]);
                    }
                    Console.Write("Silmek istediyiniz uzv: ");
                    member = Console.ReadLine();
                    members.Remove(member);

                    Console.WriteLine(msg);
                    Console.Write("Emeliyyatlara davam etmek isteyirsinizmi? Beli? Xeyr?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "beli")
                    {
                        goto Begin;
                    }
                    else
                    {
                        break;
                    }
                case '3':
                    Console.WriteLine("Uzvlerin Siyahisi: ");
                    membersLength = members.Count;
                    for (int i = 0; i < membersLength; i++)
                    {
                        Console.WriteLine("{0} - {1}", i + 1, members[i]);
                    }
                    Console.WriteLine(msg);
                    Console.Write("Emeliyyatlara davam etmek isteyirsinizmi? Beli? Xeyr?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "beli")
                    {
                        goto Begin;
                    }
                    else
                    {
                        break;
                    }
                case '4':
                    Console.WriteLine("Uzvlerin Tersden Siyahisi: ");
                    membersLength = members.Count;
                    for (int i = membersLength - 1; i >= 0; i--)
                    {
                        Console.WriteLine("{0} - {1}", i + 1, members[i]);
                    }

                    Console.WriteLine(msg);
                    Console.Write("Emeliyyatlara davam etmek isteyirsinizmi? Beli? Xeyr?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "beli")
                    {
                        goto Begin;
                    }
                    else
                    {
                        break;
                    }
                case '5':
                    Console.Write("Yoxlamaq istediyiniz uzv: ");
                    member = Console.ReadLine();
                    if (members.Contains(member))
                    {
                        Console.WriteLine("Bu uzv qeydiyyatdadir.");
                    }
                    else
                    {
                        Console.WriteLine("Bu uzv qeydiyyatda deyil.");
                    }

                    Console.WriteLine(msg);
                    Console.Write("Emeliyyatlara davam etmek isteyirsinizmi? Beli? Xeyr?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "beli")
                    {
                        goto Begin;
                    }
                    else
                    {
                        break;
                    }
                case '6':
                    members.Sort();
                    foreach (string m in members)
                    {
                        Console.WriteLine(m);
                    }

                    Console.WriteLine(msg);
                    Console.Write("Emeliyyatlara davam etmek isteyirsinizmi? Beli? Xeyr?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "beli")
                    {
                        goto Begin;
                    }
                    else
                    {
                        break;
                    }
                case '7':
                    members.Clear();

                    Console.WriteLine(msg);
                    Console.Write("Emeliyyatlara davam etmek isteyirsinizmi? Beli? Xeyr?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "beli")
                    {
                        goto Begin;
                    }
                    else
                    {
                        break;
                    }
                case '8':
                    Console.WriteLine("Proqramdan cixildi.");
                    break;
                default:
                    Console.WriteLine("Secdiyiniz emeliyyat yalnisdir. Zehmet olmasa yeniden secin: ");
                    goto Begin;
            }
        }
    }
}
