using KisiNot.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.DATA.Abstractions
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
         public DateTime CreateDate { get; set; } =  DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Statu Statu { get; set; } = Statu.Active;

    }
}
