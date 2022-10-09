using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShape
{
    public class Shape : Location

    {
        protected Location c;

        public override string ToString()
        {
            return string.Empty;
        }

        public double Area()
        {
            return 1.1;
        }

        public double Perimeter()
        {
            return 2.2;
        }
    }
}
