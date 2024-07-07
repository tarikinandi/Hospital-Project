using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Hospital
{
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        connection conn = new connection();
        private void LnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp fr = new FrmSignUp();
            fr.Show();
            
        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Patients where PatientTC=@p1 and PatientPassword=@p2" , conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) { 
                FrmPatientDetail frd = new FrmPatientDetail();
                frd.tc = MskTC.Text;
                frd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre girdiniz" , "Bilgi" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.sqlConnection().Close();
        }
    }
}
