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
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        connection conn = new connection();
        private void BtnSignup_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Patients (PatientName , PatientSurname , PatientTC , PatientPhone , PatientPassword , PatientGender)" +
                "values (@p1 , @p2 , @p3 , @p4 , @p5 , @p6)", conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1" , TxtName.Text);
            cmd.Parameters.AddWithValue("@p2" , TxtSurname.Text);  
            cmd.Parameters.AddWithValue("@p3" , MskTC.Text);
            cmd.Parameters.AddWithValue("@p4" , MskPhone.Text);
            cmd.Parameters.AddWithValue("@p5" , TxtPassword.Text);
            cmd.Parameters.AddWithValue("@p6", CmbGender.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir. Şifreniz : " + TxtPassword.Text , "Bilgi" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
