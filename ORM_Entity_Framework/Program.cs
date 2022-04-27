using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ORM_Entity_Framework.Data.EfCore;

namespace ORM_Entity_Framework
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // MySqlProductDal mysql = new MySqlProductDal();

            /* Add Products */
             /*productDal.Count(new List<Product>{ new Product{Name="Samsung Galaxy S5", Price = 5000}});
            productDal.Count(new List<Product>{ new Product{Name="Samsung Galaxy S6", Price = 6000}});
            productDal.Count(new List<Product>{ new Product{Name="Samsung Galaxy S7", Price = 7000}});
            productDal.Count(new List<Product>{ new Product{Name="Samsung Galaxy S8", Price = 8000}});
            productDal.Count(new List<Product>{ new Product{Name="Samsung Galaxy S9", Price = 9000}});*/
            
            /* Retrieve Products */
            /*mysql.GetAllProducts();
            mysql.getProductById(3);*/

            /* Linq Query Exercises */
            LinqQueries lq = new LinqQueries();
            using (var db = new NorthwindContext())
            {
                // 1. Retrieve all customers
                // lq.Question1(db);

                // 2. Full names of customers who are living in New York. 
                // lq.Question2(db);

                // 3. Retrieve the name of products whose category is Beverage
                // lq.Quesiton3(db);

                // 4. Get the 5 most recently added products
                // lq.Question4(db);

                // 5. Retrieve the products whose price is between 10 and 30.
                // lq.Question5(db);

                // 6. Find mean value of the products whose category is Beverages.
                // lq.Question6(db);

                LinqQueriesWithMultipleTables lqm = new LinqQueriesWithMultipleTables();
                lqm.test();
            }

        }
    }
}
