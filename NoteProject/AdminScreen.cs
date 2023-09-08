using NoteProject.Entities.Concrete;
using NoteProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteProject
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            userRepository = new UserRepository();
            notRepository= new NotRepository();
        }
        UserRepository userRepository;
        NotRepository notRepository;
        private void btnDurum_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                User user = (User)listView1.FocusedItem.Tag;
                //BLL
                if (user.IsActive)
                {
                    user.IsActive = false;
                }
                else
                {
                    user.IsActive = true;
                }
                userRepository.Update(user);
                FiilListView();
            }
        }
    

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            dgvLastNot.DataSource = notRepository.GetLastTenNotes();
            FiilListView();

        }
        private void FiilListView()
        {
            List<User> users = userRepository.GetAllStandartUser();
            listView1.Items.Clear();
            foreach(User u in users)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = u.FirstName;
                lvi.SubItems.Add(u.LastName);
                lvi.SubItems.Add(u.UserName);
                lvi.SubItems.Add(u.IsActive ? "Aktif" : "Pasif");
                lvi.Tag= u;
                listView1.Items.Add(lvi);
            }

        }
    }
}
