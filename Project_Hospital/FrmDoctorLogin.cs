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
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }
        connection conn = new connection();
        private void BtnSignin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_doctors  where doctortc=@p1 and doctorpassword = @p2", conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) {
                FrmDoctorDetail frd = new FrmDoctorDetail();
                frd.tc = MskTC.Text;
                frd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış TC & Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.sqlConnection().Close();
            
        }
    }
}
