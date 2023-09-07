using KisiNot.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.Repository.Abstractions
{
    public interface INotRepo :IBaseReo<Not>
    {
        public IList<Not> GetAll();
        public IList<Not> GetAllDefaults(int id);
    }
}
