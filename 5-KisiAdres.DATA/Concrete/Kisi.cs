using _5_KisiAdres.DATA.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_KisiAdres.DATA.Concrete
{
    public class Kisi :BaseClass
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public virtual ICollection<Adres> Adresler { get; set; }
        public override string ToString()
        {
            return Ad+" "+Soyad;
        }
    }
}
