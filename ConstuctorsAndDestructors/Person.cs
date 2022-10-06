using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassAndMethodToString
{
    internal class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        private string Name;
        public override string ToString()
        {
            return Name;
        }
        ~Person()
        {
            Name = string.Empty;
        }
    }
}
