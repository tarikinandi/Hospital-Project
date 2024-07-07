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
    public partial class FrmDoctorEditInformation : Form
    {
        public FrmDoctorEditInformation()
        {
            InitializeComponent();
        }

        connection conn = new connection();
        public string tc;
        private void BtnEditInformation_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_doctors set doctorname=@p1 , doctorsurname=@p2 , doctorbranch=@p3 , doctorpassword=@p4 where doctortc = '" + MskTC.Text + "'",conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1" , TxtName.Text);
            cmd.Parameters.AddWithValue("@p2" , TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3" , CmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4" , TxtPassword.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
        }

        private void FrmDoctorEditInformation_Load(object sender, EventArgs e)
        {
            MskTC.Text = tc;

            SqlCommand cmd = new SqlCommand("select * from tbl_doctors where doctortc = '" + MskTC.Text + "'" , conn.sqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                CmbBranch.Text = dr[3].ToString();
                TxtPassword.Text = dr[5].ToString();
            }
            conn.sqlConnection().Close();
            


        }
    }
}
