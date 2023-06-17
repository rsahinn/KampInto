using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class dortislem
    {
        public int sayi { get; set; }

        
        public void Topla(int sayi1, int sayi2)
        {
            int sonuc=sayi1+ sayi2; 
            Console.WriteLine(sonuc);
        }
    }
}
