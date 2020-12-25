using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Наберите произвольный набор чисел (0...255)");
            string path = "text.bin";
            string s = Console.ReadLine();
            if (int.TryParse(s, out num) && ((int.Parse(s) > 0) || (int.Parse(s) < 0xff)))
            {
                File.WriteAllBytes(path, Encoding.UTF8.GetBytes(s));
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            byte[] buffer = File.ReadAllBytes(path);
            Console.WriteLine("Введенные значения в ASCII");
            foreach (byte num3 in buffer)
            {
                Console.WriteLine((int)num3);
            }
            Console.ReadLine();
        }
    }
}
