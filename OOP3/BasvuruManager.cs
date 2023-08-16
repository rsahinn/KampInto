using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmeYap(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler) 
            {
                kredi.Hesapla();
            }
        }
    }
}
