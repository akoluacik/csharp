﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ORM_Entity_Framework.Data.EfCore
{
    public partial class InventoryTransactionType
    {
        public InventoryTransactionType()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
        }

        public byte Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    }
}
