using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Implementation
{
    internal class LastClass : MyDerivedClass, IMyInterface
    {
        // no need of implementation of IMyIntercface becuase
        //this LastClass inherites 2 methods from MyDerivedClass
        //and MyDerivedClass inherites 1 method from MyBaseClass
        //meaning all methods from IMyInterface are implemented in LastClass.
    }
}
