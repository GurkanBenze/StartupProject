using BaslangicProjesi.Context;
using BaslangicProjesi.Entity;
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
    public partial class AddBalance : Form
    {
        public int UserId { get; set; }

        public void addBalance()
        {
            decimal balance = decimal.Parse(txtbalance.Text);
            string password = txtPassword.Text;

            using (BpDbContext dbContext = new BpDbContext())
            {
                var checkPassword = dbContext.Users.FirstOrDefault(x => x.Id == this.UserId);
                if (checkPassword.Password == password)
                {
                    var checkedWallet = dbContext.Wallets.FirstOrDefault(x => x.UserId == this.UserId);
                    Wallet wallet = new Wallet()
                    {
                        UserId = this.UserId,
                        Balance = checkedWallet.Balance + balance,
                    };
                    dbContext.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Password is incorrect!\r\n");
                }
            }
            txtbalance.Clear();
            txtPassword.Clear();

        }

        public AddBalance()
        {
            InitializeComponent();
        }

        private void AddBalance_Load(object sender, EventArgs e)
        {
           

        }

        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            addBalance();

        }

        private void linkprofile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile profile = new Profile();
            profile.UserId = this.UserId;
            profile.Show();
            this.Hide();
        }
    }
}
