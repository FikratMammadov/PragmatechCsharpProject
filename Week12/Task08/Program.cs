using System;
using System.IO;
using System.Security.AccessControl;
using System.Text;


namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            //sonra txt file-dan metnleri StreamReaderle oxuyub her iki metni birleshdirin ve Console-a cixardin.
            string subFolder = @"D:\CSharpGroup3\SubFolderCSharpGroup3";
            string txt = "";
            foreach (var file in Directory.GetFiles(subFolder))
            {
                if (Path.GetExtension(file) == ".txt")
                {
                    StreamReader sr = File.OpenText(file);
                    txt += sr.ReadToEnd();
                    sr.Close();
                }
            }
            Console.WriteLine(txt);
            Console.ReadLine();
        }
         
    }
}
