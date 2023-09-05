using KisiRehberProject.BLL.Services;
using KisiRehberProject.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiRehberProject.UI
{
    public partial class Form2 : Form
    {
        public Form2(int kisiId)
        {
            InitializeComponent();
            this.kisiId = kisiId;
            adresService = new AdresService();
            
        }
        int kisiId;
        AdresService adresService;
        Adres adres;

        private void Form2_Load(object sender, EventArgs e)
        {
            FillListView(adresService.GetAllActivesAndModifieldsKisiId(kisiId));
        }
        void FillListView(List<Adres>adresler)
        {
            lvAdresler.Items.Clear();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            adres = new Adres();
            adres.Sehir = txtSehir.Text;
            adres.Ilce = txtIlce.Text;
            adres.AdresDetay = txtAdresDetay.Text;
            adres.KisiId = kisiId;
            adresService.Add(adres);
            FillListView(adresService.GetAllActivesAndModifieldsKisiId(kisiId));

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void lvAdresler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAdresler.SelectedItems.Count > 0)
            {
                string id = lvAdresler.SelectedItems[0].SubItems[0].Text;
                adres = adresService.Get(Convert.ToInt32(id));
                txtSehir.Text = adres.Sehir;
                txtIlce.Text = adres.Ilce;
                txtAdresDetay.Text = adres.AdresDetay;
            }
        }
    }
}
