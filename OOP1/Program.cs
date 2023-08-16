using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnıtPrice = 500;
            product1.UnıtInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Sandalye",
                UnıtPrice = 300,
                UnıtInStock = 9
            };

            ProductManager productmanager = new ProductManager();
            productmanager.Add(product1);

            //int sonuc = productmanager.Topla(3, 6);
            //Console.WriteLine(sonuc * 4);


            Console.ReadKey();
        }
    }
}
