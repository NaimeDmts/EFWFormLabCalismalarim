using KisiNot.DATA.Entities;
using KisiNot.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.UI.Utilities
{
    public static class Helper
    {
        public static bool SifreKontrol(string sifre)
        {
            string specialCharacters = "!@#$%^&*()_+-=[]{}|;':\",./<>?";
            bool sifreozelKarakter = false;
            bool sifreOKarakteryok = false;
            bool sifreNumber = false;
            bool sifreNKarakteryok = false;
            foreach (var s in sifre)
            {
                
                if (char.IsDigit(s))
                {
                    sifreNumber = true;
                }
                else
                {
                    sifreNKarakteryok=true;
                }

            }
            foreach (var s in sifre)
            {
                if (specialCharacters.Contains(s))
                {
                    sifreozelKarakter = true;
                }
                else
                {
                    sifreOKarakteryok = true;
                }
              

            }
            if (sifre.Length >= 6)
            {
                if (sifreozelKarakter)
                {
                    if (sifreNumber)
                    {
                         return true;
                    }
                    else
                    {
                        throw new Exception("Şifrede En az 1 sayıolmak zorunda");
                    }
                }
                else
                {
                    throw new Exception("Şifrede en az bir özel karakter ");
                }
            }
            else
            {
                throw new Exception("Şifre en az 6 karakterli olmak zorunda");
            }
        }

        public static bool AdminKullaniciGirisKontrol(Kullanici kullanici)
        {
            if (kullanici.Tip == Tip.admin)
            {
             
                return true;
            }
            else
            {
                
                return false;
            }
        }

        public static string KullaniciStatu(Kullanici kullanici)
        {
            if(kullanici.Statu == Statu.Active || kullanici.Statu ==Statu.Modifield)
            {
                kullanici.Statu = Statu.Pasive;
                return "Pasive";
            }
            else
            {
                kullanici.Statu = Statu.Active;
                return "Active";
            }
        }
    }
}
