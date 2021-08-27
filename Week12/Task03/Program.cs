using System;
using System.IO;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSharpGroup3 folderinin icinde SubFolderCSharpGroup3 folderinin olub olmamasini yoxlayin
            string subFolder = @"D:\CSharpGroup3\SubFolderCSharpGroup3";

            if (Directory.Exists(subFolder))
            {
                Console.WriteLine("this folder exists");
            }
            else
            {
                Console.WriteLine("this folder doesn't exists.");
            }

        }
    }
}
