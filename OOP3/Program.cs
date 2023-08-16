using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerCredit = new ConsumerCredit();
            ICreditManager individualCredit = new IndividualCredit();
            ILoggerService DatabaseLoggerService = new DatabaseLoggerService();
            ILoggerService FileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(consumerCredit, 
                new List<ILoggerService> {DatabaseLoggerService,FileLoggerService});

            List<ICreditManager> krediler = new List<ICreditManager>() { consumerCredit, individualCredit };

            //basvuruManager.KrediOnBilgilendirmeYap(krediler);




            Console.Read();
        }
    }
}
/*
      Operasyonel işlemlerde class kulanmak yerine interface kullanabiliriz. Ancak interface
      içerdiği metodların diğer classlar içerisinde mutlaka kullanılması gerekir. 

      Yine classlarda olduğu gibi Interface ler diğer classların referansını alabilir. 

      Örneğin bir banka otomasyonumuzun olduğunu düşünelim. Bizim vereceğimiz kredi ile ilgili
      bir interface miz olsun. Bu interface in içinde hesapla adında bir metod bulunsun veya
      birden fazla metod bulunsun. Eğer classlara interface i implemente ediyorsak o metodların
      hepsinin o classlar içinde olması gerekir. 

      Örneğimizi biraz daha geliştirelim ve bir başvuru yapalım. Yapacağımız başvurunun hangi
      türde olduğunu belirtmek için başta oluşturduğumuz interface i kullanabiliriz. Çünkü o   
      interface bizim classlarımızın miras aldığı kişidir. Böylece if yazıp tek tek hangi 
      kredi olduğunu öğrenmek yerine direkt BaşvuruYap classını çağırıp o classın içine istediğimiz
      kredi türünü yazarız ve o kredi türü içindeki işlemler gerçekleşmiş olur. 





 */
