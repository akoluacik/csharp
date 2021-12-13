using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface IBeings // for both robots and human beings
    {
        
        string Department { get; set; }

        void Info();
    }
}