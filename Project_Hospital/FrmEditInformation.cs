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
    public partial class FrmEditInformation : Form
    {
        public FrmEditInformation()
        {
            InitializeComponent();
        }

        public string tc;
        connection conn = new connection();
        private void FrmEditInformation_Load(object sender, EventArgs e)
        {
            MskTC.Text = tc;
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Patients where PatientTC='" + MskTC.Text + "'", conn.sqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                MskPhone.Text = dr[4].ToString();
                TxtPassword.Text = dr[5].ToString();
                CmbGender.Text = dr[6].ToString();

            }
            conn.sqlConnection().Close();
        }

        private void BtnEditInformation_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_patients set patientname = @p1 , patientsurname=@p2 , patientphone=@p3 ," +
                " patientpassword =@p4 , patientgender = @p5 where patientTc = '" + MskTC.Text + "'" , conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", MskPhone.Text);
            cmd.Parameters.AddWithValue("@p4", TxtPassword.Text);
            cmd.Parameters.AddWithValue("@p5", CmbGender.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
            MessageBox.Show("Kişi güncellendi" , "Bilgi" , MessageBoxButtons.OK, MessageBoxIcon.Information );

        }
    }
}
