using BulkyWeb.Models;   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD7501Bulky.Models;
namespace SD7501Bulky.DataAccess.Repository.IRepository
{
   public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
        void Save();

    }
}
