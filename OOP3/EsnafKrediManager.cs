using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKrediManager : IKrediManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esanaf Kredisi Hesaplandı.");
        }
    }
}
