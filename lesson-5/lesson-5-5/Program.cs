using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace lesson_5_5
{
    class Program
    {
        static void ConsoleClear()
        {
            Console.Clear();
            Console.WriteLine("Управление q-вывести список, w-добавить задачу,e-изменить статус задачи, z-выход");
        }

        static void Main(string[] args)
        {
            List<ToDo> stds = new List<ToDo>();
            string jsonIn = "";

            stds.Clear();
            bool work = true;

            Console.WriteLine("Управление q-вывести список, w-добавить задачу,e-изменить статус задачи, z-выход");

            while (work)

            {

                var str = Console.ReadKey();
                Console.Clear();



                switch (str.KeyChar)
                {

                    case 'w':
                        ConsoleClear();
                        
                        var json = JsonSerializer.Deserialize<List<ToDo>>(File.ReadAllText("tasks.json"));

                      // string k= JsonSerializer.Deserialize<List<ToDo>>("eee");
                        //  JsonSerializer.Deserialize
                        string num = "";

                        bool NormNum = true;

                        //проверка для ввода номера задачи
                        while (NormNum)
                        {

                            bool s = false;//уникальное число найдено

                            Console.WriteLine("Номер задачи");
                            num = Console.ReadLine();

                            bool isNumTrue = int.TryParse(num, out int m);


                            foreach (var jsonOut in json)
                            {
                                if (isNumTrue)
                                {
                                    s = true;
                                    if (jsonOut.Num == Convert.ToInt32(num))
                                    {
                                        Console.WriteLine("Номер уже существует");
                                        s = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Не число");
                                    break;
                                }
                            }
                            if (s)
                                NormNum = false;

                        }



                        Console.WriteLine("Введите задачу");
                        string problem = Console.ReadLine();

                        Console.WriteLine("Выполнено");
                        string doing = Console.ReadLine();

                        stds.Clear();//очистка списка

                        foreach (var jsonOut in json)//повторное заполение списка старыми значениями
                            stds.Add(new ToDo() { Num = jsonOut.Num, Title = jsonOut.Title, IsDone = jsonOut.IsDone });

                        //добавления нового значения
                        stds.Add(new ToDo() { Num = Convert.ToInt32(num), Title = problem, IsDone = doing });

                        jsonIn = JsonSerializer.Serialize(stds);
                        File.WriteAllText("tasks.json", jsonIn);


                        break;




                    case 'q':
                        ConsoleClear();

                        json = JsonSerializer.Deserialize<List<ToDo>>(File.ReadAllText("tasks.json"));

                        foreach (var jsonOut in json)
                            Console.WriteLine($"№ {jsonOut.Num} Задача {jsonOut.Title} Выполнена {jsonOut.IsDone}");

                        break;


                    case 'e':
                        ConsoleClear();
                      

                        json = JsonSerializer.Deserialize<List<ToDo>>(File.ReadAllText("tasks.json"));


                        foreach (var jsonOut in json)
                            Console.WriteLine($"№ {jsonOut.Num} Задача {jsonOut.Title} Выполнена {jsonOut.IsDone}");


                        Console.WriteLine("Введите номер задачи");
                        string number = Console.ReadLine();


                        bool isNum = int.TryParse(number, out int n);
                        stds.Clear();
                        foreach (var jsonOut in json)
                        {
                            if (isNum)
                            {
                                if (jsonOut.Num == Convert.ToInt32(number))
                                {
                                    Console.WriteLine($"№ {jsonOut.Num} Задача {jsonOut.Title} Выполнена {jsonOut.IsDone}");
                                    Console.WriteLine("Изменить статус");
                                    string status = Console.ReadLine();

                                    stds.Add(new ToDo() { Num = jsonOut.Num, Title = jsonOut.Title, IsDone = status });
                                    jsonIn = JsonSerializer.Serialize(stds);

                                }
                                else
                                    stds.Add(new ToDo() { Num = jsonOut.Num, Title = jsonOut.Title, IsDone = jsonOut.IsDone });

                                jsonIn = JsonSerializer.Serialize(stds);
                                File.WriteAllText("tasks.json", jsonIn);
                                Console.WriteLine("Выполнено");
                                // break;
                            }
                            else
                            {
                                Console.WriteLine("Не выполнено");
                                break;

                            }


                        }

                        break;

                    case 'z':
                        work = false;
                        break;


                }


            }
        }
    }
}
