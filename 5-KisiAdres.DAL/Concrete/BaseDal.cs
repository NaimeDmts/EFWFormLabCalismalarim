using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using _5_KisiAdres.DAL.Contexts;

namespace _5_KisiAdres.DAL.Concrete
{
    public class BaseDal<T> where T : class
    {
        private DbSet<T> _table;
        private readonly AppDbContext _context;
        public BaseDal(AppDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _table.Any(expression);
        }

        public void Create(T Entity)
        {
            _table.Add(Entity);
            _context.SaveChanges();
        }

        public void Delete(T Entity)
        {

            _table.Remove(Entity);
            _context.SaveChanges();
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.FirstOrDefault(expression);
        }

        public List<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

       
        public void Update(T Entity)
        {
            
            _context.Update(Entity);
            _context.SaveChanges();
        }

    }
}
