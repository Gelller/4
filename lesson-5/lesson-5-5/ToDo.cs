using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5_5
{
    class ToDo
    {
        public int Num { get; set; }
        public string Title { get; set; }

        public string IsDone { get; set; }


        public ToDo()
        {
            Num = 1;
            Title = "title";
            IsDone = "isdones";
        }

        public ToDo(int nom, string title, string isdones)
        {
            Num = nom;
            Title = title;
            IsDone = isdones;
        }
    }
}
