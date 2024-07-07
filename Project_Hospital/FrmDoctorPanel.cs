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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }

        connection conn = new connection();
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_doctors", conn.sqlConnection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Bringing the branch to combobox
            SqlCommand cmd2 = new SqlCommand("select branchname from tbl_branch", conn.sqlConnection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBranch.Items.Add(dr2[0].ToString());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into  Tbl_Doctors (doctorname , doctorsurname , doctorbranch , doctortc , doctorpassword)" +
                "values (@p1 , @p2 , @p3 , @p4 , @p5)",conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1" , TxtName.Text);
            cmd.Parameters.AddWithValue("@p2" , TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3" , CmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4" , MskTC.Text);
            cmd.Parameters.AddWithValue("@p5" , TxtPassword.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
            MessageBox.Show("Doktor Eklendi." , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int value = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[value].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[value].Cells[2].Value.ToString();
            CmbBranch.Text = dataGridView1.Rows[value].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[value].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[value].Cells[5].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from tbl_doctors where doctortc = @p1" , conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1" , MskTC.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
            MessageBox.Show("Doktor Silindi" , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Stop);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_doctors set doctorname=@p1 , doctorsurname=@p2 , doctorbranch=@p3 , doctortc=@p4 , doctorpassword=@p5",conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", CmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4", MskTC.Text);
            cmd.Parameters.AddWithValue("@p5", TxtPassword.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
            MessageBox.Show("Doktor Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
