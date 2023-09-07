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
    public partial class Form4 : Form
    {
        public Form4(Kullanici kullanici)
        {
            InitializeComponent();
            context = new AppDbContext();
            kullaniciRepo = new KullaniciRepo(context);
            kullaniciService = new KullaniciService(kullaniciRepo);
            this.admin = kullanici;
        }
        AppDbContext context;
        KullaniciRepo kullaniciRepo;
        KullaniciService kullaniciService;
        Kullanici admin;
        Kullanici kullanici;

        private void Form4_Load(object sender, EventArgs e)
        {
           NotListele( kullaniciService.SonOnNotGetir(admin));
            KisiListele(kullaniciService.GetAll(admin));
            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(lvKisiler.SelectedItems.Count > 0)
            {
               lblDurum.Text= Helper.KullaniciStatu(kullanici);
                kullaniciService.StatuUpdate(kullanici);
                KisiListele(kullaniciService.GetAll(admin));
            }
            else
            {
                kullanici = null;
            }

        }
        public void KisiListele(IList<Kullanici> kullanicis)
        {
            lvKisiler.Items.Clear();
            foreach(var k in kullanicis)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = k.kullaniciAdi;
                lvi.SubItems.Add(k.Statu.ToString());
                lvi.Tag= k;
                lvKisiler.Items.Add(lvi);
            }
        }
        public void NotListele(IList<Not> nots)
        {
     
            lvNotlar.Items.Clear();
            foreach (var n in nots)
            {
             
                ListViewItem lvi = new ListViewItem();
                lvi.Text = n.Baslik;
                lvi.SubItems.Add(n.NotIcerigi);
                lvi.SubItems.Add(n.Kullanici.kullaniciAdi);
                lvi.Tag = n;
                lvNotlar.Items.Add(lvi);
            }
        }

        private void lvKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvKisiler.SelectedItems.Count > 0)
            {
               kullanici =(Kullanici)lvKisiler.SelectedItems[0].Tag;
                lblDurum.Text = kullanici.Statu.ToString();
             

            }
            else
            {
                kullanici = null;
            }
        }

     
    }
}
