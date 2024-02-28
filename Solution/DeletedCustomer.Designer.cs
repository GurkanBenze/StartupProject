namespace BaslangicProjesi.Solution
{
    partial class DeletedCustomer
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
            this.btnDeletedUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblBackHome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletedUser
            // 
            this.btnDeletedUser.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletedUser.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeletedUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletedUser.Location = new System.Drawing.Point(360, 259);
            this.btnDeletedUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeletedUser.Name = "btnDeletedUser";
            this.btnDeletedUser.Size = new System.Drawing.Size(168, 49);
            this.btnDeletedUser.TabIndex = 10;
            this.btnDeletedUser.Text = "Deleted User";
            this.btnDeletedUser.UseVisualStyleBackColor = false;
            this.btnDeletedUser.Click += new System.EventHandler(this.btnDeletedUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(33, 27);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(495, 213);
            this.dgvUsers.TabIndex = 9;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // lblBackHome
            // 
            this.lblBackHome.AutoSize = true;
            this.lblBackHome.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBackHome.LinkColor = System.Drawing.Color.Blue;
            this.lblBackHome.Location = new System.Drawing.Point(10, 322);
            this.lblBackHome.Name = "lblBackHome";
            this.lblBackHome.Size = new System.Drawing.Size(152, 35);
            this.lblBackHome.TabIndex = 22;
            this.lblBackHome.TabStop = true;
            this.lblBackHome.Text = "Back To Admin Page";
            this.lblBackHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBackHome_LinkClicked);
            // 
            // DeletedCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblBackHome);
            this.Controls.Add(this.btnDeletedUser);
            this.Controls.Add(this.dgvUsers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeletedCustomer";
            this.Text = "DeletedCustomer";
            this.Load += new System.EventHandler(this.DeletedCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletedUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.LinkLabel lblBackHome;
    }
}