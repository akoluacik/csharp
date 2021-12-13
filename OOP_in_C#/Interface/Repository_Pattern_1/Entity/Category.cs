using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Pattern_1.Entity
{
    public class Category : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; } // Name of the Category
    }
}