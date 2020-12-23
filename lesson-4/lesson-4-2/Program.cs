using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static string StringNumbers (string number)
        {

            string oneNum, sumStr=null;
            int sum=0;


        for(int i=0;i<number.Length;i++)
                { 
      
                  oneNum= number[i].ToString();
                  bool isNum = int.TryParse(oneNum, out int n);


                if(isNum)
                    {
                   sum=sum+Convert.ToInt32(oneNum);
                   sumStr=sum.ToString();
                    }    
                }
  
            return sumStr;    

        }
        

        static void Main(string[] args)
        {

          
                Console.WriteLine("Введите числа");
                string number = Console.ReadLine();

          
                Console.WriteLine($"Сумма={StringNumbers(number)}");
                
            Console.ReadLine();
        }
    }
}
