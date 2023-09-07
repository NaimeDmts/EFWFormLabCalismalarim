using KisiNot.DATA.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.Repository.Abstractions
{
    public interface IBaseReo <T> where T : BaseClass
    {
     
            public void Create(T item);
            public void Update(T item);
            public void Delete(T item);
            bool Any(Expression<Func<T, bool>> expression);
            T GetDefault(Expression<Func<T, bool>> expression);
            T GetDefaultById(int id);
            IList<T> GetDefaults(Expression<Func<T, bool>> expression);


    }
}
