using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //inheritance
    class GercekMusteri: Musteri//gercek musteri bir musterıdır.. (musteri ozelıklerı gercektete tuzeldede wardır ortak kullanır)
    {      
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; } 
    }
}
