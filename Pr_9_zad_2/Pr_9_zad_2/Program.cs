using System;
using System.Text;
using System.IO;

namespace Pr_9_zad_2
{
    class Program
    {
        public static string String_3(string fileName)
        {
            string String_1;
            string buf = "";
            StreamReader reader = new StreamReader(fileName);
            while (!reader.EndOfStream)
            {
                String_1 = reader.ReadLine();
                if (String_1.Length > buf.Length)
                    buf = String_1;

               
            }
            return buf;
        }
        static void Main(string[] args)
        {
            
            string Str = String_3("zadanie_2.txt");
            Console.WriteLine("длинная строка: {0}", Str);
            Console.WriteLine("И её длина: {0}", Str.Length);
        }
    }
}
