namespace Project_Hospital
{
    partial class FrmPatientLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.TClabel = new System.Windows.Forms.Label();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LnkSignup = new System.Windows.Forms.LinkLabel();
            this.BtnSignin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // TClabel
            // 
            this.TClabel.AutoSize = true;
            this.TClabel.Location = new System.Drawing.Point(53, 125);
            this.TClabel.Name = "TClabel";
            this.TClabel.Size = new System.Drawing.Size(129, 24);
            this.TClabel.TabIndex = 1;
            this.TClabel.Text = "TC Kimlik No :";
            // 
            // SifreLabel
            // 
            this.SifreLabel.AutoSize = true;
            this.SifreLabel.Location = new System.Drawing.Point(120, 178);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(62, 24);
            this.SifreLabel.TabIndex = 2;
            this.SifreLabel.Text = "Şifre : ";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(200, 122);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(151, 32);
            this.MskTC.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(200, 175);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(151, 32);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LnkSignup
            // 
            this.LnkSignup.AutoSize = true;
            this.LnkSignup.Location = new System.Drawing.Point(368, 183);
            this.LnkSignup.Name = "LnkSignup";
            this.LnkSignup.Size = new System.Drawing.Size(66, 24);
            this.LnkSignup.TabIndex = 5;
            this.LnkSignup.TabStop = true;
            this.LnkSignup.Text = "Üye Ol";
            this.LnkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSignup_LinkClicked);
            // 
            // BtnSignin
            // 
            this.BtnSignin.Location = new System.Drawing.Point(250, 228);
            this.BtnSignin.Name = "BtnSignin";
            this.BtnSignin.Size = new System.Drawing.Size(101, 37);
            this.BtnSignin.TabIndex = 6;
            this.BtnSignin.Text = "Giriş Yap";
            this.BtnSignin.UseVisualStyleBackColor = true;
            this.BtnSignin.Click += new System.EventHandler(this.BtnSignin_Click);
            // 
            // FrmPatientLogin
            // 
            this.AcceptButton = this.BtnSignin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(519, 314);
            this.Controls.Add(this.BtnSignin);
            this.Controls.Add(this.LnkSignup);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.TClabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmPatientLogin";
            this.Text = "Hasta Giriş ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TClabel;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.LinkLabel LnkSignup;
        private System.Windows.Forms.Button BtnSignin;
    }
}