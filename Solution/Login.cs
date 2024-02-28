using BaslangicProjesi.Context;
using BaslangicProjesi.Entity;
using BaslangicProjesi.Solution;
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

namespace BaslangicProjesi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public int UserId;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var password = txtPass.Text.Trim();

            using (BpDbContext dbContext = new BpDbContext())
            {
                try
                {
                    var checkUserControl = dbContext.Users.FirstOrDefault(x => x.Email == email);
                    this.UserId = checkUserControl.Id;

                    if (checkUserControl == null)
                    {
                        MessageBox.Show("There is no user with this email!!");
                    }
                    else
                    {
                        if (password == checkUserControl.Password.Trim())
                        {
                            if (checkUserControl.IsAdmin == 1)
                            {
                                AdminPanel adminpanel = new AdminPanel();
                                adminpanel.UserId = this.UserId;
                                this.Hide();
                                adminpanel.Show();
                            }
                            else
                            {
                                var checkBasket = dbContext.Baskets.FirstOrDefault(x => x.UserId == this.UserId && x.Status == (byte)BasketStatusEnum.NotOrdered);
                                if (checkBasket == null)
                                {
                                    Basket basket = new Basket()
                                    {
                                        UserId = this.UserId,
                                        Status = (byte)BasketStatusEnum.NotOrdered,
                                    };
                                    dbContext.Baskets.Add(basket);
                                    dbContext.SaveChanges();
                                    MessageBox.Show("There was a problem with the basket. A new basket has been created.");
                                }

                                ProductOrder productOrder = new ProductOrder();
                                productOrder.UserId = this.UserId;
                                this.Hide();
                                productOrder.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your password is incorrect!");
                        }
                    }
                }
                catch (Exception ex)
                {

                    var mssg = ex.Message;
                }
               

            }


        }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void cbParolaGoster_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cbParolaGoster.Checked;

            //Eğer isChecked true ise:
            if (isChecked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
