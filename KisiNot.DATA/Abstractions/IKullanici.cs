using KisiNot.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.DATA.Abstractions
{
    public interface IKullanici
    {
    
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public IList<Not> Nots { get; set; }

    }
}
