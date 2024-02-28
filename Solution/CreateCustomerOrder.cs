using BaslangicProjesi.Context;
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
    public partial class CreateCustomerOrder : Form
    {
        #region Property

        public int adminId { get; set; }
        public int UserId { get; set; }
        public int BasketId { get; set; }
        public decimal TotalPrice { get; set; }
        #endregion


        #region Methods
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

        public void createCusOr()
        {
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var userIsactive = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);

            using (BpDbContext dbContext = new BpDbContext())
            {
                var userCreateOrder = dbContext.Users.FirstOrDefault(x => x.Id == userIsactive);

                ProductOrder productOrder = new ProductOrder();
                productOrder.CustomerUserId = userCreateOrder.Id;
                productOrder.UserId = this.UserId;
                productOrder.AdminUserId = this.UserId;
                productOrder.Show();
                this.Hide();
            }
        }

       
        #endregion



        public CreateCustomerOrder()
        {
            InitializeComponent();
        }

        private void CreateCustomerOrder_Load(object sender, EventArgs e)
        {
            userList();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            createCusOr();
        }

        private void lblBackHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.UserId = this.UserId;
            adminPanel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
