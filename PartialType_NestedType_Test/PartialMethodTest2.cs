using System;
using System.Collections.Generic;
using System.Text;

namespace PartialType_NestedType_Test
{
    public partial class PartialMethod
    {
        public PartialMethod()
        {
            MyMethod();
        }
        partial void MyMethod()
        {
            //do something
            Console.WriteLine("Excute :))))");
        }
    }
}
