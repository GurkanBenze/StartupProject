using BaslangicProjesi.Context;
using BaslangicProjesi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaslangicProjesi.Solution
{
    public partial class PasswordChanges : Form
    {

        public int UserId { get; set; }
       


        public void passwordChange()
        {
            #region TextboxValue
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string NewSocPas = txtNewPassSecond.Text;
            #endregion


            using (BpDbContext dbContext = new BpDbContext())
            {
                var CheckOldPassword = dbContext.Users.FirstOrDefault(x => x.Id == this.UserId);

                if (oldPass == CheckOldPassword.Password)
                {
                    if (newPass == NewSocPas)
                    { 
                        CheckOldPassword.Password = newPass;
                        dbContext.SaveChanges();
                        MessageBox.Show("Password Changed Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("New Passwords Are Not the Same!");
                    }
                }
                else
                {
                    MessageBox.Show("Old Password is Incorrect!");
                }

            }
            #region TextBoxClear
            txtOldPass.Clear();
            txtNewPass.Clear();
            txtNewPassSecond.Clear();
            #endregion

        }
        public PasswordChanges()
        {
            InitializeComponent();
        }

        private void PasswordChanges_Load(object sender, EventArgs e)
        {

        }

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            passwordChange();
        }

        private void linkprofiledön_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile profile = new Profile();
            profile.UserId = this.UserId;
            profile.Show();
            this.Hide();
        }
    }
}
