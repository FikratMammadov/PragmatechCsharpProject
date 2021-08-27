using System;
using System.IO;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string subFolder = @"D:\CSharpGroup3\SubFolderCSharpGroup3";

            if (!Directory.Exists(subFolder))
            {
                Directory.CreateDirectory(subFolder);
            }
            
        }
    }
}
