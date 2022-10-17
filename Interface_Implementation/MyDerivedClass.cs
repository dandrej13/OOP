using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Implementation
{
    internal class MyDerivedClass : MyBaseClass, IMyInterface

    {
        public int MyProperty { get; set; }

        //doSomething() is already inherited frin MyBaseClass,
        //hence no need of implementation from IMyIntefrace
        public void DoSomethingElse()
        {
            throw new NotImplementedException();
        }
    }
}
