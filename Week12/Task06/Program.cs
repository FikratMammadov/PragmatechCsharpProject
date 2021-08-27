using System;
using System.IO;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSharpGroup3 folderin icinde olan butun file-lari goturun ve extension - i txt olan file - i tapin
            string subFolder = @"D:\CSharpGroup3\SubFolderCSharpGroup3";
            foreach (var file in Directory.GetFiles(subFolder))
            {
                FileInfo info = new FileInfo(file);
                if (Path.GetExtension(file)==".txt")
                {
                    Console.WriteLine(info.Name);
                }
            }
        }
    }
}
