using System;
using System.Collections.Generic;
namespace _2.Generic_Lists
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            Numbers.Add(10);
            Numbers.Add(11);
            Numbers.Add(20);

            List<string> Names = new List<string>();
            Names.Add("John");
            Names.Add("Nicolo");
            Names.Add("Wendel");
            Names.Add(null);

            List<Product> products = new List<Product>()
            {
                new Product(){Name = "Samsung S6"},
                new Product(){Name = "Samsung S7"},
                new Product(){Name = "Samsung S8"},
                new Product(){Name = "Samsung S9"}
            };
            // If it were IList<Product> products2 = new List<Product>(), it is still true,
            // and we can use it as an argument for AddRange, because of Interface.
            List<Product> products2 = new List<Product>() 
            {
                new Product(){Name = "IPhone 6"},
                new Product(){Name = "IPhone 7"},
                new Product(){Name = "IPhone 8"},
                new Product(){Name = "IPhone 10"}
            };
            products.AddRange(products2);

            /*products.ForEach(p=>Console.WriteLine(p.Name)); // usual foreach can be used.
            // products.ForEach(p=>{Console.WriteLine(p.Name);}); // if our code took more than one line, we need to use {}
            Console.WriteLine(products2.Count);
            Console.WriteLine("\nINSERT");
            Numbers.Insert(1, 100);
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }*/
            products.InsertRange(1,products2); // adds products2 to products starting from index 1.
            // for (int i = 0; i < products.Count; i++)
            // {
            //     Console.WriteLine(products[i].Name);
            // }
            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\nREMOVE");
            Numbers.Remove(10);
            Numbers.RemoveAt(0);
            
        }
    }
}
