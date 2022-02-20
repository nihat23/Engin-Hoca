using Entities.Abstract;//Abstrack//IEntity 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity// public  "diyer classlardan erişim saglayacak"  default erişim belirliyeci internaldır.. 
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
