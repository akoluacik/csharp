using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ORM_Entity_Framework
{
    public class MySqlProductDal
    {
        /*private MySqlConnection GetMySqlConnection()
        {
            string connectionString = @"server=localhost;port=3306;database=northwind;user=root;password=admin"; // mysql
            return new MySqlConnection(connectionString);
        }*/
        
        public void Add(List<Product> products)
        {
            using(var db = new ShopContext())
            {
                db.Products.AddRange(products);
                db.SaveChanges();
            }
        }

        

        public void GetAllProducts()
        {
            using (var db = new ShopContext())
            {
            
                
                /* All Columns */
                /*var products = db.Product.ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"id:{product.ProductId}, Name:{product.Name}, price: {product.Price}");
                }*/
                
                /* selecting specified columns */
                var products = db
                .Products
                .Select(p =>
                    new 
                    {
                        p.Name,
                        p.Price
                    })
                .ToList();

                foreach (var product in products)
                {
                    Console.WriteLine($"Name:{product.Name}, price: {product.Price}");
                }
            }
        }
        public void getProductById(int id)
        {
            using (var db = new ShopContext())
            {
                var product = db
                            .Products
                            .Where(p => p.ProductId == id)
                            .Select(p => 
                            new 
                            {
                                p.Name,
                                p.Price
                            })
                            .FirstOrDefault();
                Console.WriteLine($"Name:{product.Name}, Price:{product.Price}");
            }
        }

        public void UpdateProduct(int id)
        {
            using (var db = new ShopContext())
            {
                var product = db.Products.Where(p => p.ProductId == id).FirstOrDefault();
                /* If product exists in the db */
                if(product != null)
                {
                    product.Price *= 1.2m; // increase the price by 20%
                    db.SaveChanges();
                }
            }
        }
    }
}