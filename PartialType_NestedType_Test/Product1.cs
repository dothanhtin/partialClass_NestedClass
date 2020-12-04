using System;
using System.Collections.Generic;
using System.Text;

namespace PartialType_NestedType_Test
{
    /// <summary>
    /// Khai báo sử dụng partial
    /// </summary>
    public partial class Product
    {
        public string Name { get; set; }
        public bool Order(int number = 0)
        {
            return true;
        }
    }
}
