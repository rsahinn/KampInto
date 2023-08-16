using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Ramazan", "Metin", "Yusuf", "Mami" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            Console.WriteLine("----------------------------");


            //Bir diziye sonradan eleman ekleme işlemini yapmak yerine List oluşturup
            //list içine Add metodu ile eleman ekleyebiliriz.

            List<string> isimler2 = new List<string>() { "Mustafa", "Ahmet", "Hasan" };
            isimler2.Add("Mehmet");
            foreach (string isim in isimler2)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("--------------------------");


            //Önceden oluşturduğumuz bir diziyi daha sonra list e verebiliriz.
            //Bu işlemi yapabilmek için AddRange metodunu kullanırız. 
            string[] sehirler = new string[] { "İstanbul", "Ankara", "İzmir" };

            var bigCities = new List<string>();

            bigCities.AddRange(sehirler);

            bigCities.Add("Adıyaman");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < bigCities.Count; i++)
            {
                Console.WriteLine(bigCities[i]);
            }

            //List içerisindeki bir değerin var olup olmadığını kontrol etmek için Contains metodu
            //kullanılır. 

            Console.WriteLine(bigCities.Contains("ADıyaman"));
            


            Console.ReadKey();




        }
    }
}
