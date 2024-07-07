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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        public string tc;
        connection conn = new connection();
        

        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            //Name surname load
            SqlCommand cmd = new SqlCommand("Select PatientName , PatientSurname From Tbl_Patients where PatientTC=@p1", conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1" , tc);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read()) {
                LblNameSurname.Text = rd[0] +" "+ rd[1];
            }
            conn.sqlConnection().Close();

            //Appointment History
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where PatientTC ='" + tc +"'" , conn.sqlConnection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branch Load
            SqlCommand cmd1 = new SqlCommand("Select BranchName From Tbl_Branch" , conn.sqlConnection());
            SqlDataReader rd1 = cmd1.ExecuteReader();
            while (rd1.Read()) { 
                CmbBranch.Items.Add(rd1[0]);
            }
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select DoctorName , DoctorSurname from Tbl_Doctors where DoctorBranch= @p1", conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1" , CmbBranch.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read()) { 
                CmbDoctor.Items.Add(rd[0] + " " + rd[1]);
            }
            conn.sqlConnection().Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RchComplaint_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEditInformation fre = new FrmEditInformation();
            fre.tc = LblTC.Text;
            fre.Show();

        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_appointments set apstatus =1 , patienttc = @p1 , PatientComplaint=@p2 where ApId = @p3", conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1" , LblTC.Text);
            cmd.Parameters.AddWithValue("@p2" , RchComplaint.Text);
            cmd.Parameters.AddWithValue("@p3" , TxtId.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
            MessageBox.Show("Randevu Alındı." , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information);

        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where ApBranch = '" + CmbBranch.Text + "'" +
                "and ApDoctor = '" + CmbDoctor.Text + "' " +
                "and ApStatus=0", conn.sqlConnection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int value = dataGridView2.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView2.Rows[value].Cells[0].Value.ToString();

        }
    }
}
