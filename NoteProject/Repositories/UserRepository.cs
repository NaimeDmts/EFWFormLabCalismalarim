using NoteProject.Context;
using NoteProject.Entities.Concrete;
using NoteProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteProject.Repositories
{
    public class UserRepository
    {
        public UserRepository()
        {
            _context = new AppDbContext();
        }
        AppDbContext _context;

        public bool Add(User user)
        {
            _context.users.Add(user);
            return _context.SaveChanges() > 0;

        }
        public bool Update(User user)
        {
            _context.users.Update(user);
            return _context.SaveChanges() > 0;

        }
        public User GetById(int id)
        {
            return _context.users.Find(id);
        }
        public List<User> GetAll()
        {
            return _context.users.ToList();
        }
        public bool Any( string userName)
        {
            return _context.users.Any(x=>x.UserName == userName);
        }
        public User  GetByUserName(string userName)
        {
            return _context.users.FirstOrDefault(x => x.UserName == userName);
        }
        public List<User> GetAllStandartUser()
        {
            return _context.users.Where(x=>x.userType == UseType.Standart).ToList();    
        }
    }
}
