using System;
using System.Collections.Generic;

namespace _3_EFLABMusteriListeleEkleSil.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
