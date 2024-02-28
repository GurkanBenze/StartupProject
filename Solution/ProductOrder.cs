using BaslangicProjesi.Context;
using BaslangicProjesi.Entity;
using BaslangicProjesi.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaslangicProjesi.Solution
{
    public partial class ProductOrder : Form
    {
        #region Properts

        public int CustomerUserId { get; set; }
        public int AdminUserId { get; set; }
        public int UserId { get; set; }
        public int BasketId { get; set; }
        public decimal TotalPrice { get; set; }
        #endregion

        public ProductOrder()
        {
            InitializeComponent();
        }


        #region Methods

        public void GetItemsinCart()
        {
            dgvBasketProduct.Rows.Clear();

            using (BpDbContext dbContext = new BpDbContext())
            {
                var getUserUnorderedBasket = dbContext.Baskets.FirstOrDefault(x =>
                x.UserId == UserId &&
                x.Status == (byte)BasketStatusEnum.NotOrdered);

                if (getUserUnorderedBasket != null)
                {
                    this.BasketId = getUserUnorderedBasket.Id;
                    var activeBasketProducts = dbContext.BasketProducts.Where(x =>
                    x.BasketId == this.BasketId &&
                    x.Status == (byte)BasketProductStatusEnum.InBasket).ToList();

                    if (activeBasketProducts != null)
                    {
                        decimal totalPrice = 0;
                        foreach (var BasketProduct in activeBasketProducts)
                        {
                            var product = dbContext.Products.FirstOrDefault(x => x.Id == BasketProduct.ProductId);
                            totalPrice += product.Price;

                            string[] row = new string[] { product.Id.ToString() , BasketProduct.Id.ToString(), product.Name, product.Price.ToString() };
                            dgvBasketProduct.Rows.Add(row);
                        }
                        this.TotalPrice = totalPrice;
                    }
                }
            }
        }

        public void productList()
        {
            dgvProduct.Rows.Clear();
            using (BpDbContext dbContext = new BpDbContext())
            {
                var AllProduct = dbContext.Products.ToList();
                foreach (var allproduct in AllProduct)
                {
                    string[] row = new string[] { allproduct.Id.ToString(), allproduct.Name, allproduct.Amount.ToString(), allproduct.Price.ToString() };
                    dgvProduct.Rows.Add(row);
                }
            }
        }

        public void setDgvProductColumns()
        {
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.ColumnCount = 4;
            dgvProduct.Columns[0].Name = "Id";
            dgvProduct.Columns[0].Visible = false;
            dgvProduct.Columns[1].Name = "Name";
            dgvProduct.Columns[2].Name = "Amount";
            dgvProduct.Columns[3].Name = "Price";
        }

        public void isHideAdminPanel()
        {
            using (BpDbContext dbContext = new BpDbContext())

            {
                var checkIsadmin = dbContext.Users.FirstOrDefault(x => x.Id == this.UserId);
                if (checkIsadmin.IsAdmin ==0)
                {
                    lblBackHome.Hide();
                }
            }


        }
        public int checkAdminCustomerUpdated()
        {
            using (BpDbContext dbContext = new BpDbContext())

            {
                var checkIsadmin = dbContext.Users.FirstOrDefault(x => x.Id == this.UserId);
                if (checkIsadmin.IsAdmin == 1)
                {
                    return CustomerUserId;
                }
                return this.UserId;
            }


        }
        public void setDgvBasketProductColumns()
        {
            dgvBasketProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBasketProduct.ColumnCount = 4;
            dgvBasketProduct.Columns[0].Name = "ProductId";
            dgvBasketProduct.Columns[0].Visible = false;
            dgvBasketProduct.Columns[1].Name = "BasketProductId";
            dgvBasketProduct.Columns[2].Name = "Name";
            dgvBasketProduct.Columns[3].Name = "Price";
        }

       


        #endregion

        private void ProductOrder_Load(object sender, EventArgs e)
        {
            isHideAdminPanel();
            this.UserId = checkAdminCustomerUpdated();      

            setDgvProductColumns();
            productList();

            setDgvBasketProductColumns();
            GetItemsinCart();

        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            var row = dgvProduct.CurrentRow.Cells;
            string[] productInformations = new string[row.Count];

            for (int i = 0; i < row.Count; i++)
            {
                productInformations[i] = row[i].Value.ToString();
            }

            if (Convert.ToInt32(productInformations[2]) > 0)
            {
                int selectedProductId = Convert.ToInt32(productInformations[0]);
                using (BpDbContext dbContext = new BpDbContext())
                {
                    var checkProductAmount = dbContext.Products.FirstOrDefault(x => x.Id == selectedProductId);

                    checkProductAmount.Amount -= 1;
                    dbContext.SaveChanges();
                    productList();


                    BasketProduct basketProduct = new BasketProduct()
                    {
                        Status = (byte)BasketProductStatusEnum.InBasket,
                        ProductId = selectedProductId,
                        BasketId = this.BasketId
                    };
                    dbContext.BasketProducts.Add(basketProduct);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Product addition failed! The product is out of stock.", "Error");
            }

            GetItemsinCart();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.UserId = this.UserId;
            profile.BasketId = this.BasketId;
            profile.TotalPrice = this.TotalPrice;
            profile.Show();
            this.Hide();

        }

        private void dgvBasketProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmBasket_Click(object sender, EventArgs e)
        {
            using (BpDbContext dbContext = new BpDbContext())
            {
                var checkBasket = dbContext.Baskets.FirstOrDefault(x => x.UserId == this.UserId && x.Status == (byte)BasketStatusEnum.NotOrdered);

                if (checkBasket != null)
                {
                    var ListToProductInBasket = dbContext.BasketProducts.Where(x => x.BasketId == checkBasket.Id && x.Status == (byte)BasketProductStatusEnum.InBasket).ToList();
                    if (ListToProductInBasket.Count > 0)
                    {
                        foreach (var product in ListToProductInBasket)
                        {
                            var checkProduct = dbContext.Products.FirstOrDefault(x => x.Id == product.ProductId);
                            if (checkProduct.Amount > 0)
                            {
                                checkProduct.Amount -= 1;
                                product.Status = (byte)BasketProductStatusEnum.Ordered;
                                dbContext.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show($"This {checkProduct.Name} is Out of Stock.", "Error");
                            }
                        }
                        // Old Basket Changes
                        checkBasket.Status = (byte)BasketStatusEnum.Ordered;
                        dbContext.SaveChanges();

                        //New a Basket Create
                        Basket basket = new Basket()
                        {
                            UserId = this.UserId,
                            Status = (byte)BasketStatusEnum.NotOrdered,
                        };
                        dbContext.Baskets.Add(basket);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Your basket is empty. Please try to confirm after adding items.", "Error");
                    }

                    productList();
                    GetItemsinCart();

                }
            }
        }

        private void lblBackHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.UserId = this.AdminUserId;
            adminPanel.Show();
            this.Hide();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var row = dgvBasketProduct.CurrentRow.Cells;
            string[] productInformations = new string[row.Count];

            for (int i = 0; i < row.Count; i++)
            {
                productInformations[i] = row[i].Value.ToString();
            }

            int selectedProductId = Convert.ToInt32(productInformations[0]);
            int selectedBasketProductId = Convert.ToInt32(productInformations[1]);

            using (BpDbContext dbContext = new BpDbContext())
            {
                var checkProduct = dbContext.Products.FirstOrDefault(x => x.Id == selectedProductId);
                var checkBasketProduct = dbContext.BasketProducts.FirstOrDefault(x => x.Id == selectedBasketProductId);

                checkProduct.Amount += 1;
                dbContext.SaveChanges();

                checkBasketProduct.Status = 0;
                dbContext.SaveChanges();
                
            }
            productList();
            GetItemsinCart();

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
