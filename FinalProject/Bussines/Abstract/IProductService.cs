using Entities.Concrete;//(1)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
  public  interface IProductService
    {
        List<Product> GetAll();//(1)

    }
}
