using System;
using System.Collections.Generic;

namespace _3_EFLABMusteriListeleEkleSil.Models
{
    public partial class CustomerOrderSummary
    {
        public string CompanyName { get; set; } = null!;
        public string? ContactName { get; set; }
        public int? Coun { get; set; }
    }
}
