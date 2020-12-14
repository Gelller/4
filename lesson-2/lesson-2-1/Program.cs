using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру за сутки");
            string max=Console.ReadLine();
            Console.WriteLine("Введите минимальную температуру за сутки");
            string min = Console.ReadLine();

            bool isNumMax = float.TryParse(max, out float n);
            bool isNumMin = float.TryParse(min, out float m);

            if (isNumMax && isNumMin)
            {
                float AveTemp = (float.Parse(max) + float.Parse(min)) / 2;
                Console.WriteLine($"Средняя температура за сутки {AveTemp}°С");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Не число");
                Console.ReadLine();
            }
        }
    }
}
