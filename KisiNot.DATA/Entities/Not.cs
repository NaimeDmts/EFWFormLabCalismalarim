using KisiNot.DATA.Abstractions;
using KisiNot.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.DATA.Entities
{
    public class Not : BaseClass, INot
    {
        public string Baslik { get; set; }
        public string NotIcerigi { get; set; }
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public override Statu Statu { get; set; } = Statu.Active;
    }
}
