using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacher
{
    public class Teacher : Person
    {
        //public string Name { get; set; }
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }

    }
}
