using _5_KisiAdres.DAL.Contexts;
using _5_KisiAdres.DATA.Concrete;
using _5_KisiAdres.UI.Concrete;

namespace _5_KisiAdresForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            context = new AppDbContext();
            kisiUI = new KisiUI(context);
        }
        KisiUI kisiUI;
        AppDbContext context;
        Kisi kisi;
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            lvKisiler.Items.Clear();
            using (var context = new AppDbContext())
            {

                var kisiler = context.Kisis.ToList();
                foreach (var k in kisiler)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = k.Id.ToString();
                    lvi.SubItems.Add(k.Ad);
                    lvi.SubItems.Add(k.Soyad);

                    lvKisiler.Items.Add(lvi);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            kisi = new Kisi();
            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.Telefon = mtxtTelefon.Text;
            kisiUI.Add(kisi);
            Listele();



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (lvKisiler.SelectedItems.Count > 0)
            {
                string id = lvKisiler.SelectedItems[0].SubItems[0].Text;
                kisi = context.Kisis.FirstOrDefault(x => x.Id == Convert.ToInt32(id));
                kisi.Ad = txtAd.Text;
                kisi.Soyad = txtSoyad.Text;
                kisi.Telefon = mtxtTelefon.Text;
                kisiUI.Update(kisi);
            }
            Listele();


        }

        private void lvKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKisiler.SelectedItems.Count > 0)
            {


                string id = lvKisiler.SelectedItems[0].SubItems[0].Text;
                kisi = context.Kisis.FirstOrDefault(x => x.Id == Convert.ToInt32(id));
                txtAd.Text = kisi.Ad;
                txtSoyad.Text = kisi.Soyad;
                mtxtTelefon.Text = kisi.Telefon;


            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string id = lvKisiler.SelectedItems[0].SubItems[0].Text;
            kisi = context.Kisis.FirstOrDefault(x => x.Id == Convert.ToInt32(id));
            kisiUI.Delete(kisi);
            Listele();


        }

        private void txtKisiAra_TextChanged(object sender, EventArgs e)
        {
            lvKisiler.Items.Clear();


            var ara = txtKisiAra.Text.Trim();
            var aranankisi = context.Kisis.Where(x => x.Ad.Contains(ara) || x.Soyad.Contains(ara));


            foreach (var k in aranankisi)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = k.Id.ToString();
                lvi.SubItems.Add(k.Ad);
                lvi.SubItems.Add(k.Soyad);
                lvKisiler.Items.Add(lvi);
            }

        }

        private void adresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvKisiler.SelectedItems.Count > 0)
            {
                string id = lvKisiler.SelectedItems[0].SubItems[0].Text;
                kisi = context.Kisis.FirstOrDefault(x => x.Id == Convert.ToInt32(id));
                Form2 form2 = new Form2(kisi, kisiUI);
                form2.ShowDialog();

            }
        }

        private void linkYoneticiEkrani_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       
            Form3 form3 = new Form3(kisi, kisiUI);
            form3.ShowDialog();
        }
    }
}