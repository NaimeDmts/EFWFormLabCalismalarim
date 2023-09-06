using KisiNot.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.DATA.Abstractions
{
    public interface INot
    {
        public string Baslik { get; set; }
        public string NotIcerigi { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; } 
    }
}
