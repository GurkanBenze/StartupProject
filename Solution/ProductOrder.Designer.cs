namespace BaslangicProjesi.Solution
{
    partial class ProductOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.dgvBasketProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBackHome = new System.Windows.Forms.LinkLabel();
            this.btnConfirmBasket = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasketProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(13, 199);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.Size = new System.Drawing.Size(601, 492);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProductAdd.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnProductAdd.Location = new System.Drawing.Point(16, 697);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(221, 57);
            this.btnProductAdd.TabIndex = 1;
            this.btnProductAdd.Text = "Add Basket to Product";
            this.btnProductAdd.UseVisualStyleBackColor = false;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProfile.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnProfile.Location = new System.Drawing.Point(1233, 26);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(145, 54);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // dgvBasketProduct
            // 
            this.dgvBasketProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasketProduct.Location = new System.Drawing.Point(777, 199);
            this.dgvBasketProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBasketProduct.Name = "dgvBasketProduct";
            this.dgvBasketProduct.RowHeadersWidth = 51;
            this.dgvBasketProduct.Size = new System.Drawing.Size(601, 492);
            this.dgvBasketProduct.TabIndex = 7;
            this.dgvBasketProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBasketProduct_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 74);
            this.label1.TabIndex = 8;
            this.label1.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(777, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 74);
            this.label2.TabIndex = 9;
            this.label2.Text = "Basket";
            // 
            // lblBackHome
            // 
            this.lblBackHome.AutoSize = true;
            this.lblBackHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBackHome.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBackHome.LinkColor = System.Drawing.Color.Blue;
            this.lblBackHome.Location = new System.Drawing.Point(16, 11);
            this.lblBackHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackHome.Name = "lblBackHome";
            this.lblBackHome.Size = new System.Drawing.Size(189, 45);
            this.lblBackHome.TabIndex = 28;
            this.lblBackHome.TabStop = true;
            this.lblBackHome.Text = "Back To Admin Page";
            this.lblBackHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBackHome_LinkClicked);
            // 
            // btnConfirmBasket
            // 
            this.btnConfirmBasket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmBasket.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmBasket.Location = new System.Drawing.Point(1233, 699);
            this.btnConfirmBasket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmBasket.Name = "btnConfirmBasket";
            this.btnConfirmBasket.Size = new System.Drawing.Size(145, 57);
            this.btnConfirmBasket.TabIndex = 29;
            this.btnConfirmBasket.Text = "Confirm";
            this.btnConfirmBasket.UseVisualStyleBackColor = false;
            this.btnConfirmBasket.Click += new System.EventHandler(this.btnConfirmBasket_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProduct.Location = new System.Drawing.Point(1080, 699);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(145, 57);
            this.btnDeleteProduct.TabIndex = 31;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // ProductOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BaslangicProjesi.Properties.Resources.ecommerce_product_page_tips;
            this.ClientSize = new System.Drawing.Size(1396, 768);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnConfirmBasket);
            this.Controls.Add(this.lblBackHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBasketProduct);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.dgvProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductOrder";
            this.Text = "ProductOrder";
            this.Load += new System.EventHandler(this.ProductOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasketProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.DataGridView dgvBasketProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblBackHome;
        private System.Windows.Forms.Button btnConfirmBasket;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}