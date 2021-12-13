using System;
using Repository_Pattern_1.DataAccess.Abstract;
using Repository_Pattern_1.DataAccess.Concrete;
using Repository_Pattern_1.Entity;
namespace Repository_Pattern_1
{
    class ProductManager : IProductRepository // This class reduces the resistance of our program to change.
        {
            IProductRepository _repository;
            public ProductManager(IProductRepository repository)
            {
                _repository = repository;
            }
            public void Create(Product entity)
            {
                _repository.Create(entity);
            }
            public void Delete(int id)
            {
                throw new System.NotImplementedException();
            }
            public Product GetById(int id)
            {
                return new Product(); // whatever it returns is not important for now
            }
            public Product[] GetPopularProducts()
            {
                throw new NotImplementedException();
            }

            public Product[] GetProductsByCategory(int id)
            {
                throw new NotImplementedException();
            }
            
            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
            
        }
    class Program
    {
        static void Main(string[] args)
        {
            // var productDal = new EfProductDal();
            // var productDal = new MySQLProductDal();
            // productDal.Create(new Product());
        
            var productDal = new ProductManager(new EfProductDal());
            productDal.Create(new Product());

        }
    }
}
