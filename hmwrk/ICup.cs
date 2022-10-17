using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmwrk
{
    internal interface ICup
    {
        public void Refill()
        {

        }
        public bool Wash() 
        {
            return true;
        }
    }
}
