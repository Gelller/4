using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace lesson_6
{
    class Program
    {


        static void KillProc(string name, ref Process [] procList )
            {
              string answer="Не выполнено";

              for(int i=0;procList.Length>i;i++)
              {
                    if(name==procList[i].ProcessName)
                    {
                           procList[i].Kill();
                           answer="Выполнено";
                           break;
                    }                              
                  
              }    
              Console.WriteLine(answer);  
        }

       
        static void KillProc(int id, ref Process [] procList )
            {
              string answer="Не выполнено";

              for(int i=0;procList.Length>i;i++)
              {
                    if(id==procList[i].Id)
                    {
                           procList[i].Kill();
                           answer="Выполнено";
                           break;
                    }
                
                   
              }              
                 Console.WriteLine(answer);            
        }

        static void Main(string[] args)
        {
                      
            Process[] procList = Process.GetProcesses();
                   
            for(int i=0;procList.Length>i;i++)
                   Console.WriteLine($"Имя процесса {procList[i].ProcessName} ID {procList[i].Id}");
            


            Console.WriteLine($"Для завершения процесса введите имя или ID ");         
            string std= Console.ReadLine();
            bool isNum = int.TryParse(std, out int n);

            if(!isNum)                  
                 KillProc(std, ref procList);
            else  
            {
                 int id =int.Parse(std);
                 KillProc(id, ref procList);
            }


             Console.ReadLine();
       
        }

       

    }
}
