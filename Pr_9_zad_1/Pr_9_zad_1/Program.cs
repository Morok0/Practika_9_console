using System;
using System.Text;
using System.IO;

namespace Pr_9_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "MyFile.txt";

            var WriterStream = new StreamWriter(path);
            Console.WriteLine("Введите количество символов");
            int n =int.Parse (Console.ReadLine()) ;
            for (double i = 0; i <= n; i++)
            {
                WriterStream.WriteLine(1 / i);
            }
            WriterStream.Close();
            var rows = File.ReadAllLines(path);

            for (int i = 3; i <= rows.Length; i += 3)
            {
                Console.WriteLine(rows[i]);
            }
        }
    }
}
