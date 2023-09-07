using KisiNot.BLL.Concrete;
using KisiNot.DATA.Abstractions;
using KisiNot.DATA.Entities;
using KisiNot.Repository.Concrete;
using KisiNot.Repository.Contexts;
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
    public partial class Form5 : Form
    {
        public Form5(Kullanici kullanici)
        {
            InitializeComponent();
            context = new AppDbContext();
            kullaniciRepo = new KullaniciRepo(context);
            kullaniciService = new KullaniciService(kullaniciRepo);
            this.kullanici = kullanici;
            notRepo =new NotRepo(context);
            notService =new NotService(notRepo);
        }
        AppDbContext context;
        KullaniciRepo kullaniciRepo;
        KullaniciService kullaniciService;
        Kullanici kullanici;
        NotRepo notRepo;
        NotService notService;
        Not not;

        private void Form5_Load(object sender, EventArgs e)
        {
            NotListele(notService.GetAllDefaults(kullanici.Id));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            notService.Create(new Not
            {
                Baslik = txtBaslik.Text,
                NotIcerigi = txtIcerik.Text,
                KullaniciId =kullanici.Id
            });
            NotListele(notService.GetAllDefaults(kullanici.Id));
        }
        private void NotListele(IList<Not> nots)
        {
            lvNotlar.Items.Clear();
            foreach (var n in nots)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = n.Baslik;
                lvi.SubItems.Add(n.NotIcerigi);
                lvi.Tag = n;
                lvNotlar.Items.Add(lvi);
            }

        }

        private void lvNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvNotlar.SelectedItems.Count > 0)
            {
               not= (Not)lvNotlar.SelectedItems[0].Tag;
                txtBaslik.Text = not.Baslik;
                txtIcerik.Text = not.NotIcerigi;

            }
            else
            {
                not = null;
            }
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            if (lvNotlar.SelectedItems.Count > 0)
            {

            }
        }
    }
}
