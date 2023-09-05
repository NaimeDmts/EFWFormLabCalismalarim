using System;
using System.Collections.Generic;

namespace _1_EF_LAB.Models
{
    public partial class CustomerOrderSummary
    {
        public string CompanyName { get; set; } = null!;
        public string? ContactName { get; set; }
        public int? Coun { get; set; }
    }
}
