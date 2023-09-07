using KisiNot.BLL.Concrete;
using KisiNot.DATA.Entities;
using KisiNot.Repository.Concrete;
using KisiNot.Repository.Contexts;
using KisiNot.UI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiNot.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            context = new AppDbContext();
            kullaniciRepo = new KullaniciRepo(context);
            kullaniciService = new KullaniciService(kullaniciRepo);
        }
        AppDbContext context;
        KullaniciRepo kullaniciRepo;
        KullaniciService kullaniciService;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(Helper.SifreKontrol(txtSifre.Text))
            {
                kullaniciService.Create(new Kullanici
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    kullaniciAdi = txtKad.Text,
                    Sifre = txtSifre.Text,

                });
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifrede en az bir özel karakter ve 1 Rakam olmak zorunda");
            }
        }
    }
}
