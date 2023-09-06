using KisiRehberProject.DAL.Contexts;
using KisiRehberProject.DATA.Entities;
using KisiRehberProject.DATA.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KisiRehberProject.DAL.Concrete
{
    public class KisiDAL
    {
        public KisiDAL()
        {
           dbContext =new AppDbContext();
        }
        AppDbContext dbContext;

        public void Add (Kisi kisi)
        {
            dbContext.Add(kisi);
            dbContext.SaveChanges();
        }
        public bool Update(Kisi kisi)
        {
            dbContext.Update(kisi);
            return dbContext.SaveChanges() > 0;
        }
        public void Delete (Kisi kisi)
        {
            dbContext.Remove(kisi);
            dbContext.SaveChanges();
        }
        public Kisi GetById(int id)
        {
            return dbContext.Kisis.Find(id);
        }
        public List<Kisi> GetAll()
        {
            return dbContext.Kisis.ToList();
        }
        public List<Kisi> GetAllActivesAndModifields(Expression<Func<Kisi,bool>>expression)
        {
            //dbContext.Kisis.Include(x=>x.Adresler).Where(expression).ToList();
            //dbContext.Kisis.Include(x=>x.Adresler).ThenInclude(x=>x.AdresDetay içerisinden bir tabloya ulaşmak için).Where(expression).ToList();
            return dbContext.Kisis.Where(expression).ToList();

        }
    }
}
