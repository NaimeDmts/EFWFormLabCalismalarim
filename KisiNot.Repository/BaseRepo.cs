using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using KisiNot.DATA.Abstractions;
using KisiNot.DATA.Enums;
using KisiNot.Repository.Abstractions;
using KisiNot.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.Repository
{
    public class BaseRepo<T> : IBaseReo<T> where T : BaseClass
    {
        private readonly AppDbContext _context;
        protected DbSet<T> _table;

        public BaseRepo(AppDbContext appDbContext)
        {
            _context = appDbContext;
            _table = _context.Set<T>();
        }
        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _table.Any(expression);
        }

        public void Create(T item)
        {
            _table.Add(item);
            _context.SaveChanges();
        }

        public void Delete(T item)
        {
            _context.SaveChanges();

        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            
            return _table.Where(x=>x.Statu != Statu.Deleted).FirstOrDefault(expression);
        }

        public T GetDefaultById(int id)
        {
            return _table.Where(x => x.Statu != Statu.Deleted).FirstOrDefault(x=>x.Id==id);
        }

        public IList<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(x => x.Statu != Statu.Deleted).Where(expression).ToList();
        }

        public void Update(T item)
        {
            _table.Update(item);
            _context.SaveChanges();
        }
    }
}
