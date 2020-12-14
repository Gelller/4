using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_2
{
    class Program
    {
        enum monthWord { Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь };
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца");
            string month = Console.ReadLine();

            bool isNunMonth = int.TryParse(month, out int n);

            if (isNunMonth && (int.Parse(month) >= 1) && (int.Parse(month) <= 12))
            {
                Console.WriteLine($"Месяц {(monthWord)(int.Parse(month)-1)}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
                Console.ReadLine();
            }
        }
    }
}
