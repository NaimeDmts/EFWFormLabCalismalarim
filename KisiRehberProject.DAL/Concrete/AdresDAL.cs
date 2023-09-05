using KisiRehberProject.DAL.Contexts;
using KisiRehberProject.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdresRehberProject.DAL.Concrete
{
    public class AdresDAL
    {
        public AdresDAL()
        {

            dbContext = new AppDbContext();
        }
        AppDbContext dbContext;
        public void Add(Adres Adres)
        {
            dbContext.Add(Adres);
            dbContext.SaveChanges();
        }
        public bool Update(Adres Adres)
        {
            dbContext.Update(Adres);
            return dbContext.SaveChanges() > 0;
        }
        public void Delete(Adres Adres)
        {
            dbContext.Remove(Adres);
            dbContext.SaveChanges();
        }
        public Adres GetById(int id)
        {
            return dbContext.Adreses.Find(id);
        }
        public List<Adres> GetAll()
        {
            return dbContext.Adreses.ToList();
        }
        public List<Adres> GetAllActivesAndModifieldsKisiId(Expression<Func<Adres, bool>> expression)
        {

            return dbContext.Adreses.Where(expression).ToList();
        }
    }
}
