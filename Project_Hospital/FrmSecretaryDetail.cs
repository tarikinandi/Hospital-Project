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
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }

        public string tc;
        connection conn = new connection();

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        { 
            LblTC.Text = tc;
           
            //Name and surname
            SqlCommand cmd = new SqlCommand("Select secretarynamesurname from tbl_secretary where secretarytc ='" + MskTC.Text + "'" , conn.sqlConnection());
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read()) { 
                LblNameSurname.Text = dr1[0].ToString(); 
            }
            conn.sqlConnection().Close();

            //Transfer branches to datagrid1
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_branch" , conn.sqlConnection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Transfer doctors to datagrid2
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (doctorname + ' ' + doctorsurname) as Doctors , doctorbranch from tbl_doctors" , conn.sqlConnection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Bringing the branch to combobox
            SqlCommand cmd2 = new SqlCommand("select branchname from tbl_branch" , conn.sqlConnection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBranch.Items.Add(dr2[0].ToString());
            }

            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_appointments (apdate , apclock , apbranch , apdoctor) values (@r1 , @r2 , @r3 , @r4)",conn.sqlConnection());
            cmd.Parameters.AddWithValue("@r1", MskDate.Text);
            cmd.Parameters.AddWithValue("@r2", MskClock.Text);
            cmd.Parameters.AddWithValue("@r3", CmbBranch.Text);
            cmd.Parameters.AddWithValue("@r4", CmbDoctor.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
            MessageBox.Show("Randevu Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            SqlCommand cmd = new SqlCommand("select doctorname , doctorsurname from tbl_doctors where doctorbranch = '"+ CmbBranch.Text + "'",  conn.sqlConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbDoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            conn.sqlConnection().Close();   
        }

        private void BtnAnnouncementsCreate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into  Tbl_Announcements (Announcement) values (@d1)" , conn.sqlConnection());
            cmd.Parameters.AddWithValue("@d1" , RchAnnouncements.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
            MessageBox.Show("Duyuru oluşturuldu." , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information);

        }

        private void BtnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel frd = new FrmDoctorPanel();
            frd.Show();
            
        }

        private void BtnBranchPanel_Click(object sender, EventArgs e)
        {
            FrmBranch frb = new FrmBranch();
            frb.Show();
        }

        private void BtnAppointmentList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList fra = new FrmAppointmentList();
            fra.Show();
        }

        private void BtnAnnouncement_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fra = new FrmAnnouncements();
            fra.Show(); 
        }
    }
}
