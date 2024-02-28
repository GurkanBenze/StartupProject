using BaslangicProjesi.Context;
using BaslangicProjesi.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaslangicProjesi.Solution
{
    public partial class DeletedCustomer : Form
    {

        public int UserId { get; set; }
        public int BasketId { get; set; }
        public decimal TotalPrice { get; set; }

        public DeletedCustomer()
        {
            InitializeComponent();
        }

        public void userList()
        {
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.ColumnCount = 5;
            dgvUsers.Columns[0].Name = "Id";
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[1].Name = "Name";
            dgvUsers.Columns[2].Name = "Surname";
            dgvUsers.Columns[3].Name = "Email";
            dgvUsers.Columns[4].Name = "Address";

            using (BpDbContext dbContext = new BpDbContext())
            {
                var allUserList = dbContext.Users.Where(x => x.IsDeletedUser == 0);
                foreach (var alluserist in allUserList)
                {
                    string[] row = new string[] { alluserist.Id.ToString(), alluserist.Name, alluserist.Surname, alluserist.Email, alluserist.Address };
                    dgvUsers.Rows.Add(row);
                }
            }
        }

        private void DeletedCustomer_Load(object sender, EventArgs e)
        {
            userList();
        }
        private void btnDeletedUser_Click(object sender, EventArgs e)
        {

            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var userIsactive = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);

            using (BpDbContext dbContext = new BpDbContext())
            {
                var userDeleted = dbContext.Users.FirstOrDefault(x => x.Id == userIsactive);

                //Birinci Yöntem
                userDeleted.IsDeletedUser = (byte)UserDeletedEnum.UserDeleted;
                dbContext.SaveChanges();
                dgvUsers.Rows.Clear();
                userList();
            }
        }

        private void lblBackHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.UserId = this.UserId;
            adminPanel.Show();
            this.Hide();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
