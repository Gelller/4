using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число");
            string num = Console.ReadLine();

            bool isNum = int.TryParse(num, out int n);

            if(isNum && (int.Parse(num)%2==0))
                Console.WriteLine("Число четное");
            else if (isNum && (int.Parse(num) % 2 != 0))
                Console.WriteLine("Число нечетное");

            Console.ReadLine();
        }
    }
}
