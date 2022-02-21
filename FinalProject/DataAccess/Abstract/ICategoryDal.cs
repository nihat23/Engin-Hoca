using Entities.Concrete;//(1)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        /*
        List<Category> GetAll();//(1)

        void Add(Category  category);

        void Update(Category category);

        void Delete(Category category);

        List<Product> GetAllByCategory(int categoryId);
        */

    }
}
