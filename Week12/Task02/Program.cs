using System;
using System.IO;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Daha sonra hemin folderin icinde eyni adda txt file - i yaradin.
            string fileName = @"D:\CSharpGroup3\CSharpGroup3.txt";
            File.Create(fileName);
        }
    }
}
