namespace BaslangicProjesi.Solution
{
    partial class Profile
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
            this.linkBasketHistory = new System.Windows.Forms.LinkLabel();
            this.linkAddBalance = new System.Windows.Forms.LinkLabel();
            this.linkMailChange = new System.Windows.Forms.LinkLabel();
            this.linkPasschan = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductOrder = new System.Windows.Forms.LinkLabel();
            this.lbladminPage = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkBasketHistory
            // 
            this.linkBasketHistory.AutoSize = true;
            this.linkBasketHistory.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkBasketHistory.Location = new System.Drawing.Point(54, 187);
            this.linkBasketHistory.Name = "linkBasketHistory";
            this.linkBasketHistory.Size = new System.Drawing.Size(179, 40);
            this.linkBasketHistory.TabIndex = 9;
            this.linkBasketHistory.TabStop = true;
            this.linkBasketHistory.Text = "Show Basket Historty";
            this.linkBasketHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBasketHistory_LinkClicked);
            // 
            // linkAddBalance
            // 
            this.linkAddBalance.AutoSize = true;
            this.linkAddBalance.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkAddBalance.Location = new System.Drawing.Point(54, 151);
            this.linkAddBalance.Name = "linkAddBalance";
            this.linkAddBalance.Size = new System.Drawing.Size(114, 40);
            this.linkAddBalance.TabIndex = 8;
            this.linkAddBalance.TabStop = true;
            this.linkAddBalance.Text = "Add Balance";
            this.linkAddBalance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddBalance_LinkClicked);
            // 
            // linkMailChange
            // 
            this.linkMailChange.AutoSize = true;
            this.linkMailChange.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkMailChange.Location = new System.Drawing.Point(54, 116);
            this.linkMailChange.Name = "linkMailChange";
            this.linkMailChange.Size = new System.Drawing.Size(121, 40);
            this.linkMailChange.TabIndex = 7;
            this.linkMailChange.TabStop = true;
            this.linkMailChange.Text = "Mail Changes";
            this.linkMailChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMailChange_LinkClicked);
            // 
            // linkPasschan
            // 
            this.linkPasschan.AutoSize = true;
            this.linkPasschan.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkPasschan.Location = new System.Drawing.Point(54, 81);
            this.linkPasschan.Name = "linkPasschan";
            this.linkPasschan.Size = new System.Drawing.Size(157, 40);
            this.linkPasschan.TabIndex = 6;
            this.linkPasschan.TabStop = true;
            this.linkPasschan.Text = "Password Changes";
            this.linkPasschan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPasschan_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "PROFİL";
            // 
            // lblProductOrder
            // 
            this.lblProductOrder.AutoSize = true;
            this.lblProductOrder.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblProductOrder.Location = new System.Drawing.Point(2, 290);
            this.lblProductOrder.Name = "lblProductOrder";
            this.lblProductOrder.Size = new System.Drawing.Size(208, 35);
            this.lblProductOrder.TabIndex = 10;
            this.lblProductOrder.TabStop = true;
            this.lblProductOrder.Text = "Back to Product Order Page ";
            this.lblProductOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbladminPage
            // 
            this.lbladminPage.AutoSize = true;
            this.lbladminPage.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbladminPage.Location = new System.Drawing.Point(2, 325);
            this.lbladminPage.Name = "lbladminPage";
            this.lbladminPage.Size = new System.Drawing.Size(158, 35);
            this.lbladminPage.TabIndex = 11;
            this.lbladminPage.TabStop = true;
            this.lbladminPage.Text = "Back to  Admin Page ";
            this.lbladminPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbladminPage_LinkClicked);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 380);
            this.Controls.Add(this.lbladminPage);
            this.Controls.Add(this.lblProductOrder);
            this.Controls.Add(this.linkBasketHistory);
            this.Controls.Add(this.linkAddBalance);
            this.Controls.Add(this.linkMailChange);
            this.Controls.Add(this.linkPasschan);
            this.Controls.Add(this.label1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkBasketHistory;
        private System.Windows.Forms.LinkLabel linkAddBalance;
        private System.Windows.Forms.LinkLabel linkMailChange;
        private System.Windows.Forms.LinkLabel linkPasschan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblProductOrder;
        private System.Windows.Forms.LinkLabel lbladminPage;
    }
}