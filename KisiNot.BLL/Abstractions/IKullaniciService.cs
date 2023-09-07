using KisiNot.DATA.Entities;
using KisiNot.DATA.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.BLL.Abstractions
{
    public interface IKullaniciService
    {
        public void Create(Kullanici kullanici);
        public void Update(Kullanici kullanici);
        public void Delete(Kullanici kullanici);
        public bool Any(Expression<Func<Kullanici, bool>> expression);
        public Kullanici GetDefault(string kulaniciAd, string sifre);
        public Kullanici GetDefaultById (int kullaniciId);
        public IList<Kullanici> GetDefaults(Expression<Func<Kullanici, bool>> expression);
        public IList<Not> SonOnNotGetir(Kullanici kullanici);
        public IList<Kullanici> GetAll(Kullanici kullanici);

    }
}
