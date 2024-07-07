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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }
        connection conn = new connection(); 
        private void BtnSignin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_secretary  where secretaryTC = @p1 and secretarypassword = @p2" , conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1" ,MskTC.Text );
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) { 
                FrmSecretaryDetail frs = new FrmSecretaryDetail();
                frs.tc = MskTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc & Şifre" , "Uyarı" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.sqlConnection().Close();
        }
    }
}
