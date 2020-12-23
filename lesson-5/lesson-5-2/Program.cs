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
           //  Console.WriteLine("Наберите текст");

             string filename="startup.txt";
       //      string time = DateTime.Now;
             File.WriteAllText(filename, DateTime.Now); 

          
            string fileText = File.ReadAllText(filename);
             Console.WriteLine("Вывод текста текст");
             Console.WriteLine(fileText); 
             Console.ReadLine();
        }
    }
}
