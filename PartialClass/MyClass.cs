using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class MyClass
    {
        #region Fields
        private int myInt;
        #endregion
        #region Constructor
        public MyClass() {  myInt = 99; }
        #endregion
        #region Properties
        public int MyInt
        {
            get { return myInt; }
            set { myInt = value; }
        }
        #endregion
        #region Methods
        public void DoSomemthing() {
            Console.WriteLine("Doing smthing");
                }
        #endregion
    }

    public partial class MyClass
    {
        public int myInt2;
    }
}
