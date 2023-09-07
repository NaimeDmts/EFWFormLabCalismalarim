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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            context = new AppDbContext();
            kullaniciRepo = new KullaniciRepo(context);
            kullaniciService = new KullaniciService(kullaniciRepo);
        }
        AppDbContext context;
        KullaniciRepo kullaniciRepo;
        KullaniciService kullaniciService;
        Kullanici kullanici;
        private void btnGiris_Click(object sender, EventArgs e)
        {
          kullanici =  kullaniciService.GetDefault(txtKad.Text, txtSifre.Text);

            if (Helper.AdminKullaniciGirisKontrol(kullanici))
            {
                this.Hide();
                Form4 form4 = new Form4(kullanici);
                form4.ShowDialog();
                this.Show();

            }
            else
            {

                this.Hide();
                Form5 form5 = new Form5(kullanici);
                form5.ShowDialog();
                this.Show();
            }

        }
    }
}
