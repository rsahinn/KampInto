using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {


        
            
            
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Ramazan Şahin";
            kurs1.IzlenmeOrani = 89;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JS";
            kurs2.KursEgitmeni = "Metin Şahin";
            kurs2.IzlenmeOrani = 82;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursEgitmeni + " " + kurs.IzlenmeOrani);
            }
            Console.ReadKey();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
