using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Наберите текст");

             string filename="text.txt";
             string str = Console.ReadLine();
             File.WriteAllText(filename, str); 

          
            string fileText = File.ReadAllText(filename);
             Console.WriteLine("Вывод текста текст");
             Console.WriteLine(fileText); 
             Console.ReadLine();
        }
    }
}
