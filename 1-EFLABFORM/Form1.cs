using _1_EFLABFORM.AppDbContext;
using _1_EFLABFORM.Models;

namespace _1_EFLABFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            db= new NorthwindContext();
            InitializeComponent();
        }
        NorthwindContext db;
        
        private void btnCalisanGetir_Click(object sender, EventArgs e)
        {
            List<Employee> calisanlar = db.Employees.ToList();
            foreach(var item in calisanlar)
            {
                string calisanData = item.EmployeeId + " " + item.FirstName + " " + item.LastName;
              lblCalisan.Items.Add(calisanData);
            }
            
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = txtAd.Text;
            employee.LastName = txtSoyad.Text;
            db.Employees.Add(employee);
            db.SaveChanges();
        }
    }
}