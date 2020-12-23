using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static string GetFullName(string firstName, string lastName, string patronymic)
        {
        return firstName= firstName +" "+ lastName +" "+ patronymic;
        }

        static void Main(string[] args)
        {

            for (int i=0;i<3;i++)
                {
                Console.WriteLine("Введите фамилию");
                string firstName = Console.ReadLine();

                Console.WriteLine("Введите имя");
                string lastName = Console.ReadLine();
                        
                Console.WriteLine("Введите отчество");
                string patronymic = Console.ReadLine();

                Console.WriteLine($"ФИО {GetFullName(firstName, lastName, patronymic)}"); 
                }
            Console.ReadLine();
        }
    }
}
