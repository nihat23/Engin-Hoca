using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)//parametreye interface yazdık 
        {
            krediManager.Hesapla();
            loggerService.Log();

            /*
              musterı bılgıler alınır..
            KontKrediManager kontKrediManager = new KontKrediManager();
            kontKrediManager.Hesapla();  basvuru sadece tek bunun ıcın gecerlı olacaktır.:D
            */

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> Krediler)
        {
            foreach (var kredi in Krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
