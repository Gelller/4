using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Введите слово");
            string str = Console.ReadLine();
                
           

            for (int i = str.Length-1; i>=0; i--)
                Console.Write(str[i]);


            Console.ReadLine();
        }
    }
}
