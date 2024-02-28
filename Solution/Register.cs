﻿using BaslangicProjesi.Context;
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
    public partial class Register : Form
    {

        public int UserId { get; set; }

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            #region Textbox Values
            string name = txtName.Text;
            string surname = txtSurName.Text;
            string email = txtEmail.Text;
            string tcn = txtTcn.Text;
            string PhoneNumber = txtPhoneNm.Text;
            string password = txtPass.Text;
            string passwordcheck = txtPassCheck.Text;
            #endregion

            if (name == null && surname == null && email == null && tcn == null & tcn == null && PhoneNumber == null && password == null && passwordcheck == null)
            {
                #region Empty Value Control
                if (name == null)
                {
                    MessageBox.Show("Name can't be empty ");
                }
                else if (surname == null)
                {
                    MessageBox.Show("SurName can't be empty ");

                }
                else if (email == null)
                {
                    MessageBox.Show("Email can't be empty ");
                }
                else if (tcn == null)
                {
                    MessageBox.Show("TcNumber can't be empty ");

                }
                else if (PhoneNumber == null)
                {
                    MessageBox.Show("PhoneNumber can't be empty ");
                }
                else if (password == null)
                {
                    MessageBox.Show("Password can't be empty ");
                }
                else if (passwordcheck == null)
                {
                    MessageBox.Show("Second Password can't be empty ");

                }
                #endregion

            }
            else
            {
                using (BpDbContext dbContext = new BpDbContext())
                {
                    var checkValueMail = dbContext.Users.FirstOrDefault(x => x.Email == email);
                    var checkValueTcn = dbContext.Users.FirstOrDefault(x => x.TcNumber == tcn);
                    var checkValuePhone = dbContext.Users.FirstOrDefault(x => x.PhoneNumber == PhoneNumber);

                    if (checkValueMail != null)
                    {
                        MessageBox.Show("This Mail is registered in the system");

                    }
                    else if (checkValueTcn != null)
                    {
                        MessageBox.Show("This TcNumber is registered in the system");

                    }
                    else if (checkValuePhone != null)
                    {
                        MessageBox.Show("This PhoneNumber is registered in the system");

                    }
                    else
                    {
                        if (password == passwordcheck)
                        {
                            User user = new User()
                            {
                                Name = name,
                                Surname = surname,
                                Email = email,
                                TcNumber = tcn,
                                PhoneNumber = PhoneNumber,
                                Password = password,
                            };
                            dbContext.Users.Add(user);
                            dbContext.SaveChanges();
                            this.UserId = user.Id;

                            Basket basket = new Basket()
                            {
                                UserId = this.UserId,
                                Status = (byte)BasketStatusEnum.NotOrdered
                            };
                            dbContext.Baskets.Add(basket);
                            dbContext.SaveChanges();

                            MessageBox.Show("Customer Registration Completed Successfully.");

                            ProductOrder productOrder = new ProductOrder();
                            productOrder.UserId = this.UserId;
                            this.Hide();
                            productOrder.Show();
                        }
                    }
                }
            }
        }

        private void lblBackHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.UserId = this.UserId;
            login.Show();
            this.Hide();
        }
    }
}
