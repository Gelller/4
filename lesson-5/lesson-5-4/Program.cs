using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь");
            string way = Console.ReadLine();        
            string filename = "wayText.txt";
            File.WriteAllText(filename, "Древо подкаталогов");
            File.AppendAllText(filename, Environment.NewLine);
           
                
                 if (Directory.Exists(way))
                 {
                        string[] directories = Directory.GetDirectories(way);
                        string[] files = Directory.GetFiles(way);
                                                
                        File.AppendAllText(filename, "Подкаталоги ");
                        File.AppendAllText(filename, Environment.NewLine);
                        File.AppendAllLines(filename, directories);
                                            
                        File.AppendAllText(filename, "Файлы ");
                        File.AppendAllText(filename, Environment.NewLine);
                        File.AppendAllLines(filename, files);
                    
                 }
            
            Console.WriteLine(File.ReadAllText(filename));
            Console.ReadLine();

        }
        
    }
}


