using System;
using System.Collections.Generic;
using System.Data.Entity;//(1)
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //db tabloları ıle proje tabloları ılıslendırme
    public class Context : DbContext//(1)
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
    }
}
