using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Entity_Framework
{
    public class Product
    {
        public int ProductId { get; set; }

        [MaxLength(100)]
        [Required] // default value of strings is null, we therefore ensure name to have a value
        public string Name { get; set; }

        public decimal Price { get; set; } // decimal? means can be nullable, decimal values have default value as null.
        
    }
}