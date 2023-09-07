using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using KisiNot.BLL.Abstractions;
using KisiNot.DATA.Entities;
using KisiNot.DATA.Enums;
using KisiNot.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.BLL.Concrete
{
    public class KullaniciService : IKullaniciService
    {
        private readonly IKullaniciRepo _repo;

        public KullaniciService(IKullaniciRepo repo)
        {
                _repo = repo;
        }

        public bool Any(Expression<Func<Kullanici, bool>> expression)
        {
           return _repo.Any(expression);
        }

        public void Create(Kullanici kullanici)
        {
            if(Any(x=>x.kullaniciAdi!=kullanici.kullaniciAdi)) 
            {
                _repo.Create(kullanici);
            }
            else
            {
                throw new Exception("Kullanıcı Adına sahip biri var");
            }
         
         
        
        }

        public void Delete(Kullanici kullanici)
        {
            if(Any(x=>x.Id == kullanici.Id))
            {
                kullanici.DeleteDate = DateTime.Now;
                kullanici.Statu = Statu.Deleted;
                _repo.Delete(kullanici);
            }
            else
            {
                throw new Exception("Bu Id ye ait kullanıcı Yok");
            }
     
        }

        public IList<Kullanici> GetAll(Kullanici kullanici)
        {
            if(kullanici.Tip == Tip.admin)
            {
                return _repo.GetAll();
            }
            else
            {
                throw new Exception("Sadece Admin tüm kullanıcıyı görebilir.");
            }
        }

        public Kullanici GetDefault(string kullaniciAd, string sifre)
        {
            if(_repo.Any(x=>x.kullaniciAdi.Contains(kullaniciAd.Trim())))
            {
                if(_repo.Any(x => x.Sifre.Contains(sifre.Trim())))
                {
                    Kullanici kullanici= _repo.GetDefault(x => x.kullaniciAdi == kullaniciAd && x.Sifre == sifre);
                    if (kullanici.Statu != Statu.Pasive)
                    {
                        return kullanici;
                    }
                    else
                    {
                        throw new Exception("Pasif kullanıcı bilgileri");
                    }
                }
                else
                {
                    throw new Exception("Sifre Hatalı");
                }

            }
            else
            {
                throw new Exception("Kullanıcı Adı Hatalı");
            }

      
        }

        public Kullanici GetDefaultById(int kullaniciId)
        {
            return _repo.GetDefaultById(kullaniciId);
        }

        public IList<Kullanici> GetDefaults(Expression<Func<Kullanici, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public IList<Not> SonOnNotGetir(Kullanici kullanici)
        {
            if(kullanici.Tip ==Tip.admin)
            {
                return _repo.SonOnNotGetir();
            }
            else
            {
                throw new Exception("Bu işlem admine özeldir.");
            }
        }

        public void Update(Kullanici kullanici)
        {
            kullanici.UpdateDate = DateTime.Now;
            kullanici.Statu = Statu.Modifield;
            _repo.Update(kullanici);
        }
        public void StatuUpdate(Kullanici kullanici)
        {
            _repo.StatuUpdate(kullanici);
        }
    }
}
