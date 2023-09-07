using KisiNot.BLL.Abstractions;
using KisiNot.DATA.Abstractions;
using KisiNot.DATA.Entities;
using KisiNot.DATA.Enums;
using KisiNot.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.BLL.Concrete
{
    public class NotService : INotService
    {
        private readonly INotRepo _repo;

        public NotService(INotRepo notRepo)
        {
            _repo = notRepo;
                
        }
        public bool Any(Expression<Func<Not, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Not not)
        {
            _repo.Create(not); 
        }

        public void Delete(Not not)
        {
            if (Any(x => x.Id == not.Id))
            {
                not.DeleteDate = DateTime.Now;
                not.Statu = Statu.Deleted;
                _repo.Delete(not);
            }
            else
            {
                throw new Exception("Bu Id ye ait not Yok");
            }
        }

        public IList<Not> GetAll()
        {
            return _repo.GetAll();
        }

        public Not GetDefault(Expression<Func<Not, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Not GetDefaultById(int notId)
        {
            return _repo.GetDefaultById(notId);
        }

        public IList<Not> GetDefaults(Expression<Func<Not, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public void Update(Not not)
        {
            not.UpdateDate = DateTime.Now;
            not.Statu = Statu.Modifield;
            _repo.Update(not);
        }
        public IList<Not> GetAllDefaults(int id)
        {
            return _repo.GetAllDefaults(id);
        }
    }
}
