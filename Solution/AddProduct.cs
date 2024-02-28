using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using BaslangicProjesi.Entity;
using System.Data.Entity;
using BaslangicProjesi.Context;

namespace BaslangicProjesi.Solution
{
    public partial class AddProduct : Form
    {
        public int UserId { get; set; }

        public void addProduct()
        {
            #region Textbox Values
            string Name = txtName.Text;
            string Barcode = txtBarcode.Text;
            string Unit = txtUnit.Text;
            int Amount = Convert.ToInt32(txtAmount.Text);
            decimal Price = Convert.ToDecimal(txtPrice.Text);

            #endregion

            using (BpDbContext dbContext = new BpDbContext())
            {

                if (Name == null && Barcode == null && Unit == null && Amount == null & Price == null)
                {
                    #region Empty Value Control
                    if (Name == null)
                    {
                        MessageBox.Show("Name can't be empty ");
                    }
                    else if (Barcode == null)
                    {
                        MessageBox.Show("Barcode can't be empty ");

                    }
                    else if (Amount == null)
                    {
                        MessageBox.Show("Amount can't be empty ");
                    }
                    else if (Unit == null)
                    {
                        MessageBox.Show("Unit can't be empty ");

                    }
                    else if (Amount == null)
                    {
                        MessageBox.Show("Amount can't be empty ");
                    }
                    else if (Price == null)
                    {
                        MessageBox.Show("Price can't be empty ");
                    }
                    #endregion
                }

                else
                {
                    Product product = new Product()
                    {
                        Name = Name,
                        Barcode = Barcode,
                        Unit = Unit,
                        Amount = Amount,
                        Price = Price,
                        IsActive=1
                        

                    };
                    dbContext.Products.Add(product);
                    dbContext.SaveChanges();
                    MessageBox.Show("Product Registration Completed Successfully.");
                }
            }

        }




        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        private void lblBackHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.UserId = this.UserId;
            adminPanel.Show();
            this.Hide();

        }
    }
}
