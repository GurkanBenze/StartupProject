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
    public partial class Profile : Form
    {
        #region Properts


        public int UserId { get; set; }
        public int BasketId { get; set; }
        public decimal TotalPrice { get; set; }
        #endregion

        public Profile()
        {
            InitializeComponent();
        }
        public void isHidCustomerPanel()
        {
            using (BpDbContext dbContext = new BpDbContext())

            {
                var checkIsadmin = dbContext.Users.FirstOrDefault(x => x.Id == this.UserId);
                if (checkIsadmin.IsAdmin == 0)
                {
                    lbladminPage.Hide();
                }
            }


        }





        private void Profile_Load(object sender, EventArgs e)
        {
            isHidCustomerPanel();
           
        }

        private void linkPasschan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordChanges passwordChanges = new PasswordChanges();
            passwordChanges.UserId = this.UserId;
            passwordChanges.Show();
            this.Hide();
        }

        private void linkMailChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MailChanges mailChanges = new MailChanges();
            mailChanges.UserId = this.UserId;
            mailChanges.Show();
            this.Hide();
        }

        private void linkAddBalance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddBalance addBalance = new AddBalance();
            addBalance.UserId = this.UserId;
            addBalance.Show();
            this.Hide();
        }

        private void linkBasketHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowBasketHistory showBasketHistory = new ShowBasketHistory();
            showBasketHistory.UserId = this.UserId;
            showBasketHistory.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductOrder productOrder = new ProductOrder();
            productOrder.UserId = this.UserId;
            productOrder.Show();
            this.Hide();
        }

        private void lbladminPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();   
            adminPanel.UserId = this.UserId;
            adminPanel.Show();
            this.Hide();
        }
    }
}
