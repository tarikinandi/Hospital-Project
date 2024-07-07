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
    public partial class FrmDoctorDetail : Form
    {
        public FrmDoctorDetail()
        {
            InitializeComponent();
        }

        connection conn = new connection();
        public string tc;
        private void BtnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fra = new FrmAnnouncements();
            fra.Show();
        }

        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            //Name surname load
            SqlCommand cmd1 = new SqlCommand("Select doctorname , doctorsurname from tbl_doctors where doctortc = '" + tc + "'", conn.sqlConnection());
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read()) { 
                LblNameSurname.Text = dr1[0] + " " + dr1[1];
            }
            conn.sqlConnection().Close();

            //Appointment List
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_appointments where apdoctor = '" + LblNameSurname.Text + "'" , conn.sqlConnection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmDoctorEditInformation fre = new FrmDoctorEditInformation();
            fre.tc = tc;
            fre.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int value = dataGridView1.SelectedCells[0].RowIndex;
            RchComplaint.Text = dataGridView1.Rows[value].Cells[7].Value.ToString();
        }
    }
}
