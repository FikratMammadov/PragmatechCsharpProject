using System;
using System.IO;
using System.Text;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hemin fileler-i acin ve icine metn yazin.Metni yazarken byte[] halina salaraq yazin.
            string subFolder = @"D:\CSharpGroup3\SubFolderCSharpGroup3";
            int index = 0;
            foreach (var file in Directory.GetFiles(subFolder))
            {
                index++;
                FileStream strm = File.Open(file, FileMode.Open);
                string text = "C# is programming language "+index;
                byte[] textByte = Encoding.Default.GetBytes(text);
                strm.Write(textByte, 0, textByte.Length);
                strm.Close();
            }
        }
    }
}
