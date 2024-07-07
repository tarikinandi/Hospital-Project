namespace Project_Hospital
{
    partial class FrmDoctorEditInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorEditInformation));
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.TClabel = new System.Windows.Forms.Label();
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEditInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(154, 93);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(151, 32);
            this.TxtSurname.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyad :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(154, 37);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(151, 32);
            this.TxtName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad :";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(154, 256);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(151, 32);
            this.TxtPassword.TabIndex = 21;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(154, 152);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(151, 32);
            this.MskTC.TabIndex = 20;
            // 
            // SifreLabel
            // 
            this.SifreLabel.AutoSize = true;
            this.SifreLabel.Location = new System.Drawing.Point(79, 259);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(62, 24);
            this.SifreLabel.TabIndex = 19;
            this.SifreLabel.Text = "Şifre : ";
            // 
            // TClabel
            // 
            this.TClabel.AutoSize = true;
            this.TClabel.Location = new System.Drawing.Point(7, 155);
            this.TClabel.Name = "TClabel";
            this.TClabel.Size = new System.Drawing.Size(129, 24);
            this.TClabel.TabIndex = 18;
            this.TClabel.Text = "TC Kimlik No :";
            // 
            // CmbBranch
            // 
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Location = new System.Drawing.Point(154, 204);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(151, 32);
            this.CmbBranch.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Branş :";
            // 
            // BtnEditInformation
            // 
            this.BtnEditInformation.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnEditInformation.Location = new System.Drawing.Point(176, 310);
            this.BtnEditInformation.Name = "BtnEditInformation";
            this.BtnEditInformation.Size = new System.Drawing.Size(129, 34);
            this.BtnEditInformation.TabIndex = 32;
            this.BtnEditInformation.Text = "Güncelle";
            this.BtnEditInformation.UseVisualStyleBackColor = false;
            this.BtnEditInformation.Click += new System.EventHandler(this.BtnEditInformation_Click);
            // 
            // FrmDoctorEditInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(389, 356);
            this.Controls.Add(this.BtnEditInformation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbBranch);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.TClabel);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDoctorEditInformation";
            this.Text = "Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmDoctorEditInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.Label TClabel;
        private System.Windows.Forms.ComboBox CmbBranch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEditInformation;
    }
}