using System;
using System.Collections.Generic;

namespace _3_EFLABMusteriListeleEkleSil.Models
{
    public partial class CalisanBilgileri
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? HireDate { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
