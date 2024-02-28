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
    public partial class MailChanges : Form
    {
        public int UserId { get; set; }

        public void mailChange()
        {

            string oldMail = txtOldMail.Text;
            string newMail = txtNewMail.Text;
            string password = txtPass.Text;

            using (BpDbContext dbContext = new BpDbContext())
            {
                var checkUser = dbContext.Users.FirstOrDefault(x => x.Id == this.UserId);
                if (oldMail == checkUser.Email)
                {
                    var checkMail = dbContext.Users.FirstOrDefault(x => x.Email == newMail);
                    if (checkMail != null)
                    {
                        MessageBox.Show("This Email Is Already Being Used");
                    }
                    else
                    {
                        if (password == checkUser.Password)
                        {

                            checkUser.Email = password;
                            dbContext.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Password is incorrect!\r\n");
                        }
                    }
                }
            }
            txtOldMail.Clear();
            txtPass.Clear();
            txtNewMail.Clear();
        }


        public MailChanges()
        {
            InitializeComponent();
        }

        private void MailChanges_Load(object sender, EventArgs e)
        {

        }

        private void linkProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile profile = new Profile();
            profile.UserId = this.UserId;
            profile.Show();
            this.Hide();
        }

        private void btnMailDegistir_Click(object sender, EventArgs e)
        {
            mailChange();
        }
    }
}
