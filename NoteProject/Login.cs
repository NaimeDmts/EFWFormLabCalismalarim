using NoteProject.Entities.Concrete;
using NoteProject.Entities.Enums;
using NoteProject.Repositories;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        UserRepository userRepository;

        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           SingIn singIn = new SingIn();
            singIn.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            userRepository = new UserRepository();
            User user = userRepository.GetByUserName(txtKullaniciAdi.Text.Trim());
            if(user == null)
            {
                MessageBox.Show("Bu isimde bir kullanıcı yok");
                return;
            }
            if (!user.IsActive)
            {
                MessageBox.Show("Admin henüz kaydınızı onaylamamıştır");
                return;
            }
            if(user.Status == Status.Pasive)
            {
                MessageBox.Show("Hesabınız askıya alınmıştır");
                return;
            }
            if(user.Password!=txtSifre.Text.Trim())
            {
                MessageBox.Show("Şifreniz hatalı");
                return;
            }
            if(user.userType ==UseType.Admin)
            {
                AdminScreen adminScreen = new AdminScreen();
                adminScreen.ShowDialog();
                
            }
            else
            {
                UserScreen userScreen = new UserScreen();
                userScreen.ShowDialog();
            }
            
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
