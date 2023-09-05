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
    public class KisiUI
    {
        private readonly BaseDal<Kisi> _baseDal;
        private readonly AppDbContext _appDbContext;
        public KisiUI(AppDbContext appDbContext)
        {
             _appDbContext = appDbContext;
                _baseDal = new BaseDal<Kisi>(_appDbContext);
        }
        public void Add(Kisi entity)
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

        public void Delete(Kisi entity)
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
        public Kisi GetByDefault(Expression<Func<Kisi, bool>> expression)
        {
       

            return _baseDal.GetDefault(expression);
        }

        public List<Kisi> GetByDefaults(Expression<Func<Kisi, bool>> expression, int _skip, int _take)
        {

            return _baseDal.GetDefaults(expression).Skip(_skip).Take(_take).ToList();
        }

        public List<Kisi> GetByDefaultsOrdered(Expression<Func<Kisi, bool>> expression)
        {
            return _baseDal.GetDefaults(expression).OrderBy(f => f.Id).ToList();
        }

        public void Update(Kisi entity)
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
