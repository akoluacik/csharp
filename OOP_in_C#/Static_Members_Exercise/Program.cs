using System;

namespace Static_Members_Exercise
{
    class Product
    {
        public int ProductID {get; set;}
        public string productName { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
    }

    static class ProductManager
    {
        static Product[] Products;
        static ProductManager()
        {
            Products = new Product[5];
            Products[0] = new Product {ProductID = 1, productName = "Iphone 5", Price = 2000, IsApproved = false};
            Products[1] = new Product {ProductID = 2, productName = "Iphone 6", Price = 3000, IsApproved = false};
            Products[2] = new Product {ProductID = 3, productName = "Iphone 7", Price = 4000, IsApproved = true};
            Products[3] = new Product {ProductID = 4, productName = "Iphone 8", Price = 5000, IsApproved = true};
            Products[4] = new Product {ProductID = 5, productName = "Iphone X", Price = 6000, IsApproved = true};
        }

        public static Product[] GetProducts()
        {
            return Products;
        }
        public static Product GetProductByID(int id)
        {
            Product product = null;
            foreach (var p in Products)
            {
                if(p.ProductID == id)
                    product = p;
            }
            return product;
        }

        public static Product GetProductByName(string name)
        {
            Product product = null;
            foreach (var p in Products)
            {
                if(p.productName.Contains(name.ToLower()))
                {
                    product = p;
                    break;
                }
            }
            return product;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var products = ProductManager.GetProducts();
            foreach (var p in products)
            {
                Console.WriteLine($"name: {p.productName} price : {p.Price} ");
            }
            Console.WriteLine();
            var product = ProductManager.GetProductByID(2);
            Console.WriteLine($"name: {product.productName} price : {product.Price} ");

            product = ProductManager.GetProductByName("phone");
            Console.WriteLine();
            Console.WriteLine($"name: {product.productName} price : {product.Price} ");

        }
    }
}
