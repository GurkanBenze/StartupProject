namespace BaslangicProjesi.Solution
{
    partial class DeletedProduct
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
            this.btnDeletedProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblBackHome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(61, 32);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.Size = new System.Drawing.Size(788, 372);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // btnDeletedProduct
            // 
            this.btnDeletedProduct.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletedProduct.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeletedProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletedProduct.Location = new System.Drawing.Point(625, 444);
            this.btnDeletedProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletedProduct.Name = "btnDeletedProduct";
            this.btnDeletedProduct.Size = new System.Drawing.Size(224, 60);
            this.btnDeletedProduct.TabIndex = 11;
            this.btnDeletedProduct.Text = "Deleted Product";
            this.btnDeletedProduct.UseVisualStyleBackColor = false;
            this.btnDeletedProduct.Click += new System.EventHandler(this.btnDeletedProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAddProduct.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(370, 444);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(224, 60);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Go to Product Add PAge";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblBackHome
            // 
            this.lblBackHome.AutoSize = true;
            this.lblBackHome.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBackHome.LinkColor = System.Drawing.Color.Blue;
            this.lblBackHome.Location = new System.Drawing.Point(13, 496);
            this.lblBackHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackHome.Name = "lblBackHome";
            this.lblBackHome.Size = new System.Drawing.Size(189, 45);
            this.lblBackHome.TabIndex = 23;
            this.lblBackHome.TabStop = true;
            this.lblBackHome.Text = "Back To Admin Page";
            this.lblBackHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBackHome_LinkClicked);
            // 
            // DeletedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(918, 550);
            this.Controls.Add(this.lblBackHome);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnDeletedProduct);
            this.Controls.Add(this.dgvProduct);
            this.Name = "DeletedProduct";
            this.Text = "DeletedProduct";
            this.Load += new System.EventHandler(this.DeletedProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnDeletedProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.LinkLabel lblBackHome;
    }
}