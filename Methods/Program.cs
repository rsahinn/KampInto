using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1=new Urun();
            urun1.UrunAdi = "Elma";
            urun1.UrunFiyati = 20;
            urun1.UrunAciklamasi = "Amasya Elması";
            urun1.StokAdedi = 1000;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.UrunFiyati = 60;
            urun2.UrunAciklamasi = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 23;

            Urun[] urunler = new Urun[] { urun1,urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün adı: " + urun.UrunAdi);
                Console.WriteLine("Ürün Fiyatı: " + urun.UrunFiyati);
                Console.WriteLine("Ürün Stok Adedi: " + urun.StokAdedi);
            }




            SeperManager sepeteEkle=new SeperManager();
            sepeteEkle.Ekle(urun1);
            sepeteEkle.Ekle(urun2);
            



            Console.ReadKey();
        }
    }
}
