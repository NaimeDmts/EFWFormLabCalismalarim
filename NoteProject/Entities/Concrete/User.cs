using NoteProject.Entities.Abstractions;
using NoteProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteProject.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public bool IsActive { get; set; }
        public UseType userType { get; set; }
        public virtual IList<Not> Nots { get; set; }
    }
}
