using _5_KisiAdres.DATA.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_KisiAdres.DATA.Concrete
{
    public class Adres : BaseClass
    {
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string AdresDetay { get; set; }

        public int KisiId { get; set; }
        public virtual Kisi Kisi { get; set; }

    }
}
