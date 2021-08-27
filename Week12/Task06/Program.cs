using System;
using System.IO;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            //SubFolderCSharpGroup3 folderin icinde olan butun file-lari goturun.
            string subFolder = @"D:\CSharpGroup3\SubFolderCSharpGroup3";
            foreach (var file in Directory.GetFiles(subFolder))
            {
                FileInfo info = new FileInfo(file);
                Console.WriteLine(info.Name);
            }
        }
    }
}
