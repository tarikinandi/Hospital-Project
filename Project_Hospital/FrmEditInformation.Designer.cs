namespace Project_Hospital
{
    partial class FrmEditInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditInformation));
            this.BtnEditInformation = new System.Windows.Forms.Button();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskPhone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.TClabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEditInformation
            // 
            this.BtnEditInformation.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnEditInformation.Location = new System.Drawing.Point(182, 391);
            this.BtnEditInformation.Name = "BtnEditInformation";
            this.BtnEditInformation.Size = new System.Drawing.Size(129, 34);
            this.BtnEditInformation.TabIndex = 31;
            this.BtnEditInformation.Text = "Güncelle";
            this.BtnEditInformation.UseVisualStyleBackColor = false;
            this.BtnEditInformation.Click += new System.EventHandler(this.BtnEditInformation_Click);
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbGender.Location = new System.Drawing.Point(160, 336);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(151, 36);
            this.CmbGender.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Telefon :";
            // 
            // MskPhone
            // 
            this.MskPhone.Location = new System.Drawing.Point(160, 221);
            this.MskPhone.Mask = "(999) 000-0000";
            this.MskPhone.Name = "MskPhone";
            this.MskPhone.Size = new System.Drawing.Size(151, 36);
            this.MskPhone.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cinsiyet :";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(160, 99);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(151, 36);
            this.TxtSurname.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Soyad :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(160, 43);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(151, 36);
            this.TxtName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad :";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(160, 278);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(151, 36);
            this.TxtPassword.TabIndex = 22;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(160, 158);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(151, 36);
            this.MskTC.TabIndex = 21;
            // 
            // SifreLabel
            // 
            this.SifreLabel.AutoSize = true;
            this.SifreLabel.Location = new System.Drawing.Point(80, 281);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(72, 28);
            this.SifreLabel.TabIndex = 20;
            this.SifreLabel.Text = "Şifre : ";
            // 
            // TClabel
            // 
            this.TClabel.AutoSize = true;
            this.TClabel.Location = new System.Drawing.Point(13, 161);
            this.TClabel.Name = "TClabel";
            this.TClabel.Size = new System.Drawing.Size(146, 28);
            this.TClabel.TabIndex = 19;
            this.TClabel.Text = "TC Kimlik No :";
            // 
            // FrmEditInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(368, 461);
            this.Controls.Add(this.BtnEditInformation);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.TClabel);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmEditInformation";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmEditInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEditInformation;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.Label TClabel;
    }
}