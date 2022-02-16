using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); olabilir 
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();//interfacelerde imlement eden classın referansı
                                                                          //tutabılır yanı yazılabilir..


            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager kontKrediManager = new KontKrediManager();

            ILoggerService databaseloggerservice = new DataBaseLogggerService();
            FileLogggerService fileLogggerService = new FileLogggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseloggerservice);//fileLogggerService yazılabılır..Krediler yazılır..

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, kontKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadKey();

        }
    }
}
