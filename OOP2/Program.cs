using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "1111111";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "2222";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "222222";

            //Musteri musteri5 = new Musteri(); Kendınısı newlıyor
            Musteri musteri3 = new GercekMusteri();//inheritance olanlarıda newlenebılır
            Musteri musteri4 = new TuzelMusteri();//inheritance olanlarıda newlenebılır

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);




        }
        
    }
}
