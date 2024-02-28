namespace BaslangicProjesi.Solution
{
    partial class MailChanges
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
            this.linkProfile = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNewMail = new System.Windows.Forms.TextBox();
            this.txtOldMail = new System.Windows.Forms.TextBox();
            this.btnMailDegistir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkProfile
            // 
            this.linkProfile.AutoSize = true;
            this.linkProfile.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.linkProfile.Location = new System.Drawing.Point(32, 370);
            this.linkProfile.Name = "linkProfile";
            this.linkProfile.Size = new System.Drawing.Size(53, 35);
            this.linkProfile.TabIndex = 17;
            this.linkProfile.TabStop = true;
            this.linkProfile.Text = "Profil";
            this.linkProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProfile_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(89, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 59);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mail Changes";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPass.Location = new System.Drawing.Point(196, 245);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(173, 40);
            this.txtPass.TabIndex = 15;
            // 
            // txtNewMail
            // 
            this.txtNewMail.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNewMail.Location = new System.Drawing.Point(196, 199);
            this.txtNewMail.Name = "txtNewMail";
            this.txtNewMail.Size = new System.Drawing.Size(173, 40);
            this.txtNewMail.TabIndex = 14;
            // 
            // txtOldMail
            // 
            this.txtOldMail.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtOldMail.Location = new System.Drawing.Point(196, 153);
            this.txtOldMail.Name = "txtOldMail";
            this.txtOldMail.Size = new System.Drawing.Size(173, 40);
            this.txtOldMail.TabIndex = 13;
            // 
            // btnMailDegistir
            // 
            this.btnMailDegistir.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMailDegistir.Location = new System.Drawing.Point(196, 298);
            this.btnMailDegistir.Name = "btnMailDegistir";
            this.btnMailDegistir.Size = new System.Drawing.Size(173, 46);
            this.btnMailDegistir.TabIndex = 12;
            this.btnMailDegistir.Text = "Mail Changes";
            this.btnMailDegistir.UseVisualStyleBackColor = true;
            this.btnMailDegistir.Click += new System.EventHandler(this.btnMailDegistir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(62, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(62, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Old Mail";
            // 
            // MailChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.linkProfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNewMail);
            this.Controls.Add(this.txtOldMail);
            this.Controls.Add(this.btnMailDegistir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MailChanges";
            this.Text = "MailChanges";
            this.Load += new System.EventHandler(this.MailChanges_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNewMail;
        private System.Windows.Forms.TextBox txtOldMail;
        private System.Windows.Forms.Button btnMailDegistir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}