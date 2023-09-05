using KisiRehberProject.DATA.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiRehberProject.DATA.Entities
{
    public class Kisi : BaseClass
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public virtual ICollection<Adres> Adresler { get; set; }
        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
