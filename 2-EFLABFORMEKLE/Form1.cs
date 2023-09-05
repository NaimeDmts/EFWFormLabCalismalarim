using _2_EFLABFORMEKLE.AppDbContext;
using _2_EFLABFORMEKLE.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Security.AccessControl;

namespace _2_EFLABFORMEKLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            db = new KisiDBContext();
            InitializeComponent();
        }
        KisiDBContext db;
        TblKisi kisi;


        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblKisi kisi = new TblKisi();
            kisi.KisiId = (int)nuId.Value;
            kisi.KisiAd = txtAd.Text;
            kisi.KisiSoyad = txtSoyad.Text;
            kisi.KisiDogumTarihi = dtDogum.Value;
            kisi.KisiTelefon = txtTelefon.Text;
            kisi.KisiAdres = txtAdres.Text;
            kisi.KisiSehir = txtSehir.Text;
            db.TblKisis.Add(kisi);
            List<TblKisi> kisiler = db.TblKisis.ToList();
            db.SaveChanges();
           
            lblKisi.Items.Clear();
            foreach(var item in kisiler)
            {
                lblKisi.Items.Add($"{item.KisiId} {item.KisiAd} {item.KisiSoyad} {item.KisiDogumTarihi} {item.KisiTelefon} {item.KisiTelefon} {item.KisiAdres} {item.KisiAdres} {item.KisiSehir}");
            }
            Temizle();
        }

 

        private void btnGetir_Click(object sender, EventArgs e)
        {
            List<TblKisi> kisi = db.TblKisis.ToList();
            foreach(var item in kisi)
            {
                lblKisi.Items.Add($"{item.KisiId} {item.KisiAd} {item.KisiSoyad} {item.KisiDogumTarihi} {item.KisiTelefon} {item.KisiTelefon} {item.KisiAdres} {item.KisiAdres} {item.KisiSehir}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetButton(true);
            ListViewDoldur();
        }
        private void ListViewDoldur()
        {
            listView1.Items.Clear();
           List<TblKisi> kisiListe = db.TblKisis.ToList();
            foreach(TblKisi kisi in kisiListe)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = kisi.KisiId.ToString();
                listViewItem.SubItems.Add(kisi.KisiAd);
                listViewItem.SubItems.Add(kisi.KisiSoyad);
                listViewItem.SubItems.Add(kisi.KisiDogumTarihi.ToString());
                listViewItem.SubItems.Add(kisi.KisiTelefon);
                listViewItem.SubItems.Add(kisi.KisiAdres);
                listViewItem.SubItems.Add(kisi.KisiSehir);
                //I.Yol
                //listViewItem.Tag = kisi;

                listView1.Items.Add(listViewItem);
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                //I.Yol
                //TblKisi kisi = (TblKisi)listView1.FocusedItem.Tag;
               int id=Convert.ToInt32( listView1.SelectedItems[0].SubItems[0].Text);
                kisi = db.TblKisis.FirstOrDefault(a => a.KisiId == id);
                TblKisi kisi1 = db.TblKisis.Find(id);//primary key kullanacaksan 
                nuId.Value = kisi.KisiId;
                txtAd.Text = kisi.KisiAd;
                txtSoyad.Text = kisi.KisiSoyad;
                dtDogum.Value = kisi.KisiDogumTarihi.Value;
                txtTelefon.Text = kisi.KisiTelefon;
                txtAdres.Text = kisi.KisiAdres;
                txtSehir.Text = kisi.KisiSehir;
              
                SetButton(false);

            }
            else
            {
                SetButton(true);
                kisi = null;
                Temizle();

            }
        }
        private void SetButton(bool set)
        {
            if (set)
            {
                btnEkle.Enabled = true;
                BtnSil.Enabled = false;
                btnGuncelle.Enabled = false;
                nuId.Enabled = true;


            }
            else
            {
                btnEkle.Enabled = false;
                BtnSil.Enabled = true;
                btnGuncelle.Enabled = true;
                nuId.Enabled = false;
            }
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(kisi != null)
            {
                db.TblKisis.Remove(kisi);

                db.SaveChanges();
                ListViewDoldur();
                kisi = null;
                Temizle();
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kisi.KisiId = (int)nuId.Value;
            kisi.KisiAd = txtAd.Text;
            kisi.KisiSoyad = txtSoyad.Text;
            kisi.KisiDogumTarihi = dtDogum.Value;
            kisi.KisiTelefon = txtTelefon.Text;
            kisi.KisiAdres = txtAdres.Text;
            kisi.KisiSehir = txtSehir.Text;

            db.TblKisis.Update(kisi);
            db.SaveChanges();
            SetButton(true);
            kisi = null;
            ListViewDoldur();
            Temizle();
        }
        private void Temizle()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
                else if(control is NumericUpDown) 
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = 0;
                }
                else if(control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
            }
        }
    }
}