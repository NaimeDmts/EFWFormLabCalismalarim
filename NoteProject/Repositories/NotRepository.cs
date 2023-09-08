using NoteProject.Context;
using NoteProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteProject.Repositories
{
    public class NotRepository
    {
        public NotRepository()
        {
            _context = new AppDbContext();
        }
        AppDbContext _context;

        public bool Add(Not not)
        {
            _context.Nots.Add(not);
            return _context.SaveChanges()>0;
        }
        public bool Update(Not not)
        {
            _context.Nots.Update(not);
            return _context.SaveChanges() > 0;
        }
        public bool Delete(Not not)
        {
            _context.Nots.Remove(not);
            return _context.SaveChanges() > 0;
        }
        public Not GetById(int id)
        {
            return _context.Nots.Find(id);
        }
        public List<Not> GetByUserId(int userId) 
        {
            return _context.Nots.Where(a=>a.UserId == userId).ToList();
        }
        public List<Not> GetLastTenNotes() 
        {
            return _context.Nots.OrderByDescending(a=>a.CreateDate).Take(10).ToList();
        }
    }
}
