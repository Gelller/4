using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {




            if (string.IsNullOrEmpty(Properties.Settings.Default.name))
            {
                Console.WriteLine("Введите имя");
                Properties.Settings.Default.name = Console.ReadLine();
                Properties.Settings.Default.Save();

            }



            if (string.IsNullOrEmpty(Properties.Settings.Default.age))
            {

                Console.WriteLine("Введите возраст");
                Properties.Settings.Default.age = Console.ReadLine();
                Properties.Settings.Default.Save();

            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.work))
            {
                Console.WriteLine("Введите род деятельности");
                Properties.Settings.Default.work = Console.ReadLine();
                Properties.Settings.Default.Save();


            }

            Console.WriteLine($"Имя {Properties.Settings.Default.name}");
            Console.WriteLine($"Возраст {Properties.Settings.Default.age}");
            Console.WriteLine($"Род деятельности {Properties.Settings.Default.work}");

            Console.ReadLine();
        }
    }
}