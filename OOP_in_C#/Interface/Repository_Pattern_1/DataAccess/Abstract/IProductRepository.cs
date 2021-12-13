using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository_Pattern_1.Entity;

namespace Repository_Pattern_1.DataAccess.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product[] GetProductsByCategory(int id);
        Product[] GetPopularProducts();     
    }
}