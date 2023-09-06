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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            kisiService = new KisiService();
            adresService= new AdresService();
        }
        KisiService kisiService;
        AdresService adresService;
        Kisi kisi;
        List<Adres> adresler;

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Kisi> kisis = kisiService.GetAllActivesAndModifields();
            foreach(Kisi kisi in kisis)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = kisi.Ad + " " + kisi.Soyad;
                lvi.Tag = kisi;
                lvKisiler.Items.Add(lvi);
            }

        }

        private void lvKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvKisiler.SelectedItems.Count> 0)
            {
              kisi = (Kisi)lvKisiler.FocusedItem.Tag;
                adresler = kisi.Adresler.ToList();
               FillListView(adresler);    
            }
        }
        private void FillListView(List<Adres> adresler)
        {
            lvAdresler.Items.Clear();
            foreach (Adres adres in adresler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = adres.Sehir;
                lvi.SubItems.Add(adres.Ilce);
                lvi.SubItems.Add(adres.AdresDetay);
                lvAdresler.Items.Add(lvi);
  
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var ara = txtAra.Text.Trim();
            List<Adres> adresler = adresService.GetAllActivesAndModifieldsKisiId(kisi.Id);
            List<Adres> fielterList = adresler.Where(x => x.Sehir.Contains(ara) || x.Ilce.Contains(ara)||x.AdresDetay.Contains(ara)).ToList();
            FillListView(fielterList);
        }
    }
}
