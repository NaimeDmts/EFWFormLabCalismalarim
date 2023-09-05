using _5_KisiAdres.DAL.Contexts;
using _5_KisiAdres.DATA.Concrete;
using _5_KisiAdres.UI.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_KisiAdresForms
{
    public partial class Form2 : Form
    {
        public Form2(Kisi kisi, KisiUI kisiUI)
        {
            InitializeComponent();
            _kisi = kisi;
            context = new AppDbContext();
            adresUI = new AdresUI(context);
            _kisiUI = kisiUI;
        }
        AppDbContext context;
        AdresUI adresUI;
        Kisi _kisi;
        Adres adres;
        KisiUI _kisiUI;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            adres = new Adres();
            adres.Sehir = txtSehir.Text;
            adres.Ilce = txtIlce.Text;
            adres.AdresDetay = txtAdresDetay.Text;
            adres.KisiId = _kisi.Id;
            adresUI.Add(adres);
            Listele();

        }
        private void Listele()
        {
            lvAdresler.Items.Clear();

            // Kişinin adreslerini al
           var adresler = context.Adreses.ToList();// _kisi nesnesi üzerinden kişinin adreslerini alıyoruz
           adresler= adresUI.GetByDefaults(x => x.KisiId == _kisi.Id);
            // Her bir adresi ListView kontrolüne ekleyerek listele
            foreach (var adres in adresler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = adres.Id.ToString();      
                lvi.SubItems.Add(adres.Sehir);         
                lvi.SubItems.Add(adres.Ilce);          
                lvi.SubItems.Add(adres.AdresDetay);    
                lvAdresler.Items.Add(lvi);             
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lvAdresler.SelectedItems.Count > 0)
            {
                string id = lvAdresler.SelectedItems[0].SubItems[0].Text;
                adres = context.Adreses.FirstOrDefault(x => x.Id == Convert.ToInt32(id));
                adres.Sehir = txtSehir.Text;
                adres.Ilce = txtIlce.Text;
                adres.AdresDetay = txtAdresDetay.Text;
                adresUI.Update(adres);
            }
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string id = lvAdresler.SelectedItems[0].SubItems[0].Text;
            adres = context.Adreses.FirstOrDefault(x => x.Id == Convert.ToInt32(id));
            adresUI.Delete(adres);
            Listele();

        }

        private void lvAdresler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAdresler.SelectedItems.Count > 0)
            {




            }
        }
    }
}

