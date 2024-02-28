using BaslangicProjesi.Context;
using BaslangicProjesi.Entity;
using BaslangicProjesi.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BaslangicProjesi.Solution
{

    public partial class ShowBasketHistory : Form
    {
        public int UserId { get; set; }
        public int adminId { get; set; }

        public void showbasket1()
        {

            using (BpDbContext dbContext = new BpDbContext())
            {
                dtvBasketShow.Rows.Clear();
                int counterBasket = 1;
                int counterProduct = 1;
                var admincheck = dbContext.Users.FirstOrDefault(x => x.Id == this.UserId);
                decimal total = 0;
                if (admincheck.IsAdmin == 1)
                {
                    var allUserList = dbContext.Baskets.ToList();

                    foreach (var alluserist in allUserList)
                    {
                        var userinfo = dbContext.Users.FirstOrDefault(x => x.Id == alluserist.UserId);

                        string basketStatus = alluserist.Status == (byte)BasketStatusEnum.Ordered ? "Ordered" : alluserist.Status == (byte)BasketStatusEnum.NotOrdered ? "Not Ordered" : "Deleted";
                        string[] row = new string[] { $"{alluserist.Id}", $"{userinfo.Name} {userinfo.Surname} {counterBasket}.Basket", " ", " ", " ", $"{basketStatus}" };
                        counterBasket++;
                        dtvBasketShow.Rows.Add(row);

                        var checkProduct = dbContext.BasketProducts.Where(x => x.BasketId == alluserist.Id).ToList();
                        foreach (var product in checkProduct)
                        {
                            string status = product.Status == (byte)BasketProductStatusEnum.Ordered ? "Ordered" : product.Status == (byte)BasketProductStatusEnum.InBasket ? "In Basket" : "Deleted";
                            var showProduct = dbContext.Products.FirstOrDefault(x => x.Id == product.ProductId);

                            if (showProduct.Amount > 0)
                            {
                                string[] roww = new string[] { $"{alluserist.Id}", $" + {counterProduct}.Product ", showProduct.Name, showProduct.Price.ToString(), $"{status}" };
                                total += showProduct.Price;
                                dtvBasketShow.Rows.Add(roww);
                                counterProduct++;
                            }
                        }
                        string[] TotalPrice = new string[] { " ", " ", " ", " ", " ", " ", $"{total}" };
                        dtvBasketShow.Rows.Add(TotalPrice);
                        total = 0;
                        counterProduct = 1;
                    }
                }
                else
                {
                    var userBasketList = dbContext.Baskets.Where(x => x.UserId == this.UserId).ToList();

                    foreach (var alluserist in userBasketList)
                    {
                        var userinfo = dbContext.Users.FirstOrDefault(x => x.Id == alluserist.UserId);

                        string[] row = new string[] { $"{alluserist.Id}", $"{userinfo.Name} {userinfo.Surname} {counterBasket}.Basket" };
                        counterBasket++;
                        dtvBasketShow.Rows.Add(row);

                        var checkProduct = dbContext.BasketProducts.Where(x => x.BasketId == alluserist.Id).ToList();
                        foreach (var product in checkProduct)
                        {
                            string status = product.Status == (byte)BasketProductStatusEnum.Ordered ? "Ordered" : product.Status == (byte)BasketProductStatusEnum.InBasket ? "In Basket" : "Remove";
                            var showProduct = dbContext.Products.FirstOrDefault(x => x.Id == product.ProductId);

                            if (showProduct.Amount > 0)
                            {
                                string[] roww = new string[] { $"{alluserist.Id}", $" + {counterProduct}.Product ", showProduct.Name, showProduct.Price.ToString(), $"{status}" };
                                total += showProduct.Price;
                                dtvBasketShow.Rows.Add(roww);
                                counterProduct++;
                            }
                        }
                        string[] TotalPrice = new string[] { " ", " ", " ", " ", " ", $"{total}" };
                        dtvBasketShow.Rows.Add(TotalPrice);
                        total = 0;
                        counterProduct = 1;
                    }
                }
            }
        }

        public ShowBasketHistory()
        {
            InitializeComponent();
        }

        private void ShowBasketHistory_Load(object sender, EventArgs e)
        {

            dtvBasketShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvBasketShow.ColumnCount = 7;
            dtvBasketShow.Columns[0].Name = "Basket Id";
            dtvBasketShow.Columns[0].Visible = false;

            dtvBasketShow.Columns[1].Name = "Basket Number";
            dtvBasketShow.Columns[2].Name = "Order Name";
            dtvBasketShow.Columns[3].Name = "Order Price";
            dtvBasketShow.Columns[4].Name = "Product Station ";
            dtvBasketShow.Columns[5].Name = "Basket Station ";
            dtvBasketShow.Columns[6].Name = "Total Price";

            showbasket1();
        }

        private void linkprofile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile profile = new Profile();
            profile.UserId = this.UserId;
            profile.Show();
            this.Hide();
        }

        private void lblBaskets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtvBasketShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            showbasket1();

            dtvBasketShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var basketList = Convert.ToInt32(dtvBasketShow.CurrentRow.Cells[0].Value);

            using (BpDbContext dbContext = new BpDbContext())
            {
                var basketListDelete = dbContext.Baskets.FirstOrDefault(x => x.Id == basketList);

                basketListDelete.Status = (byte)BasketStatusEnum.NotOrdered;
                dbContext.SaveChanges();
                dtvBasketShow.Rows.Clear();
                showbasket1();


            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var row = dtvBasketShow.CurrentRow.Cells[0].Value;

            int selectedBaskettId = Convert.ToInt32(row);

            using (BpDbContext dbContext = new BpDbContext())
            {

                var basket = dbContext.Baskets.FirstOrDefault(x => x.Id == selectedBaskettId);
                basket.Status = (byte)BasketStatusEnum.Deleted;
                dbContext.SaveChanges();

                MessageBox.Show("Basket Deleted");
                showbasket1();



            }
        }
    }
}
