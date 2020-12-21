using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        enum time {Winter, Spring, Summer, Autumn };



        static string season (string number)
        {
          
            string str="Ошибка: введите число от 1 до 12";

              bool isNum = int.TryParse(number, out int m);

            if(isNum)
                {
                int numTime=Convert.ToInt32(number);
            
                if(numTime==12 || (numTime>=1 && numTime<=2))
                     str=time.Winter.ToString();
                else if (numTime>=6 && numTime<=8)
                      str=time.Summer.ToString();
                else if (numTime>=3 && numTime<=5)
                      str=time.Spring.ToString();
                else if (numTime>=9 && numTime<=11)
                      str=time.Autumn.ToString();
            }

            return str;    
  
        }

        static void Main(string[] args)
        {
            
         
                Console.WriteLine("Введите число месяца");
                string number = Console.ReadLine();

                 Console.WriteLine(season(number));
                
            Console.ReadLine();
        }
    }
}
