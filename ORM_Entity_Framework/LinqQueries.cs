using System;
using System.Linq;
using ORM_Entity_Framework.Data.EfCore;

namespace ORM_Entity_Framework
{
    public class LinqQueries
    {
        public void Question1(NorthwindContext db)
        {
            Console.WriteLine("Question1: Retrieve all customers from northwind database.");
            // 1. Retrieve all customers

            //var customers = db.Customers.ToList(); // query selects all columns.
            
            var customers = db // query selects only first and last names.
                .Customers
                .Select(c=> new {
                    c.FirstName,
                    c.LastName
                });

            foreach (var c in customers)
            {
                Console.WriteLine($"Name:{c.FirstName + " " + c.LastName}");
            }

        }

        public void Question2(NorthwindContext db)
        {
            
            Console.WriteLine("Quesiton2:Full names of customers who are living in New York, in order.");
            var customers = db
                            .Customers
                            .Select(c=>new {
                                c.FirstName,
                                c.LastName,
                                c.City
                            })
                            .Where(c=>c.City.Equals("New York"))
                            .ToList();
            foreach (var c in customers)
            {
                Console.WriteLine($"Full Name: {c.FirstName + c.LastName}");
            }
        }

        public void Quesiton3(NorthwindContext db)
        {
            Console.WriteLine("Question3:Retrieve the name of products whose category is Beverage");
            var products = db
                        .Products
                        .Select(c=> new {
                            c.ProductName,
                            c.Category
                        })
                        .Where(c=>c.Category.Equals("Beverages"))
                        .ToList();
            foreach (var p in products)
            {
                Console.WriteLine($"Name: {p.ProductName}");
            }
        }

        public void Question4(NorthwindContext db)
        {
            Console.WriteLine("Question4:Get the 5 most recently added products");
            var products = db.Products.Take(5);
            foreach (var p in products)
            {
                Console.WriteLine($"Name: {p.ProductName}");
            }
        }

        public void Question5(NorthwindContext db)
        {
            Console.WriteLine("Question5:Retrieve the products whose price is between 10 and 30.");
            var products = db
                        .Products
                        .Where(p=>p.ListPrice >=10 && p.ListPrice <= 30)
                        .Select(p=>new {p.ProductName, p.ListPrice})
                        .ToList();
            foreach (var p in products)
            {
                Console.WriteLine($"Name: {p.ProductName}, Price: {p.ListPrice}");
            }
        }

        public void Question6(NorthwindContext db)
        {
            Console.WriteLine("Question6:Find average price value of the products whose category is Beverages.");
            var AveragePrice = db
                        .Products
                        .Average(p=>p.ListPrice);
            Console.WriteLine("Average:" + AveragePrice);
        }
    }
}