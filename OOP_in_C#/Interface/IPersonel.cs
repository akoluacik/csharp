using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface IPersonel
    {
        string FullName {get; set;}
        string Address { get; set; }
        public double Wage { get; set; }
    }
}