using System;
using System.IO;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yaratdiginiz subfolderin icinde iki txt file yaradin.
            string subFolder = @"D:\CSharpGroup3\SubFolderCSharpGroup3\";
            string[] files = new string[] { "textFile1.txt", "textFile2.txt", };

            foreach (var file in files)
            {
                File.Create(subFolder + file);
            }
        }
    }
}
