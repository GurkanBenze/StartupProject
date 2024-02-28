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
    public partial class AdminPanel : Form
    {
        public int UserId { get; set; }

      

       

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.UserId = this.UserId;
            addCustomer.Show();
            this.Hide();
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            CreateCustomerOrder createCustomerOrder = new CreateCustomerOrder();
            createCustomerOrder.UserId = this.UserId;
            createCustomerOrder.Show();
            this.Hide();

        }



        private void btnDeletedProduct_Click(object sender, EventArgs e)
        {
            DeletedProduct deletedProduct = new DeletedProduct();
            deletedProduct.UserId = this.UserId;
            deletedProduct.Show();
            this.Hide();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.UserId = this.UserId;
            addProduct.Show();
            this.Hide();
        }

        private void btnDeletedCustomer_Click(object sender, EventArgs e)
        {
            DeletedCustomer deletedCustomer = new DeletedCustomer();
            deletedCustomer.UserId = this.UserId;
            deletedCustomer.Show();
            this.Hide();
        }

        private void btnUpdatedProduct_Click(object sender, EventArgs e)
        {
            UpdatedProduct updatedProduct = new UpdatedProduct();
            updatedProduct.UserId = this.UserId;
            updatedProduct.Show();
            this.Hide();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            UpdatedCustomer updatedCustomer = new UpdatedCustomer();
            updatedCustomer.UserId = this.UserId;
            updatedCustomer.Show();
            this.Hide();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            using (BpDbContext dbContext = new BpDbContext())
            {
                ShowBasketHistory showBasketHistory = new ShowBasketHistory();
                showBasketHistory.UserId = this.UserId;
                showBasketHistory.adminId = this.UserId;
                showBasketHistory.Show();
                this.Hide();
            }
        }
    }
}
