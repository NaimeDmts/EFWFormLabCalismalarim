using KisiNot.DATA.Abstractions;
using KisiNot.DATA.Entities;
using KisiNot.DATA.Enums;
using KisiNot.Repository.Abstractions;
using KisiNot.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.Repository.Concrete
{
    public class KullaniciRepo : BaseRepo<Kullanici>, IKullaniciRepo
    {
        private readonly AppDbContext _context;
        public KullaniciRepo(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }

        public IList<Not> SonOnNotGetir()
        {
           return _context.Nots.OrderByDescending(x=>x.CreateDate).Take(10).ToList();
        }
        public IList<Kullanici> GetAll()
        {
            return _context.Kullanicis.Where(x => x.Statu != Statu.Deleted && x.Tip!=Tip.admin).ToList();
        }
        public void StatuUpdate(Kullanici kullanici)
        {
            kullanici.UpdateDate= DateTime.Now;
            _context.Update(kullanici);
            _context.SaveChanges();

        }
    }
}
