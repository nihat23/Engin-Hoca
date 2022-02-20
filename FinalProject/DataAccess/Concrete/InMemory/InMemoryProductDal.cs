using DataAccess.Abstract;//(1)
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal//(1)
    {
        List<Product> _products;
        public InMemoryProductDal()//Constraktor
        {
            _products = new List<Product>{
            new Product{ ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitStock=5},
            new Product{ ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitStock=6},
            new Product{ ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitStock=5},
            new Product{ ProductId=4,CategoryId=2,ProductName="Mouse",UnitPrice=150,UnitStock=3},
            new Product{ ProductId=5,CategoryId=3,ProductName="Klavye",UnitPrice=85,UnitStock=1},
            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(sil => sil.ProductId == product.ProductId);

            /*
            Product productToDelete = null;

            foreach (var sil in _products)
            {
                if (product.ProductId == sil.ProductId)
                {
                    productToDelete = sil;
                }
            }
            */
            //_products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //gonderdıgım urun ıd sıne sahıp olan lıstedekı urunu bull
            Product productToUpdate = _products.SingleOrDefault(sil => sil.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitStock = product.UnitStock;
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
             return _products.Where(p => p.CategoryId == categoryId).ToList();

        }
    }
}
