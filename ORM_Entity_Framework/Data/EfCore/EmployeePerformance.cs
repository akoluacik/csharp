using System;
using System.Collections.Generic;

#nullable disable

namespace ORM_Entity_Framework.Data.EfCore
{
    public partial class EmployeePerformance
    {
        public int EmployeeId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int? SellTransactionCount { get; set; }
    }
}
