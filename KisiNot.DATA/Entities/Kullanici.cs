using KisiNot.DATA.Abstractions;
using KisiNot.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.DATA.Entities
{
    public class Kullanici : BaseClass, IKullanici
    {
        public Kullanici()
        {
            base.Statu = Statu.Pasive;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public IList<Not> Nots { get; set; }
        public Tip Tip { get; set; } = Tip.kullanici;
    }
}
