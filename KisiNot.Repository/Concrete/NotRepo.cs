using KisiNot.DATA.Abstractions;
using KisiNot.DATA.Entities;
using KisiNot.DATA.Enums;
using KisiNot.Repository.Abstractions;
using KisiNot.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.Repository.Concrete
{
    public class NotRepo : BaseRepo<Not>, INotRepo
    {
        private readonly AppDbContext _context;
        public NotRepo(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }

        public IList<Not> GetAll()
        {
            return _context.Nots.Where(x => x.Statu != Statu.Deleted).ToList();
        }

        public IList<Not> GetAllDefaults(int id)
        {
           return _context.Nots.Where(x => x.Statu != Statu.Deleted&& x.KullaniciId == id).ToList();
        }
    }
}
