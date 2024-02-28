namespace BaslangicProjesi.Solution
{
    partial class AddBalance
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
            this.btnAddBalance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkprofile
            // 
            this.linkprofile.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkprofile.AutoSize = true;
            this.linkprofile.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.linkprofile.Location = new System.Drawing.Point(16, 275);
            this.linkprofile.Name = "linkprofile";
            this.linkprofile.Size = new System.Drawing.Size(60, 35);
            this.linkprofile.TabIndex = 13;
            this.linkprofile.TabStop = true;
            this.linkprofile.Text = "Profile";
            this.linkprofile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkprofile_LinkClicked);
            // 
            // btnAddBalance
            // 
            this.btnAddBalance.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddBalance.Location = new System.Drawing.Point(176, 243);
            this.btnAddBalance.Name = "btnAddBalance";
            this.btnAddBalance.Size = new System.Drawing.Size(142, 50);
            this.btnAddBalance.TabIndex = 12;
            this.btnAddBalance.Text = "Add Balance";
            this.btnAddBalance.UseVisualStyleBackColor = true;
            this.btnAddBalance.Click += new System.EventHandler(this.btnAddBalance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(118, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 59);
            this.label3.TabIndex = 11;
            this.label3.Text = "Add Balance";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(175, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 40);
            this.txtPassword.TabIndex = 10;
            // 
            // txtbalance
            // 
            this.txtbalance.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtbalance.Location = new System.Drawing.Point(176, 124);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(143, 40);
            this.txtbalance.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(61, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Balance";
            // 
            // AddBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 353);
            this.Controls.Add(this.linkprofile);
            this.Controls.Add(this.btnAddBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBalance";
            this.Text = "AddBalance";
            this.Load += new System.EventHandler(this.AddBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkprofile;
        private System.Windows.Forms.Button btnAddBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}