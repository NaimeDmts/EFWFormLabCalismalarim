using KisiAdres_Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiAdres_Data.Concrete
{
    public class Kisi :BaseClass
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public virtual ICollection<Adres> Adreses { get; set; }

    }
}
