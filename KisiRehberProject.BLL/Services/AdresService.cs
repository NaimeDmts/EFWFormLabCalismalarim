using AdresRehberProject.DAL.Concrete;
using KisiRehberProject.DAL.Concrete;
using KisiRehberProject.DATA.Entities;
using KisiRehberProject.DATA.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KisiRehberProject.BLL.Services
{
    public class AdresService
    {
        public AdresService()
        {
            adresDAL = new AdresDAL();
        }
        AdresDAL adresDAL;

        public void Add(Adres adres)
        {
            adresDAL.Add(adres);
        }
        public void Delete(Adres adres) 
        { 
            adres.DeletedDate = DateTime.Now;
            adres.Status = Status.Deleted;
            adresDAL.Update(adres);
        }
        public void Update(Adres adres)
        {
            adres.UpdateDate = DateTime.Now;
            adres.Status = Status.Modified;
            adresDAL.Update(adres);
        }
        public Adres Get(int id)
        {
            return adresDAL.GetById(id);
        }
        public List<Adres> GetAll()
        {
            return adresDAL.GetAll().ToList();
        }
        public List<Adres> GetAllActivesAndModifieldsKisiId(int id)
        {

            return adresDAL.GetAllActivesAndModifieldsKisiId(x=>x.KisiId == id && x.Status!=Status.Deleted);
        }
    }
}
