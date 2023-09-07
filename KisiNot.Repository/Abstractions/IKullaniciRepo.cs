using KisiNot.DATA.Entities;
using KisiNot.DATA.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.Repository.Abstractions
{
    public interface IKullaniciRepo :IBaseReo<Kullanici>
    {
        public IList<Not> SonOnNotGetir();
        public IList<Kullanici> GetAll();
        public void StatuUpdate(Kullanici kullanici);
    }
}
