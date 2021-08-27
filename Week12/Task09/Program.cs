using System;
using System.IO;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            string subFolder = @"D:\CSharpGroup3\SubFolderCSharpGroup3";
            foreach (var file in Directory.GetFiles(subFolder))
            {
                if (Path.GetExtension(file) == ".txt")
                {
                    StreamReader sr = File.OpenText(file);
                    Console.WriteLine(sr.ReadToEnd());
                    sr.Close();
                    Console.ReadLine();
                }
            }
        }
    }
}
