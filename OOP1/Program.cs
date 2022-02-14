using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";//txt.text
            product1.UnitPrice = 500;
            product1.UnitInStok = 3;


            Product Product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitInStok = 5,
                ProductName = "Kalem",//txt.text
                UnitPrice = 35
            };

            //PascalCase   camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); 



            Console.ReadKey();
        }

    }
}
