using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteProject.Utilities
{
    public class PasswordController
    {
        public static bool Check(string password)
        {
            if(password.Length<6) 
            {
                throw new Exception("Şifre 6 karakterden az olamaz");
            }

            return true;

        }
    }
}
