using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacher
{
    public class Person
    {

       internal int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hello everybody");

        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
