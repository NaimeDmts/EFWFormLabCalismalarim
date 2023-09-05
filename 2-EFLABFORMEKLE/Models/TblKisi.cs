using System;
using System.Collections.Generic;

namespace _2_EFLABFORMEKLE.Models
{
    public partial class TblKisi
    {
        public int KisiId { get; set; }
        public string? KisiAd { get; set; }
        public string? KisiSoyad { get; set; }
        public DateTime? KisiDogumTarihi { get; set; }
        public string? KisiTelefon { get; set; }
        public string? KisiAdres { get; set; }
        public string? KisiSehir { get; set; }
    }
}
