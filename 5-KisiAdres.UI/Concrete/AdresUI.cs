using _5_KisiAdres.DAL.Concrete;
using _5_KisiAdres.DAL.Contexts;
using _5_KisiAdres.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _5_KisiAdres.UI.Concrete
{
    public class AdresUI
    {
        private readonly BaseDal<Adres> _baseDal;
        private readonly AppDbContext appDbContext;
        public AdresUI(AppDbContext appDbContext)
        {
            appDbContext = appDbContext;
            _baseDal = new BaseDal<Adres>(appDbContext);
        }
        public void Add(Adres entity)
        {
            if (entity is not null)
            {
                _baseDal.Create(entity);
            }
            else
            {
                throw new Exception("Kisi ekleme işleminde hata oldu.");
            }
        }

        public void Delete(Adres entity)
        {
            if (entity is not null)
            {
                entity.DeletedDate = DateTime.Now;
                entity.Status = DATA.Enums.Status.Deleted;
                _baseDal.Delete(entity);
            }
            else
            {
                throw new Exception("Kisi silme işleminde hata oldu.");
            }
        }

        public List<Adres> GetByDefaults(Expression<Func<Adres, bool>> expression)
        {

            return _baseDal.GetDefaults(expression).ToList();
        }

        public List<Adres> GetByDefaultsOrdered(Expression<Func<Adres, bool>> expression)
        {
            return _baseDal.GetDefaults(expression).OrderBy(f => f.Id).ToList();
        }

        public void Update(Adres entity)
        {
            if (entity is not null)
            {
                entity.UpdateDate = DateTime.Now;
                entity.Status = DATA.Enums.Status.Modified;
                _baseDal.Update(entity);
            }
            else
            {
                throw new Exception("Kisi silme işleminde hata oldu.");
            }
        }
    }
}
