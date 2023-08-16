using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class PersonManager
    {
       public void Add(ICustomerDal customelDal)
        {
            customelDal.Add();
            Console.Read();
        }
        public void Updated(ICustomerDal custome)
        {
            custome.Update();
            Console.Read();
        }

    }
}
