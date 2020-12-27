using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 0;
            int[,] array = new int[5, 5];
            Console.WriteLine("Вывод двумерного массива по диагонали");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                       Console.Write($"{array[i, j]} ");
                        break;
                    }else

                        Console.Write("  ");
                }
            Console.WriteLine();
           
            }
            Console.ReadLine();
        }
       
    }
}
