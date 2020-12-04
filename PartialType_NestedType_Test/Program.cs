using System;

namespace PartialType_NestedType_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hehe test with funny partial class and method");
            //test class
            Product product = new Product
            {
                Name = "Partial product"
            };
            product.Order(1);
            product.numberBrought();
            //Test method
            PartialMethod partialMethod = new PartialMethod();
            //Print Excute :))) in console
            Console.ReadKey();
        }
    }
}
