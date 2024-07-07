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
    public partial class FrmBranch : Form
    {
        public FrmBranch()
        {
            InitializeComponent();
        }
        
        connection conn = new connection();

        private void FrmBranch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_branch" , conn.sqlConnection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_branch (branchname) values (@p1)" , conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1" , TxtName.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
            MessageBox.Show("Branş Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from tbl_branch where branchname = '" + TxtName.Text + "'" , conn.sqlConnection());
            cmd.ExecuteNonQuery ();
            conn.sqlConnection().Close();
            MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_branch set branchname=@p1");
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.ExecuteNonQuery ();
            conn.sqlConnection().Close();
            MessageBox.Show("Branş Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int value = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[value].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[value].Cells[1].Value.ToString();

        }
    }
}
