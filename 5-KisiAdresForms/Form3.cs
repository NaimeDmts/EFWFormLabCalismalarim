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
    public partial class Form3 : Form
    {
        public Form3(Kisi kisi, KisiUI kisiUI)
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

        private void Form3_Load(object sender, EventArgs e)
        {
            lboxKisiler.DataSource = context.Kisis.ToList();

        }

        private void lboxKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvAdresler.Items.Clear();

            _kisi = (Kisi)lboxKisiler.SelectedItem;
            var adresler = adresUI.GetByDefaults(x => x.KisiId == _kisi.Id);
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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lvAdresler.Items.Clear();



            var ara = txtAra.Text.Trim();
            var arananadres = context.Adreses.Where(x => x.Sehir.Contains(ara) || x.Ilce.Contains(ara)||x.AdresDetay.Contains(ara));


            foreach (var k in arananadres)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = k.Id.ToString();
                lvi.SubItems.Add(k.Sehir);
                lvi.SubItems.Add(k.Ilce);
                lvi.SubItems.Add(k.AdresDetay);
                lvAdresler.Items.Add(lvi);
            }
        }

        private void lboxKisiler_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
