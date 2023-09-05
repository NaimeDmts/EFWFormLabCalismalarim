using _3_EFLABMusteriListeleEkleSil.AppDbContext;
using _3_EFLABMusteriListeleEkleSil.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_EFLABMusteriListeleEkleSil
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetButton(true);
        }
        public Form2(Customer customer)
        {
            InitializeComponent();
            _gelenKisi = customer;
            Kisi();
            SetButton(false);
        }
        NorthwindContext db;
        Customer _gelenKisi;
        private void SetButton(bool set)
        {
            if (set)
            {
                txtCustomerID.Enabled = true;
                btnKaydet.Text = "Kaydet";
                btnKaydet.Enabled = true;
                btnSil.Enabled = false;
            }
            else
            {
                txtCustomerID.Enabled= false;
                btnKaydet.Text = "Güncelle";
                btnKaydet.Enabled = true;
                btnSil.Enabled = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if(_gelenKisi != null)
            {
                db.Customers.Remove(_gelenKisi);
                db.SaveChanges();
                _gelenKisi = null;
                FormKapat();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(_gelenKisi != null)
            {

                _gelenKisi.CustomerId= txtCustomerID.Text;
                _gelenKisi.CompanyName = txtCompanyName.Text;
                _gelenKisi.ContactName = txtContactName.Text;
                _gelenKisi.ContactTitle = txtContactTitle.Text;
                _gelenKisi.Address = txtAddress.Text;
                _gelenKisi.City = txtCity.Text;
                _gelenKisi.PostalCode = txtPostalCode.Text;
                _gelenKisi.Country = txtPostalCode.Text;
                _gelenKisi.Phone = txtPhone.Text;
                _gelenKisi.Fax = txtFax.Text;
                db.Customers.Update(_gelenKisi);
                db.SaveChanges();
                _gelenKisi = null;
                SetButton(false);
                FormKapat();

            }
            else
            {
                Customer customer = new Customer();
                customer.CustomerId = txtCustomerID.Text;
                customer.CompanyName = txtCompanyName.Text;
                customer.ContactName = txtContactName.Text;
                customer.ContactTitle = txtContactTitle.Text;
                customer.Address = txtAddress.Text;
                customer.City = txtCity.Text;
                customer.PostalCode = txtPostalCode.Text;
                customer.Country = txtPostalCode.Text;
                customer.Phone = txtPhone.Text;
                customer.Fax = txtFax.Text;
                db.Customers.Add(customer);
                db.SaveChanges();
                SetButton(true);
                FormKapat();


            }
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new NorthwindContext();
        }
        private void Kisi()
        {
            txtCustomerID.Text = _gelenKisi.CustomerId;
            txtCompanyName.Text = _gelenKisi.CompanyName;
            txtContactName.Text = _gelenKisi.ContactName;
            txtContactTitle.Text = _gelenKisi.ContactTitle;
            txtAddress.Text = _gelenKisi.Address;
            txtCity.Text = _gelenKisi.City;
            txtPostalCode.Text = _gelenKisi.PostalCode;
            txtCountry.Text = _gelenKisi.Country;
            txtPhone.Text = _gelenKisi.Phone;
            txtFax.Text = _gelenKisi.Fax;
        }
      private void FormKapat()
        {
            this.Close();

        }
    }
}
