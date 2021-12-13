using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Pattern_1.Entity
{
    // drives database actions for Product.
    public class Product : IEntity
    {
        public string Name { get; set; } // Name of the product
        public double Price { get; set; }
        public int ID { get; set; }
    }
}