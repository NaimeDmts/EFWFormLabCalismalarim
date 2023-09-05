using _4_EFCORE_REHBEREKLE.Contexts;
using _4_EFCORE_REHBEREKLE.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace _4_EFCORE_REHBEREKLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           using(var context = new AppDbContext())
            {
                Kisi kisi = new Kisi();
                kisi.Ad = txtFirstName.Text;
                kisi.Soyad = txtLastName.Text;
                kisi.Telefon = mtxtPhone.Text;
                context.Kisis.Add(kisi);
                context.SaveChanges();
                KisiListele();

            }
            temizle();
        

        }
        void KisiListele()
        {
            lvPeople.Items.Clear();
            using (var context = new AppDbContext())
            {

                var kisiler = context.Kisis.ToList();
                foreach (var k in kisiler)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = k.KisiId.ToString();
                    lvi.SubItems.Add(k.Ad);
                    lvi.SubItems.Add(k.Soyad);
                    lvi.SubItems.Add(k.Telefon);

                    lvPeople.Items.Add(lvi);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (lvPeople.SelectedItems.Count > 0)
                {
                    string id = lvPeople.SelectedItems[0].SubItems[0].Text;
                    var kisirehber = context.Kisis.FirstOrDefault(x => x.KisiId ==Convert.ToInt32( id));
                    kisirehber.Ad = txtFirstName.Text;
                    kisirehber.Soyad = txtLastName.Text;
                    kisirehber.Telefon =mtxtPhone.Text;
                    context.Update(kisirehber);
                    context.SaveChanges();
                    KisiListele();
                   
                }
              

            }
            temizle();
            btnAdd.Enabled = true;
        }
        

        private void lvPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPeople.SelectedItems.Count > 0)
            {
                using (var context = new AppDbContext())
                {

                    string id = lvPeople.SelectedItems[0].SubItems[0].Text;
                    var kisirehber = context.Kisis.FirstOrDefault(x => x.KisiId == Convert.ToInt32(id));
                    txtFirstName.Text = kisirehber.Ad;
                    txtLastName.Text = kisirehber.Soyad;
                    mtxtPhone.Text = kisirehber.Telefon;

                }
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
            }
            else
            {
                temizle();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisiListele();
            btnDelete.Enabled= false;
            btnUpdate.Enabled= false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {

                string id = lvPeople.SelectedItems[0].SubItems[0].Text;
                var kisirehber = context.Kisis.FirstOrDefault(x => x.KisiId == Convert.ToInt32(id));
                context.Remove(kisirehber);
                context.SaveChanges();
                KisiListele();

            }
            temizle();

        }

        void temizle()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            mtxtPhone.Clear();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvPeople.Items.Clear();
            using (var context = new AppDbContext())
            {

              var ara = txtSearch.Text.Trim();
               var aranankisi = context.Kisis.Where(x=>x.Ad.Contains(ara) || x.Soyad.Contains(ara));

     
                foreach (var k in aranankisi)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = k.KisiId.ToString();
                    lvi.SubItems.Add(k.Ad);
                    lvi.SubItems.Add(k.Soyad);
                    lvi.SubItems.Add(k.Telefon);

                    lvPeople.Items.Add(lvi);
                }
            }
            txtSearch.Clear();
        }
    }
}