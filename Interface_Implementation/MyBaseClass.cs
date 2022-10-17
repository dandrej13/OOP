using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Implementation
{
    internal class MyBaseClass : IMyInterface
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }

        public void DoSomethingElse()
        {
            throw new NotImplementedException();
        }
    }
}