using KisiRehberProject.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiRehberProject.DATA.Abstractions
{
 
        public class BaseClass
        {
            public int Id { get; set; }
            public DateTime CreateDate { get; set; } = DateTime.Now;
            public DateTime? UpdateDate { get; set; }
            public DateTime? DeletedDate { get; set; }
            public Status Status { get; set; } = Status.Added;
        }
    
}
