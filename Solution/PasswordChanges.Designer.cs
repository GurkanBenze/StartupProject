namespace BaslangicProjesi.Solution
{
    partial class PasswordChanges
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblyenisifre1 = new System.Windows.Forms.Label();
            this.lblyenisifre2 = new System.Windows.Forms.Label();
            this.lbleskisifre = new System.Windows.Forms.Label();
            this.linkprofiledön = new System.Windows.Forms.LinkLabel();
            this.btnPasswordChange = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPassSecond = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(83, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 59);
            this.label1.TabIndex = 17;
            this.label1.Text = "Password Changes";
            // 
            // lblyenisifre1
            // 
            this.lblyenisifre1.AutoSize = true;
            this.lblyenisifre1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblyenisifre1.Location = new System.Drawing.Point(24, 209);
            this.lblyenisifre1.Name = "lblyenisifre1";
            this.lblyenisifre1.Size = new System.Drawing.Size(111, 35);
            this.lblyenisifre1.TabIndex = 16;
            this.lblyenisifre1.Text = "New Password";
            // 
            // lblyenisifre2
            // 
            this.lblyenisifre2.AutoSize = true;
            this.lblyenisifre2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblyenisifre2.Location = new System.Drawing.Point(24, 260);
            this.lblyenisifre2.Name = "lblyenisifre2";
            this.lblyenisifre2.Size = new System.Drawing.Size(155, 35);
            this.lblyenisifre2.TabIndex = 15;
            this.lblyenisifre2.Text = "New Password Again";
            // 
            // lbleskisifre
            // 
            this.lbleskisifre.AutoSize = true;
            this.lbleskisifre.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbleskisifre.Location = new System.Drawing.Point(24, 150);
            this.lbleskisifre.Name = "lbleskisifre";
            this.lbleskisifre.Size = new System.Drawing.Size(108, 35);
            this.lbleskisifre.TabIndex = 14;
            this.lbleskisifre.Text = "Old Password";
            // 
            // linkprofiledön
            // 
            this.linkprofiledön.AutoSize = true;
            this.linkprofiledön.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.linkprofiledön.Location = new System.Drawing.Point(33, 346);
            this.linkprofiledön.Name = "linkprofiledön";
            this.linkprofiledön.Size = new System.Drawing.Size(130, 35);
            this.linkprofiledön.TabIndex = 13;
            this.linkprofiledön.TabStop = true;
            this.linkprofiledön.Text = "Return to Profile";
            this.linkprofiledön.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkprofiledön_LinkClicked);
            // 
            // btnPasswordChange
            // 
            this.btnPasswordChange.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPasswordChange.Location = new System.Drawing.Point(203, 355);
            this.btnPasswordChange.Name = "btnPasswordChange";
            this.btnPasswordChange.Size = new System.Drawing.Size(187, 39);
            this.btnPasswordChange.TabIndex = 12;
            this.btnPasswordChange.Text = "Password Change";
            this.btnPasswordChange.UseVisualStyleBackColor = true;
            this.btnPasswordChange.Click += new System.EventHandler(this.btnPasswordChange_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNewPass.Location = new System.Drawing.Point(203, 204);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(188, 40);
            this.txtNewPass.TabIndex = 11;
            // 
            // txtNewPassSecond
            // 
            this.txtNewPassSecond.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNewPassSecond.Location = new System.Drawing.Point(204, 260);
            this.txtNewPassSecond.Name = "txtNewPassSecond";
            this.txtNewPassSecond.Size = new System.Drawing.Size(188, 40);
            this.txtNewPassSecond.TabIndex = 10;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtOldPass.Location = new System.Drawing.Point(203, 150);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(188, 40);
            this.txtOldPass.TabIndex = 9;
            // 
            // PasswordChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblyenisifre1);
            this.Controls.Add(this.lblyenisifre2);
            this.Controls.Add(this.lbleskisifre);
            this.Controls.Add(this.linkprofiledön);
            this.Controls.Add(this.btnPasswordChange);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtNewPassSecond);
            this.Controls.Add(this.txtOldPass);
            this.Name = "PasswordChanges";
            this.Text = "PasswordChanges";
            this.Load += new System.EventHandler(this.PasswordChanges_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblyenisifre1;
        private System.Windows.Forms.Label lblyenisifre2;
        private System.Windows.Forms.Label lbleskisifre;
        private System.Windows.Forms.LinkLabel linkprofiledön;
        private System.Windows.Forms.Button btnPasswordChange;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewPassSecond;
        private System.Windows.Forms.TextBox txtOldPass;
    }
}