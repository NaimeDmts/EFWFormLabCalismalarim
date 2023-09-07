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
            
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public virtual IList<Not> Nots { get; set; }
        public Tip Tip { get; set; } = Tip.kullanici;
        public override Statu Statu { get; set; } = Statu.Pasive;
    }
}
