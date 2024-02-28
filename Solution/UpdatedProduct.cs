using BaslangicProjesi.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaslangicProjesi.Solution
{
    public partial class UpdatedProduct : Form
    {
        public int UserId { get; set; }

        public UpdatedProduct()
        {
            InitializeComponent();
        }
        public void productlist()
        {
            using (BpDbContext dbContext = new BpDbContext())
            {
                var AllProduct = dbContext.Products.Where(x => x.IsActive == 1);
                foreach (var allproduct in AllProduct)
                {
                    string[] row = new string[] { allproduct.Id.ToString(), allproduct.Name, allproduct.Barcode.ToString(), allproduct.Unit, allproduct.Amount.ToString(), allproduct.Price.ToString() };
                    dgvProduct.Rows.Add(row);
                }
            }
        }

        public void setDgvColumns()
        {
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.ColumnCount = 6;
            dgvProduct.Columns[0].Name = "Id";
            dgvProduct.Columns[0].Visible = false;
            dgvProduct.Columns[1].Name = "Name";
            dgvProduct.Columns[2].Name = "Barcode";
            dgvProduct.Columns[3].Name = "Unit";
            dgvProduct.Columns[4].Name = "Amount";
            dgvProduct.Columns[5].Name = "Price";

        }

        public void productUpdate()
        {

            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            var productUpdated = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value);
            using (BpDbContext dbContext = new BpDbContext())

            {
                var productUpdate = dbContext.Products.FirstOrDefault(x => x.Id == productUpdated);

                #region ProductUpdated

                if (txtName.Text != "")
                {
                    productUpdate.Name = txtName.Text;
                    dbContext.SaveChanges();
                }
                if (txtBarcode.Text != "")
                {
                    productUpdate.Barcode = txtBarcode.Text;
                    dbContext.SaveChanges();
                }

                if (txtUnit.Text != "")
                {
                    productUpdate.Unit = txtUnit.Text;
                    dbContext.SaveChanges();
                }

                if (txtAmount.Text != ""&& Convert.ToInt32(txtAmount.Text)>=0)
                {
                    productUpdate.Amount = Convert.ToInt32(txtAmount.Text);
                    dbContext.SaveChanges();
                }

                if (txtPrice.Text != "")
                {
                    productUpdate.Price = Convert.ToDecimal(txtPrice.Text);
                    dbContext.SaveChanges();
                }

                #endregion
                MessageBox.Show("Product is Changed Successfully.");
                dgvProduct.Rows.Clear();
            }
        }

        private void UpdatedProduct_Load(object sender, EventArgs e)
        {
            setDgvColumns();
            productlist();
        }



        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            productUpdate();
            dgvProduct.Rows.Clear();
            productlist();
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

