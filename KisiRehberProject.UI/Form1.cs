using KisiRehberProject.BLL.Services;
using KisiRehberProject.DATA.Entities;
using KisiRehberProject.UI.Utilities;
using System.Windows.Forms.Design;

namespace KisiRehberProject.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kisiService = new KisiService();
        }
        Kisi kisi;
      
        KisiService kisiService;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Kisi> kisis = kisiService.GetAllActivesAndModifields();
            FillListView(kisis);
            ButtonSet(true);
        }
        private void FillListView(List<Kisi> kisis)
        {
            lvKisiler.Items.Clear();
            foreach(Kisi kisi in kisis)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = kisi.Id.ToString();
                lvi.SubItems.Add(kisi.Ad);
                lvi.SubItems.Add(kisi.Soyad);
                lvi.SubItems.Add(kisi.Telefon);

                lvKisiler.Items.Add(lvi);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kisi = new Kisi();
            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.Telefon = mtxtTelefon.Text;
            kisiService.Add(kisi);
            FillListView(kisiService.GetAllActivesAndModifields());
            Helper.ClearControls(this.Controls);
        }

        private void lvKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvKisiler.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32( lvKisiler.SelectedItems[0].SubItems[0].Text);
                kisi = kisiService.Get(id);

                txtAd.Text = kisi.Ad;
                txtSoyad.Text = kisi.Soyad;
                mtxtTelefon.Text = kisi.Telefon;
                ButtonSet(false);
            }
            else
            {
                ButtonSet(true);
                Helper.ClearControls(this.Controls);
                kisi = null;
                  
            }
        }
       
        void ButtonSet(bool set)
        {
            btnKaydet.Enabled = set;
            btnGuncelle.Enabled = !set;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(kisi!=null)
            {
                kisi.Ad = txtAd.Text;
                kisi.Soyad = txtSoyad.Text;
                kisi.Telefon = mtxtTelefon.Text;
                kisiService.Update(kisi);
                FillListView(kisiService.GetAllActivesAndModifields());
                Helper.ClearControls(this.Controls);
                kisi = null;

            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvKisiler.SelectedItems.Count>0)
            {
               
                kisiService.Delete(kisi);
                FillListView(kisiService.GetAllActivesAndModifields());
                ButtonSet(true);
                Helper.ClearControls(this.Controls);

            }
        
        }

        private void adresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvKisiler.SelectedItems.Count > 0)
            {
                this.Hide();
                Form2 form2 = new Form2(kisi.Id);
                form2.ShowDialog();
                this.Show();

            }
        }

        private void linkYoneticiEkrani_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Show();

        }

        private void txtKisiAra_TextChanged(object sender, EventArgs e)
        {
            var kisiara = txtKisiAra.Text.Trim();
            List<Kisi> kisis = kisiService.GetAllActivesAndModifields();
           List<Kisi> fielterList = kisis.Where(x=>x.Ad.Contains(kisiara)||x.Soyad.Contains(kisiara)).ToList();
            FillListView(fielterList);
        }
    }
}