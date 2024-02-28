namespace BaslangicProjesi.Solution
{
    partial class ShowBasketHistory
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
            this.linkprofile = new System.Windows.Forms.LinkLabel();
            this.dtvBasketShow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvBasketShow)).BeginInit();
            this.SuspendLayout();
            // 
            // linkprofile
            // 
            this.linkprofile.AutoSize = true;
            this.linkprofile.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkprofile.Location = new System.Drawing.Point(141, 693);
            this.linkprofile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkprofile.Name = "linkprofile";
            this.linkprofile.Size = new System.Drawing.Size(89, 55);
            this.linkprofile.TabIndex = 3;
            this.linkprofile.TabStop = true;
            this.linkprofile.Text = "Profile";
            this.linkprofile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkprofile_LinkClicked);
            // 
            // dtvBasketShow
            // 
            this.dtvBasketShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvBasketShow.Location = new System.Drawing.Point(140, 85);
            this.dtvBasketShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtvBasketShow.Name = "dtvBasketShow";
            this.dtvBasketShow.RowHeadersWidth = 51;
            this.dtvBasketShow.RowTemplate.Height = 24;
            this.dtvBasketShow.Size = new System.Drawing.Size(1417, 586);
            this.dtvBasketShow.TabIndex = 4;
            this.dtvBasketShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvBasketShow_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 74);
            this.label1.TabIndex = 5;
            this.label1.Text = "Basket History List";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreate.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(1233, 695);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(324, 53);
            this.btnCreate.TabIndex = 49;
            this.btnCreate.Text = "Customer Delete Basket";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ShowBasketHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvBasketShow);
            this.Controls.Add(this.linkprofile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowBasketHistory";
            this.Text = "ShowBasketHistory";
            this.Load += new System.EventHandler(this.ShowBasketHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvBasketShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkprofile;
        private System.Windows.Forms.DataGridView dtvBasketShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
    }
}