using BaslangicProjesi.Context;
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

namespace BaslangicProjesi.Solution
{
    public partial class DeletedProduct : Form
    {

        public int UserId {  get; set; }
        public DeletedProduct()
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
                    string[] row = new string[] { allproduct.Id.ToString(), allproduct.Name, allproduct.Unit, allproduct.Amount.ToString(), allproduct.Price.ToString() };
                    dgvProduct.Rows.Add(row);
                }
            }
        }

        public void setDgvColumns()
        {
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.ColumnCount = 5;
            dgvProduct.Columns[0].Name = "Id";
            dgvProduct.Columns[0].Visible = false;
            dgvProduct.Columns[1].Name = "Name";
            dgvProduct.Columns[2].Name = "Unit";
            dgvProduct.Columns[3].Name = "Amount";
            dgvProduct.Columns[4].Name = "Price";

        }

        public void deletedProduct()
        {
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            var productDeleteCheck = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value);

            using (BpDbContext dbContext = new BpDbContext())
            {
                var productDelete = dbContext.Products.FirstOrDefault(x => x.Id == productDeleteCheck);
                //Birinci Yöntem
                productDelete.IsActive = (byte)BasketProductStatusEnum.Deleted;
                dbContext.SaveChanges();
                dgvProduct.Rows.Clear();
                productlist();
            }

        }

        private void DeletedProduct_Load(object sender, EventArgs e)
        {
            setDgvColumns();
            productlist();
        }               

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeletedProduct_Click(object sender, EventArgs e)
        {
            deletedProduct();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.UserId = this.UserId;
            addProduct.Show();
            this.Hide();
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
