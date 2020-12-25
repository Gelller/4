using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson_5_4_2
{
    class Program
    {

        public static void wayFile(string way, string filename)
        {
            if (Directory.Exists(way))
            {
                string[] directories = Directory.GetDirectories(way);
                string[] files = Directory.GetFiles(way);
                if (directories.Length != 0)
                {
                    File.AppendAllText(filename, "Подкаталоги ");
                    File.AppendAllText(filename, Environment.NewLine);
                    File.AppendAllLines(filename, directories);
                }
                else
                {
                    File.AppendAllText(filename, "Файлы ");
                    File.AppendAllText(filename, Environment.NewLine);
                    File.AppendAllLines(filename, files);
                }
                if (directories.Length != 0)
                {
                    int index = 0;
                    while (true)
                    {
                        if (index >= directories.Length)
                        {
                            break;
                        }
                        wayFile(directories[index], filename);
                        index++;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            string path = "wayText.txt";
            Console.WriteLine("Введите путь");
            string way = Console.ReadLine();
            File.WriteAllText(path, "Дерево каталогов ");
            File.AppendAllText(path, Environment.NewLine);
            wayFile(way, path);
            Console.WriteLine(File.ReadAllText(path));
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}







