using KisiNot.DATA.Entities;
using KisiNot.DATA.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.BLL.Abstractions
{
    public interface INotService
    {
        public void Create(Not not);
        public void Update(Not not);
        public void Delete(Not not);
        public bool Any(Expression<Func<Not, bool>> expression);
        public Not GetDefault(Expression<Func<Not, bool>> expression);
        public Not GetDefaultById(int notId);
        public IList<Not> GetDefaults(Expression<Func<Not, bool>> expression);
        public IList<Not> GetAll();
        public IList<Not> GetAllDefaults(int id);
    }
}
