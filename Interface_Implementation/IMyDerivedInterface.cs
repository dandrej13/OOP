using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Implementation
{
    internal interface IMyDerivedInterface : IMyBaseInterface
    {
        new void DoSomething();
    }
}
