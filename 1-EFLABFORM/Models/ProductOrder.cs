using System;
using System.Collections.Generic;

namespace _1_EFLABFORM.Models
{
    public partial class ProductOrder
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public short? UnitsInStock { get; set; }
        public int? Toplam { get; set; }
    }
}
