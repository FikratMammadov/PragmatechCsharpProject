using System;
using System.IO;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Komputerin D diskinde CSharpGroup3 adinda folder yaradin
            string path = @"D:\CSharpGroup3";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
