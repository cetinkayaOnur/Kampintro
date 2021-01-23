using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuru bilgilerini degerlendirme
            //
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }
        public void KrediOnBilgilenirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
