using BaslangicProjesi.Context;
using BaslangicProjesi.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BaslangicProjesi.Solution
{
    public partial class UpdatedCustomer : Form
    {

        public int UserId { get; set; }

        public UpdatedCustomer()
        {
            InitializeComponent();
        }
       
        #region Methods
        public void userList()
        {
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvUsers.ColumnCount = 9;
            dgvUsers.Columns[0].Name = "Id";
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[1].Name = "Name";
            dgvUsers.Columns[2].Name = "Surname";
            dgvUsers.Columns[3].Name = "Address";
            dgvUsers.Columns[4].Name = "PhoneNumber";
            dgvUsers.Columns[5].Name = "TcNumber";
            dgvUsers.Columns[6].Name = "Email";
            dgvUsers.Columns[7].Name = "Password";
            dgvUsers.Columns[8].Name = "IsAdmin";



            using (BpDbContext dbContext = new BpDbContext())
            {
                var allUserList = dbContext.Users.Where(x => x.IsDeletedUser == 0);
                foreach (var alluserist in allUserList)
                {
                    string[] row = new string[] { alluserist.Id.ToString(), alluserist.Name, alluserist.Surname, alluserist.Address, alluserist.PhoneNumber, alluserist.TcNumber, alluserist.Email, alluserist.Password.ToString(), alluserist.IsAdmin.ToString() };
                    dgvUsers.Rows.Add(row);
                }
            }
        }

        public void customerUpdate()
        {
            
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            var customerUpdate = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);

            using (BpDbContext dbContext = new BpDbContext())
            {

                #region Update Controller
                var productUpdate = dbContext.Users.FirstOrDefault(x => x.Id == customerUpdate);
                if (txtName.Text !="")
                {
                    productUpdate.Name = txtName.Text;
                    dbContext.SaveChanges();
                }
                if (txtSurname.Text !="")
                {
                    productUpdate.Surname = txtSurname.Text;
                    dbContext.SaveChanges();
                }

                if (txtAdress.Text  !="")
                {
                    productUpdate.Address = txtAdress.Text;
                    dbContext.SaveChanges();
                }

                if (txtPhone.Text !="")
                {
                    productUpdate.PhoneNumber = txtPhone.Text;
                    dbContext.SaveChanges();
                }
                if (txtTc.Text !="")
                {
                    productUpdate.TcNumber = txtTc.Text;
                    dbContext.SaveChanges();
                }
                if (txtmail.Text !="")
                {
                    productUpdate.Email = txtmail.Text;
                    dbContext.SaveChanges();
                }
                if (txtPass.Text!="")
                {
                    productUpdate.Password = txtPass.Text;
                    dbContext.SaveChanges();
                }
                if (txtAdmin.Text !="")
                {
                    productUpdate.IsAdmin = Convert.ToByte(txtAdmin.Text);
                    dbContext.SaveChanges();

                }

                #endregion

                MessageBox.Show("customer is Changed Successfully.");
                dgvUsers.Rows.Clear();

            }

        }
        #endregion
        private void UpdatedCustomer_Load(object sender, EventArgs e)
        {
            userList();
        }

        private void lblBackHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.UserId = this.UserId;
            adminPanel.Show();
            this.Hide();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            customerUpdate();
            dgvUsers.Rows.Clear();
            userList();

        }
    }
}
