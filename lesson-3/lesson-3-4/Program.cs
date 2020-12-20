using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        //функция вывода массива
        static void a(ref byte[,] array, int we)
        {
            Console.Clear();

            if (we == 0)
            {
                Console.WriteLine("Морской бой");
                Console.WriteLine("Управление вверх-W, вниз-S, влево-A, вправо-D, разместить корабль-пробел");
            }
            if (we == 1)
            {
                Console.WriteLine("Нельзя разместить");
                Console.WriteLine("Управление вверх-W, вниз-S, влево-A, вправо-D, разместить корабль-пробел");
            }
            if (we == 2)
                Console.WriteLine("555");




            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{array[i, j]} ");

                Console.WriteLine();
            }

         //ниже приведины  функции для размещения кораблей (если в ячейки уже отмечено что будет стоять корабль она не обнуляется)
        }
        static void control_2_1(bool r1, bool r2, ref byte[,] array, int x, int y)
        {
            if (r1 == true && r2 == true)
            {
                array[x, y] = 1;
                array[x, y + 1] = 1;

            }
            else if (r1 == true)
            {
                array[x, y] = 1;
                array[x, y + 1] = 0;

            }
            else if (r2 == true)
            {
                array[x, y] = 0;
                array[x, y + 1] = 1;
            }

            else
            {
                array[x, y] = 0;
                array[x, y + 1] = 0;
            }


       }

        static void control_2_2(ref bool r1, ref bool r2, ref byte[,] array, int x, int y)
        {

            if (array[x, y] == 1 && array[x, y + 1] == 1)
            {
                r1 = true;
                r2 = true;
            }
            else if (array[x, y] == 1 && array[x, y + 1] == 0)
            {
                r1 = true;
                r2 = false;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 1)
            {
                r1 = false;
                r2 = true;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 0)
            {
                r1 = false;
                r2 = false;
            }
            array[x, y] = 1;

        }

        static void contror_3_1(bool r1, bool r2, bool r3, ref byte[,] array, int x, int y)
        {

            if (r1 == true && r2 == true && r3 == true)
            {
                array[x, y] = 1;
                array[x, y + 1] = 1;
                array[x, y + 2] = 1;
            }
            else if (r1 == true && r2 == true && r3 == false)
            {
                array[x, y] = 1;
                array[x, y + 1] = 1;
                array[x, y + 2] = 0;

            }
            else if (r1 == true && r2 == false && r3 == true)
            {
                array[x, y] = 1;
                array[x, y + 1] = 0;
                array[x, y + 2] = 1;
            }
            else if (r1 == true && r2 == false && r3 == false)
            {
                array[x, y] = 1;
                array[x, y + 1] = 0;
                array[x, y + 2] = 0;
            }
            else if (r1 == false && r2 == true && r3 == true)
            {
                array[x, y] = 0;
                array[x, y + 1] = 1;
                array[x, y + 2] = 1;
            }
            else if (r1 == false && r2 == true && r3 == false)
            {
                array[x, y] = 0;
                array[x, y + 1] = 1;
                array[x, y + 2] = 0;
            }
            else if (r1 == false && r2 == false && r3 == true)
            {
                array[x, y] = 0;
                array[x, y + 1] = 0;
                array[x, y + 2] = 1;
            }

            else if (r1 == false && r2 == false && r3 == false)
            {
                array[x, y] = 0;
                array[x, y + 1] = 0;
                array[x, y + 2] = 0;
            }

        }

        public static void control_3_2(ref bool r1, ref bool r2, ref bool r3, ref byte[,] array, int x, int y)
        {


            if (array[x, y] == 1 && array[x, y + 1] == 1 && array[x, y + 2] == 1)
            {
                r1 = true;
                r2 = true;
                r3 = true;
            }


            else if (array[x, y] == 1 && array[x, y + 1] == 1 & array[x, y + 2] == 0)
            {
                r1 = true;
                r2 = true;
                r3 = false;
            }
            else if (array[x, y] == 1 && array[x, y + 1] == 0 & array[x, y + 2] == 1)
            {
                r1 = true;
                r2 = false;
                r3 = true;
            }
            else if (array[x, y] == 1 && array[x, y + 1] == 0 & array[x, y + 2] == 0)
            {
                r1 = true;
                r2 = false;
                r3 = false;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 1 & array[x, y + 2] == 1)
            {
                r1 = false;
                r2 = true;
                r3 = true;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 1 & array[x, y + 2] == 0)
            {
                r1 = false;
                r2 = true;
                r3 = false;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 0 & array[x, y + 2] == 1)
            {
                r1 = false;
                r2 = false;
                r3 = true;
            }

            else if (array[x, y] == 0 && array[x, y + 1] == 0 & array[x, y + 2] == 0)
            {
                r1 = false;
                r2 = false;
                r3 = false;
            }
            array[x, y] = 1;


        }

        static void control_4_1(bool r1, bool r2, bool r3, bool r4, ref byte[,] array, int x, int y)
        {

            if (r1 == true && r2 == true && r3 == true && r4 == true)
            {
                array[x, y] = 1;
                array[x, y + 1] = 1;
                array[x, y + 2] = 1;
                array[x, y + 3] = 1;
            }

            if (r1 == true && r2 == true && r3 == true && r4 == false)
            {
                array[x, y] = 1;
                array[x, y + 1] = 1;
                array[x, y + 2] = 1;
                array[x, y + 3] = 0;
            }
            else if (r1 == true && r2 == true && r3 == false && r4 == true)
            {
                array[x, y] = 1;
                array[x, y + 1] = 1;
                array[x, y + 2] = 0;
                array[x, y + 3] = 1;
            }
            else if (r1 == true && r2 == true && r3 == false && r4 == false)
            {
                array[x, y] = 1;
                array[x, y + 1] = 1;
                array[x, y + 2] = 0;
                array[x, y + 3] = 0;
            }
            else if (r1 == true && r2 == false && r3 == true && r4 == true)
            {
                array[x, y] = 1;
                array[x, y + 1] = 0;
                array[x, y + 2] = 1;
                array[x, y + 3] = 1;
            }
            else if (r1 == true && r2 == false && r3 == true && r4 == false)
            {
                array[x, y] = 1;
                array[x, y + 1] = 0;
                array[x, y + 2] = 1;
                array[x, y + 3] = 0;
            }
            else if (r1 == true && r2 == false && r3 == false && r4 == true)
            {
                array[x, y] = 1;
                array[x, y + 1] = 0;
                array[x, y + 2] = 0;
                array[x, y + 3] = 1;
            }
            else if (r1 == true && r2 == false && r3 == false && r4 == false)
            {
                array[x, y] = 1;
                array[x, y + 1] = 0;
                array[x, y + 2] = 0;
                array[x, y + 3] = 0;
            }

            else if (r1 == false && r2 == true && r3 == true && r4 == true)
            {
                array[x, y] = 0;
                array[x, y + 1] = 1;
                array[x, y + 2] = 1;
                array[x, y + 3] = 1;
            }
            else if (r1 == false && r2 == true && r3 == true && r4 == false)
            {
                array[x, y] = 0;
                array[x, y + 1] = 1;
                array[x, y + 2] = 1;
                array[x, y + 3] = 0;
            }
            else if (r1 == false && r2 == true && r3 == false && r4 == true)
            {
                array[x, y] = 0;
                array[x, y + 1] = 1;
                array[x, y + 2] = 0;
                array[x, y + 3] = 1;
            }
            else if (r1 == false && r2 == true && r3 == false && r4 == false)
            {
                array[x, y] = 0;
                array[x, y + 1] = 1;
                array[x, y + 2] = 0;
                array[x, y + 3] = 0;
            }
            else if (r1 == false && r2 == false && r3 == true && r4 == true)
            {
                array[x, y] = 0;
                array[x, y + 1] = 0;
                array[x, y + 2] = 1;
                array[x, y + 3] = 1;
            }
            else if (r1 == false && r2 == false && r3 == true && r4 == false)
            {
                array[x, y] = 0;
                array[x, y + 1] = 0;
                array[x, y + 2] = 1;
                array[x, y + 3] = 0;
            }
            else if (r1 == false && r2 == false && r3 == false && r4 == true)
            {
                array[x, y] = 0;
                array[x, y + 1] = 0;
                array[x, y + 2] = 0;
                array[x, y + 3] = 1;
            }
            else if (r1 == false && r2 == false && r3 == false && r4 == false)
            {
                array[x, y] = 0;
                array[x, y + 1] = 0;
                array[x, y + 2] = 0;
                array[x, y + 3] = 0;
            }

        }


        public static void control_4_2(ref bool r1, ref bool r2, ref bool r3, ref bool r4, ref byte[,] array, int x, int y)
        {


            if (array[x, y] == 1 && array[x, y + 1] == 1 && array[x, y + 2] == 1 && array[x, y+3] == 1)
            {
                r1 = true;
                r2 = true;
                r3 = true;
                r4 = true;
            }
            else if (array[x, y] == 1 && array[x, y + 1] == 1 && array[x, y + 2] == 1 && array[x, y + 3] == 0)
            {
                r1 = true;
                r2 = true;
                r3 = true;
                r4 = false;
            }
            else if (array[x, y] == 1 && array[x, y + 1] == 1 && array[x, y + 2] == 0 && array[x, y + 3] == 1)
            {
                r1 = true;
                r2 = true;
                r3 = false;
                r4 = true;
            }
            else if (array[x, y] == 1 && array[x, y + 1] == 1 && array[x, y + 2] == 0 && array[x, y + 3] == 0)
            {
                r1 = true;
                r2 = true;
                r3 = false;
                r4 = false;
            }
            else if (array[x, y] == 1 && array[x, y + 1] == 0 && array[x, y + 2] == 1 && array[x, y + 3] == 1)
            {
                r1 = true;
                r2 = false;
                r3 = true;
                r4 = true;
            }
            else if (array[x, y] == 1 && array[x, y + 1] == 0 && array[x, y + 2] == 1 && array[x, y + 3] == 0)
            {
                r1 = true;
                r2 = false;
                r3 = true;
                r4 = false;
            }
            else if (array[x, y] == 1 && array[x, y + 1] == 0 && array[x, y + 2] == 0 && array[x, y + 3] == 1)
            {
                r1 = true;
                r2 = false;
                r3 = false;
                r4 = true;
            }
            else if (array[x, y] == 1 && array[x, y + 1] == 0 && array[x, y + 2] == 0 && array[x, y + 3] == 0)
            {
                r1 = true;
                r2 = false;
                r3 = false;
                r4 = false;
            }

            else if (array[x, y] == 0 && array[x, y + 1] == 1 && array[x, y + 2] == 1 && array[x, y + 3] == 1)
            {
                r1 = false;
                r2 = true;
                r3 = true;
                r4 = true;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 1 && array[x, y + 2] == 1 && array[x, y + 3] == 0)
            {
                r1 = false;
                r2 = true;
                r3 = true;
                r4 = false;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 1 && array[x, y + 2] == 0 && array[x, y + 3] == 1)
            {
                r1 = false;
                r2 = true;
                r3 = false;
                r4 = true;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 1 && array[x, y + 2] == 0 && array[x, y + 3] == 0)
            {
                r1 = false;
                r2 = true;
                r3 = false;
                r4 = false;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 0 && array[x, y + 2] == 1 && array[x, y + 3] == 1)
            {
                r1 = false;
                r2 = false;
                r3 = true;
                r4 = true;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 0 && array[x, y + 2] == 1 && array[x, y + 3] == 0)
            {
                r1 = false;
                r2 = false;
                r3 = true;
                r4 = false;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 0 && array[x, y + 2] == 0 && array[x, y + 3] == 1)
            {
                r1 = false;
                r2 = false;
                r3 = false;
                r4 = true;
            }
            else if (array[x, y] == 0 && array[x, y + 1] == 0 && array[x, y + 2] == 0 && array[x, y + 3] == 0)
            {
                r1 = false;
                r2 = false;
                r3 = false;
                r4 = false;
            }
            array[x, y] = 1;


        }


        static void Main(string[] args)
        {


            int we = 0;

            byte[,] array = new byte[10, 10];

            bool r = true, r1 = false, r2 = false, r3 = false, r4 = false;

            Console.WriteLine("Разместите однопалубный корабль");

            int x = 0, y = 0;

            a(ref array, we);

            //размещение 4 однопалубный кораблей
            for (int i = 0; i < 4; i++)
            {


                x = 0;
                y = 0;

                if (array[0, 0] == 1)
                    r1 = true;

                r = true;


                while (r)
                {

                    array[x, y] = 1;
                    a(ref array, we);
                    var b = Console.ReadKey();


                    switch (b.KeyChar)
                    {
                        case 's':

                            if (r1 == true)
                                array[x, y] = 1;
                            else
                                array[x, y] = 0;

                            if (x < 9)
                                x++;
                            we = 0;

                            if (array[x, y] == 1)
                                r1 = true;
                            else
                                r1 = false;


                            array[x, y] = 1;

                            break;

                        case 'd':
                            if (r1 == true)
                                array[x, y] = 1;
                            else
                                array[x, y] = 0;

                            if (y < 9)
                                y++;

                            we = 0;

                            if (array[x, y] == 1)
                                r1 = true;
                            else
                                r1 = false;
                            array[x, y] = 1;
                            break;

                        case 'a':

                            if (r1 == true)
                                array[x, y] = 1;
                            else
                                array[x, y] = 0;

                            if (y != 0)
                                y--;

                            we = 0;
                            if (array[x, y] == 1)
                                r1 = true;
                            else
                                r1 = false;
                            array[x, y] = 1;
                            break;

                        case 'w':
                            if (r1 == true)
                                array[x, y] = 1;
                            else
                                array[x, y] = 0;

                            if (x != 0)
                                x--;
                            we = 0;

                            if (array[x, y] == 1)
                                r1 = true;
                            else
                                r1 = false;
                            break;


                        case ' ':

                            if ((x > 0 && y > 0) && (x < 9 && y < 9) && r1 != true &&
                                       (array[x + 1, y] != 1 && array[x - 1, y] != 1 && array[x, y + 1] != 1 && array[x, y - 1] != 1 &&
                                      array[x - 1, y - 1] != 1 && array[x + 1, y + 1] != 1 && array[x + 1, y - 1] != 1 && array[x - 1, y + 1] != 1))
                                r = false;

                            else if ((y == 0 && x == 0 && array[x + 1, y] != 1 && array[x + 1, y + 1] != 1 && array[x, y + 1] != 1 && r1 != true)
                                || (y == 0 && x == 9 && array[x - 1, y] != 1 && array[x - 1, y + 1] != 1 && array[x, y + 1] != 1 && r1 != true)
                                || (y == 9 && x == 0 && array[x, y - 1] != 1 && array[x + 1, y - 1] != 1 && array[x + 1, y] != 1 && r1 != true)
                                || (x == 9 && x == 9 && array[x, y - 1] != 1 && array[x - 1, y - 1] != 1 && array[x - 1, y] != 1 && r1 != true))
                                r = false;

                            else if ((y == 0 && x > 0 && x < 9 && array[x + 1, y] != 1 && array[x + 1, y + 1] != 1 && array[x, y + 1] != 1 && array[x - 1, y + 1] != 1 && array[x - 1, y] != 1 && r1 != true)
                                || (x == 0 && y > 0 && y < 9 && array[x, y - 1] != 1 && array[x + 1, y - 1] != 1 && array[x + 1, y] != 1 && array[x + 1, y + 1] != 1 && array[x, y + 1] != 1 && r1 != true)
                                || (y == 9 && x > 0 && x < 9 && array[x - 1, y] != 1 && array[x - 1, y - 1] != 1 && array[x + 1, y] != 1 && array[x - 1, y] != 1 && array[x - 1, y - 1] != 1 && r1 != true)
                                || (x == 9 && y > 0 && y < 9 && array[x, y - 1] != 1) && array[x + 1, y - 1] != 1 && array[x - 1, y] != 1 && array[x - 1, y + 1] != 1 && array[x, y + 1] != 1 && r1 != true)
                                r = false;

                            else
                                we = 1;

                            //   r = false;   
                            break;
                    }




                    a(ref array, we);

                }

            }


            //размещение 3 двухпалубных кораблей
            for (int i = 0; i < 3; i++)
            {

                x = 0;
                y = 0;


                if (array[0, 0] == 1)
                    r1 = true;
               if (array[0, 1] == 1)
                    r2 = true;

                r = true;

                while (r)
                {

                    array[x, y] = 1;
                    array[x, y + 1] = 1;

                    a(ref array, we);
                    var b = Console.ReadKey();



                    switch (b.KeyChar)
                    {
                        case 's':

                            control_2_1(r1, r2, ref array, x, y);

                            if (x < 9)
                                x++;

                            we = 0;

                            control_2_2(ref r1, ref r2, ref array, x, y);

                            break;

                        case 'd':

                            control_2_1(r1, r2, ref array, x, y);

                            if (y < 8)
                                y++;
                            we = 0;

                            control_2_2(ref r1, ref r2, ref array, x, y);


                            break;

                        case 'a':

                            control_2_1(r1, r2, ref array, x, y);

                            if (y != 0)
                                y--;
                            we = 0;
;
                            control_2_2(ref r1, ref r2, ref array, x, y);

                            break;


                        case 'w':

                            control_2_1(r1, r2, ref array, x, y);

                            if (x != 0)
                                x--;
                            we = 0;


                            control_2_2(ref r1, ref r2, ref array, x, y);

                            break;

                        case ' ':

                            if (((x == 0 && y == 0) && (array[x + 1, y] != 1) && (array[x + 1, y + 1] != 1) && (array[x, y + 2] != 1) && (array[x + 1, y + 2] != 1 && r1 != true && r2 != true)) ||
                                ((x == 0 && y == 8) && (array[x + 1, y] != 1) && (array[x + 1, y + 1] != 1) && (array[x, y - 1] != 1) && (array[x + 1, y - 1] != 1 && r1 != true && r2 != true)) ||
                                ((x == 9 && y == 0) && (array[x - 1, y] != 1) && (array[x - 1, y + 1] != 1) && (array[x, y + 2] != 1) && (array[x - 1, y + 2] != 1 && r1 != true && r2 != true)) ||
                                ((x == 9 && y == 8) && (array[x, y - 1] != 1) && (array[x - 1, y - 1] != 1) && (array[x, y - 1] != 1)))

                                r = false;

                            else if (((x == 0 && y > 0 && y < 8) && (array[x, y - 1] != 1) && (array[x + 1, y - 1] != 1) && (array[x + 1, y] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y + 2] != 1) && (array[x, y + 2] != 1) && (r1 != true && r2 != true)) ||
                                       ((x == 9 && y > 0 && y < 8) && (array[x, y - 1] != 1) && (array[x - 1, y - 1] != 1) && (array[x - 1, y] != 1) && (array[x - 1, y + 1] != 1) && (array[x - 1, y + 2] != 1) && (array[x, y + 2] != 1) && (r1 != true && r2 != true)) ||
                                       ((y == 0 && x > 0 && x < 9) && (array[x - 1, y] != 1) && (array[x - 1, y + 1] != 1) && (array[x - 1, y + 2] != 1) && (array[x, y + 2] != 1) && (array[x + 1, y + 2] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y] != 1) && (r1 != true && r2 != true)) ||
                                       ((y == 8 && x > 0 && x < 9) && (array[x, y - 1] != 1) && (array[x - 1, y - 1] != 1) && (array[x - 1, y] != 1) && (array[x - 1, y + 1] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y] != 1) && (array[x + 1, y - 1] != 1) && (r1 != true && r2 != true)))
                                r = false;

                            //слева                 
                            else if (((x > 0 && y > 0) && (x < 9 && y < 8)) && (array[x, y - 1] != 1 && array[x - 1, y - 1] != 1 && array[x - 1, y] != 1 && array[x - 1, y + 1] != 1 && array[x - 1, y + 2] != 1 && array[x, y + 2] != 1 && array[x + 1, y + 2] != 1 && array[x + 1, y + 1] != 1 && array[x + 1, y] != 1 && array[x + 1, y - 1] != 1 && array[x - 1, y] != 1 && r1 != true && r2 != true))
                                r = false;
                            else
                                we = 1;

                            break;

                    }


                    a(ref array, we);


                }

            }

            //размещение 2 трехпалубных кораблей
            for (int i = 0; i < 2; i++)
            {

                x = 0;
                y = 0;


                if (array[0, 0] == 1)
                    r1 = true;

                if (array[0, 1] == 1)
                    r2 = true;

                if (array[0, 2] == 1)
                    r3 = true;

                r = true;

                while (r)
                {

                    array[x, y] = 1;
                    array[x, y + 1] = 1;
                    array[x, y + 2] = 1;

                    a(ref array, we);
                    var b = Console.ReadKey();

                    switch (b.KeyChar)
                    {
                        case 's':

                            contror_3_1(r1, r2, r3, ref array, x, y);

                            if (x < 9)
                                x++;

                            we = 0;

                            control_3_2(ref r1, ref r2, ref r3, ref array, x, y);

                            break;

                        case 'd':
                            contror_3_1(r1, r2, r3, ref array, x, y);

                            if (y < 7)
                                y++;
                            we = 0;

                            control_3_2(ref r1, ref r2, ref r3, ref array, x, y);

                            break;

                        case 'a':
                            contror_3_1(r1, r2, r3, ref array, x, y);
                            if (y != 0)
                                y--;
                            we = 0;

                            control_3_2(ref r1, ref r2, ref r3, ref array, x, y);

                            break;

                        case 'w':
                            contror_3_1(r1, r2, r3, ref array, x, y);
                             if (x != 0)
                                x--;
                            we = 0;
                            control_3_2(ref r1, ref r2, ref r3, ref array, x, y);

                            break;

                        case ' ':

                            if (((x == 0 && y == 0) && (array[x + 1, y] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y + 2] != 1) && (array[x + 1, y + 3] != 1 && (array[x, y + 4] != 1 && r1 != true && r2 != true && r3 != true)) ||
                                 ((x == 0 && y == 7) && (array[x + 1, y] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y + 2] != 1) && (array[x + 1, y - 1] != 1) && (array[x, y - 1] != 1) && r1 != true && r2 != true && r3 != true)) ||
                               ((x == 9 && y == 0) && (array[x - 1, y] != 1) && (array[x - 1, y + 1] != 1) && (array[x - 1, y + 2] != 1) && (array[x - 1, y + 3] != 1) && (array[x, y + 3] != 1) && (r1 != true && r2 != true && r3 != true)) ||
                                 ((x == 9 && y == 7) && (array[x, y - 1] != 1) && (array[x - 1, y - 1] != 1) && (array[x, y - 1] != 1) && (array[x, y - 2] != 1) && (array[x, y - 3] != 1) && r1 != true && r2 != true && r3 != true))

                                r = false;

                            else if (((x == 0 && y > 0 && y < 7) && (array[x, y - 1] != 1) && (array[x + 1, y - 1] != 1) && (array[x + 1, y] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y + 2] != 1) && (array[x + 1, y + 3] != 1) && (array[x, y + 3] != 1) && (r1 != true && r2 != true && r3 != true)) ||
                                       ((x == 9 && y > 0 && y < 7) && (array[x, y - 1] != 1) && (array[x - 1, y - 1] != 1) && (array[x - 1, y] != 1) && (array[x - 1, y - 1] != 1) && (array[x - 1, y - 2] != 1) && (array[x - 1, y - 3] != 1) && (array[x, y - 3] != 1) && (r1 != true && r2 != true && r3 != true)) ||
                                       ((y == 0 && x > 0 && x < 9) && (array[x - 1, y] != 1) && (array[x - 1, y + 1] != 1) && (array[x - 1, y + 2] != 1) && (array[x - 1, y + 3] != 1) && (array[x, y + 3] != 1) && (array[x + 1, y + 3] != 1) && (array[x + 1, y + 2] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y] != 1) && (r1 != true && r2 != true && r3 != true)) ||
                                       ((y == 7 && x > 0 && x < 9) && (array[x, y - 1] != 1) && (array[x - 1, y - 1] != 1) && (array[x - 1, y] != 1) && (array[x - 1, y + 1] != 1) && (array[x - 1, y + 2] != 1) && (array[x + 1, y - 1] != 1) && (array[x + 1, y] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y + 2] != 1) && (r1 != true && r2 != true && r3 != true)))
                                r = false;

                            //слева                 
                            else if (((x > 0 && y > 0) && (x < 9 && y < 7)) && (array[x, y - 1] != 1 && array[x - 1, y - 1] != 1 && array[x - 1, y] != 1 && array[x - 1, y + 1] != 1 && array[x - 1, y + 2] != 1 && array[x - 1, y + 3] != 1 && array[x, y + 3] != 1 && array[x + 1, y + 3] != 1 && array[x + 1, y + 2] != 1 && array[x + 1, y + 1] != 1 && array[x + 1, y] != 1 && array[x + 1, y - 1] != 1 && r1 != true && r2 != true && r3 != true))
                                r = false;
                            else
                                we = 1;

                            break;

                    }


                    a(ref array, we);


                }

            }

           //размещение 1 четырехпалубного корабля
                x = 0;
                y = 0;

            if (array[0, 0] == 1)
                r1 = true;
            if (array[0, 1] == 1)
                r2 = true;
            if (array[0, 2] == 1)
                r3 = true;
            if (array[0, 3] == 1)
                r4 = true;

            r = true;



                while (r)
                {


                array[x, y] = 1;
                array[x, y + 1] = 1;
                array[x, y + 2] = 1;
                array[x, y + 3] = 1;
                a(ref array, we);
                    var b = Console.ReadKey();


                    switch (b.KeyChar)
                    {
                        case 's':

                        control_4_1(r1, r2, r3, r4, ref array, x, y);

                        if (x < 9)
                                x++;
                            we = 0;
                        control_4_2(ref r1, ref r2, ref r3, ref r4, ref array, x, y);
                                            
                            break;

                        case 'd':
                        control_4_1(r1, r2, r3, r4, ref array, x, y);
                        if (y < 6)
                                y++;

                            we = 0;
                        control_4_2(ref r1, ref r2, ref r3, ref r4, ref array, x, y);
                        break;

                        case 'a':

                        control_4_1(r1, r2, r3, r4, ref array, x, y);
                        if (y != 0)
                                y--;

                            we = 0;
                        control_4_2(ref r1, ref r2, ref r3, ref r4, ref array, x, y);
                        break;

                        case 'w':

                        control_4_1(r1, r2, r3, r4, ref array, x, y);
                        if (x != 0)
                                x--;
                            we = 0;
                        control_4_2(ref r1, ref r2, ref r3, ref r4, ref array, x, y);
                        break;


                        case ' ':

                        
                        if (((x == 0 && y == 0) && (array[x + 1, y] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y + 2] != 1) && (array[x + 1, y + 3] != 1) && (array[x+1, y + 4] != 1) && (array[x , y + 4] != 1 ) && (r1 != true && r2 != true && r3 != true && r4!=true)) ||
                            ((x == 0 && y == 6) && (array[x, y-1] != 1) && (array[x + 1, y - 1] != 1) && (array[x + 1, y ] != 1) && (array[x + 1, y + 1] != 1) && (array[x+1, y + 2] != 1) && (array[x + 1, y + 3] != 1) && (r1 != true && r2 != true && r3 != true && r4 != true)) ||
                              ((x == 9 && y == 0) && (array[x - 1, y] != 1) && (array[x - 1, y ] != 1) && (array[x - 1, y + 1] != 1) && (array[x - 1, y + 2] != 1) && (array[x-1, y + 4] != 1) && (array[x , y + 4] != 1) && (r1 != true && r2 != true && r3 != true && r4 != true)) ||
                              ((x == 9 && y == 6) && (array[x, y - 1] != 1) && (array[x - 1, y - 1] != 1) && (array[x-1, y ] != 1) && (array[x-1, y +1] != 1) && (array[x-1, y + 2] != 1) && (array[x - 1, y + 3] != 1) && (r1 != true && r2 != true && r3 != true && r4 != true)))

                            r = false;

                        else if (((x == 0 && y > 0 && y < 6) && (array[x, y - 1] != 1) && (array[x + 1, y - 1] != 1) && (array[x + 1, y] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y + 2] != 1) && (array[x + 1, y + 3] != 1) && (array[x+1, y + 4] != 1) && (array[x, y + 4] != 1) && (r1 != true && r2 != true && r3 != true && r4 != true)) ||
                                   ((x == 9 && y > 0 && y < 6) && (array[x, y - 1] != 1) && (array[x - 1, y - 1] != 1) && (array[x - 1, y] != 1) && (array[x - 1, y - 1] != 1) && (array[x - 1, y - 2] != 1) && (array[x - 1, y - 3] != 1) && (array[x-1, y +4 ] != 1) && (array[x , y + 4] != 1) && (r1 != true && r2 != true && r3 != true && r4 != true)) ||
                                   ((y == 0 && x > 0 && x < 9) && (array[x - 1, y] != 1) && (array[x - 1, y + 1] != 1) && (array[x - 1, y + 2] != 1) && (array[x - 1, y + 3] != 1) && (array[x-1, y + 4] != 1) && (array[x , y + 4] != 1) && (array[x + 1, y + 4] != 1) && (array[x + 1, y + 3] != 1) && (array[x + 1, y + 2] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y] != 1) && (r1 != true && r2 != true && r3 != true && r4 != true)) ||
                                   ((y == 6 && x > 0 && x < 9) && (array[x, y - 1] != 1) && (array[x - 1, y - 1] != 1) && (array[x - 1, y] != 1) && (array[x - 1, y + 1] != 1) && (array[x - 1, y + 2] != 1) && (array[x - 1, y +3] != 1) && (array[x + 1, y-1] != 1) && (array[x + 1, y ] != 1) && (array[x + 1, y + 1] != 1) && (array[x + 1, y + 2] != 1) && (array[x + 1, y + 3] != 1) && (r1 != true && r2 != true && r3 != true&& r4 != true)))
                            r = false;

                        //слева                 
                        else if (((x > 0 && y > 0) && (x < 9 && y < 6)) && (array[x, y - 1] != 1) && (array[x - 1, y - 1] != 1) &&( array[x - 1, y] != 1) && (array[x - 1, y + 1] != 1) && (array[x - 1, y + 2] != 1) && (array[x - 1, y + 3] != 1) && (array[x-1, y + 4] != 1) && (array[x, y + 4] != 1) && (array[x + 1, y + 4] != 1) && (array[x + 1, y + 3] != 1) && (array[x + 1, y + 2] != 1) && (array[x + 1, y+1] != 1) && (array[x +1, y ] != 1) && (array[x-1, y + 1] != 1) && (r1 != true && r2 != true && r3 != true && r4 != true))
                            r = false;
                        else
                            we = 1;
                 
                        
                     break;
                }




                    a(ref array, we);

                }

            a(ref array, we);
            Console.ReadLine();

        }
    }
}
