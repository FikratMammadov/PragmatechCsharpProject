using System;
using System.Collections;
using System.Linq;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = new string[] { "Fikrat", "Ali", "Samil", "Fikrat", "Ali","Fikrat","Samil" };
            string[] arr2 = new string[] { "Fikrat", "Sefer", "Ali", "Fikrat", "Murad","Ali","Ali","Samil" };
            ArrayList sameNames = new ArrayList();
            string temp="";

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i]==arr2[j])
                    {
                        temp = arr2[j];
                        arr2[j] = "";
                        sameNames.Add(temp);
                        break;
                    }
                }
            }
            for (int i = 0; i < sameNames.Count; i++)
            {
                int count = 1;
                for (int j = i+1; j < sameNames.Count; j++)
                {
                    if (sameNames[i]==sameNames[j])
                    {
                        sameNames.RemoveAt(j);
                        count++;
                    }
                }
                Console.WriteLine("{0} {1}",count,sameNames[i]);
            }
                   
        }
             
    }
    
}
