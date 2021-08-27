using System;
using System.IO;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yaratdiginiz subfolderin icinde iki file yaradin,file-lardan biri word,biri excel formatinda olsun.
            string subFolder = @"D:\CSharpGroup3\SubFolderCSharpGroup3\";
            string[] files = new string[] { "textFile.txt", "excelFile.xlsx" };

            foreach (var file in files)
            {
                File.Create(subFolder + file);
            }


        }
    }
}
