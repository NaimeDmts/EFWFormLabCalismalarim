using KisiNot.BLL.Concrete;
using KisiNot.Repository.Concrete;
using KisiNot.Repository.Contexts;

namespace KisiNot.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            context =new AppDbContext();
            kullaniciRepo = new KullaniciRepo(context);
            kullaniciService = new KullaniciService(kullaniciRepo);
        }
        AppDbContext context;
        KullaniciRepo kullaniciRepo;
        KullaniciService kullaniciService;
      
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
          
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Show();
        }
    }
}