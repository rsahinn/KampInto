﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ConsumerCredit : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi ödeme planı gerçekleşti");
        }
    }
}
