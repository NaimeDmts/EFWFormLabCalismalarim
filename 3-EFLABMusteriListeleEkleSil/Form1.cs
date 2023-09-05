using _3_EFLABMusteriListeleEkleSil.AppDbContext;
using _3_EFLABMusteriListeleEkleSil.Models;

namespace _3_EFLABMusteriListeleEkleSil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindContext db;
        Customer customer;
        private void musteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                customer = db.Customers.FirstOrDefault(x => x.CustomerId == id);
                Form2 form2 = new Form2(customer);
                form2.ShowDialog();
                MusteriGetir();
            }
            else
            {
                customer = null;
            }
        }
        private void MusteriGetir()
        {
            db = new NorthwindContext();
            listView1.Items.Clear();
            var musteriler = db.Customers.ToList();
            foreach (var musteri in musteriler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = musteri.CustomerId.ToString();
                lvi.SubItems.Add(musteri.CompanyName);
                lvi.SubItems.Add(musteri.ContactName);
                lvi.SubItems.Add(musteri.ContactTitle);
                lvi.SubItems.Add(musteri.Address);
                lvi.SubItems.Add(musteri.City);
                lvi.SubItems.Add(musteri.Country);

                listView1.Items.Add(lvi);
            }
        }

        private void yeniMusteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            MusteriGetir();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }
    }
}