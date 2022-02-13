using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engin_Hoca
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.yol
            Urun urun1 = new Urun
            {
                Adi = "Karpuz",
                Aciklama = "Diyarbakır Karpuzu",
                Fiyat = 15,
                StokAdet = 8
            };

            //2.Yol
            Urun urun2 = new Urun();
            urun2.Adi = "Elma";
            urun2.Aciklama = "Yeşil Elma";
            urun2.Fiyat = 11;
            urun2.StokAdet = 9;

            Urun[] uruns = new Urun[] { urun1, urun2 };


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2); 

            Console.ReadKey();
        }
    }
}
