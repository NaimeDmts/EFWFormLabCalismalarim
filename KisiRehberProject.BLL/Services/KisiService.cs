using KisiRehberProject.DAL.Concrete;
using KisiRehberProject.DATA.Entities;
using KisiRehberProject.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiRehberProject.BLL.Services
{
    public class KisiService
    {
        public KisiService()
        {
            kisiDAL = new KisiDAL();
        }
        KisiDAL kisiDAL;

        public void Add(Kisi kisi)
        {
            kisiDAL.Add(kisi);
        }

        public bool Update(Kisi kisi)
        {
            kisi.UpdateDate = DateTime.Now;
            kisi.Status = Status.Modified;
            return kisiDAL.Update(kisi);
        }
        public void Delete(Kisi kisi)
        {
            kisi.Status = Status.Deleted;
            kisi.DeletedDate = DateTime.Now;
            kisiDAL.Update(kisi);

        }
        public Kisi Get(int id)
        {
            return kisiDAL.GetById(id);
        }
        public List<Kisi> GetAll()
        {
           
            return kisiDAL.GetAll().ToList();
        }
        public List<Kisi> GetAllActivesAndModifields()
        {

            return kisiDAL.GetAllActivesAndModifields(x => x.Status != Status.Deleted);
        }

    }
}
