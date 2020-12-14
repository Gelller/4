using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_4
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
                Console.WriteLine($"Месяц {(monthWord)(int.Parse(month) - 1)}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
                Console.ReadLine();
                return;
            }



            Console.WriteLine("Введите максимальную температуру за сутки");
            string max = Console.ReadLine();
            Console.WriteLine("Введите минимальную температуру за сутки");
            string min = Console.ReadLine();

            bool isNumMax = float.TryParse(max, out float k);
            bool isNumMin = float.TryParse(min, out float m);
            float AveTemp;

            if (isNumMax && isNumMin)
            {
                AveTemp = (float.Parse(max) + float.Parse(min)) / 2;
                Console.WriteLine($"Средняя температура за сутки {AveTemp}°С");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Не число");
                Console.ReadLine();
                return;
            }

            if(AveTemp>0 && (int.Parse(month)>=11|| int.Parse(month) <= 2))
            {
               Console.WriteLine("Дождливая зима");
               Console.ReadLine();
            }





        }
    }
}
