using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndıvidualCustomer individualCustomer1 = new IndıvidualCustomer();
            individualCustomer1.Name = "Ramazan";
            individualCustomer1.Surname = "Şahin";
            individualCustomer1.Id = 1;
            individualCustomer1.CustomerNo = 345;
            individualCustomer1.TcNo = "121212121212";



            //Corporate Customer

            CorporateCustomer corporateCustomer1 = new CorporateCustomer
            {
                Id = 3,
                VergiNo = "124234234",
                CompanyName = "Kodlama.io",
                CustomerNo = 456
            };




            Customer musteri3 = new IndıvidualCustomer()
            {
                Id = 3,
                CustomerNo = 21212,
                Name = "Ramazan",
                Surname = "Şahin",
                TcNo = "1232142354"
            };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri3);

            Customer musteri4 = new CorporateCustomer();







        }
    }
}
