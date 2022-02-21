using Bussines.Abstract;//
using DataAccess.Abstract;//
using DataAccess.Concrete.InMemory;//
using Entities.Concrete;//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal iproductDal)
        {
            _productDal = iproductDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
            //iş kodları yazılır 
            
        }
    }
}
