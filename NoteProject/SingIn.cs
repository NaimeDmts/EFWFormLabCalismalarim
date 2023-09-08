using NoteProject.Entities.Concrete;
using NoteProject.Entities.Enums;
using NoteProject.Repositories;
using NoteProject.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteProject
{
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }
        UserRepository userRepository;
        private void btnKayit_Click(object sender, EventArgs e)
        {
          bool isUserExist =  userRepository.Any(txtKullaniciAdi.Text.Trim());
            if (isUserExist)
            {
                MessageBox.Show("Böyle bir kullanıcı mevcuttur.");
                return;
            }
            try
            {
                bool isPasswordCheck = PasswordController.Check(txtSifre.Text.Trim());
                if(isPasswordCheck)
                {
                    if (txtSifre.Text.Trim() != txtSifreTekrar.Text.Trim())
                    {
                        MessageBox.Show("Şifreler uyuşmuyor");
                        return;
                    }
                    User user = new User();
                    user.FirstName = txtAd.Text;
                    user.LastName = txtSoyad.Text;
                    user.UserName = txtKullaniciAdi.Text;
                    user.Password = txtSifre.Text;
                    user.Status = Status.Active;

                    
                    //BLL
                    user.IsActive = false;
                    user.userType = UseType.Standart;

                    userRepository.Add(user);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
