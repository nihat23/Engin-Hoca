using Entities.Concrete;//Eklendi (1)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface IProductDal
    {
        //interface ıcındekı default publıctir.. kendısı deıl..

        List<Product> GetAll();//(1)

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);

    }
}
