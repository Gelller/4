using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string[,] array = new string[5, 2];

            array[0, 0] = "Иван";
            array[1, 0] = "Сергей";
            array[2, 0] = "Олег";
            array[3, 0] = "Борис";
            array[4, 0] = "Дмитрий";


            array[0, 1] = "88005553535";
            array[1, 1] = "80549871542";
            array[2, 1] = "89652145689";
            array[3, 1] = "89875632125";
            array[4, 1] = "84562593654";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                        Console.Write($"{array[i, j]} ");

                Console.WriteLine();
             //   Console.Write(" ");
            }

            Console.ReadLine();

        }

       

        
    }
}
