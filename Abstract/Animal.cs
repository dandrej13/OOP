using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
  public abstract class Animal
    {

        private string _name;

        public bool SetName(string str)
        {
            _name = str;
            return true;
        }

        public string GetName()
        {
            return _name;
        }

        public abstract void Eat();
        
   
    }
}
