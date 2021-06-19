using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCSUAS
{
    public partial class MasterModel : Form
    {
        SqlConnection conn;
        public MasterModel()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                String query = $"SELECT MODEL_ID, DESCRIPTION " +
                               $"FROM m_model";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
                throw;
            }
        }

        private bool cekKosong()
        {
            if (tbModelDesc.Text.Length == 0)
            {
                MessageBox.Show("Isi Data Dengan Benar!");
                return false;
            }
            return true;
        }

        private bool cekKosongCari()
        {
            if (rbDesc.Checked)
            {
                if (tbDescCari.Text.Length == 0)
                {
                    MessageBox.Show("Isi Data Dengan Benar!");
                    return false;
                }
                return true;
            }
            else
            {
                if (tbModelIDCari.Text.Length == 0)
                {
                    MessageBox.Show("Isi Data Dengan Benar!");
                    return false;
                }
                return true;
            }
        }

        private void refreshData()
        {
            conn.Open();
            DataSet ds = new DataSet();
            String query2 = $"SELECT MODEL_ID, DESCRIPTION " +
                           $"FROM m_model";
            SqlCommand cmd = new SqlCommand(query2, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pictInsert.Enabled = false;
            pictUpdate.Enabled = true;
            pictDelete.Enabled = true;

            tbModelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbModelDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {

            tbDescCari.Enabled = false;
            tbModelIDCari.Enabled = true;
            tbDescCari.Text = "";
        }

        private void Description_MouseClick(object sender, MouseEventArgs e)
        {
            tbDescCari.Enabled = true;
            tbModelIDCari.Enabled = false;
            tbModelIDCari.Text = "";
        }

        private void MasterModel_Load(object sender, EventArgs e)
        {

        }

        private void rbModel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        

        private void pictInsert_Click(object sender, EventArgs e)
        {

            if (cekKosong())
            {
                conn.Open();
                String desc = tbModelDesc.Text;

                String count = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                              $"FROM m_model mdl " +
                              $"WHERE DESCRIPTION = '{desc}'";
                SqlCommand comm = new SqlCommand(count, conn);
                int jmlh = Convert.ToInt32(comm.ExecuteScalar().ToString());
                conn.Close();
                if (jmlh == 0)
                {
                    conn.Open();
                    String query = $"Insert into m_model (DESCRIPTION) values('{desc}')";
                    comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    //CLEAR TEXTBO
                    tbModelDesc.Text = "";
                    //REFRESH DATA
                    refreshData();
                }
                else
                {
                    MessageBox.Show("ID Model atau Description sudah ada di database");
                }
            }
        }

        private void pictUpdate_Click(object sender, EventArgs e)
        {
            if (cekKosong())
            {
                conn.Open();
                String desc = tbModelDesc.Text;
                String count = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                              $"FROM m_model mdl " +
                              $"WHERE DESCRIPTION = '{desc}'";
                SqlCommand comm = new SqlCommand(count, conn);
                int jmlh = Convert.ToInt32(comm.ExecuteScalar().ToString());
                conn.Close();
                if (jmlh == 0)
                {
                    conn.Open();
                    String query = $"update m_model set DESCRIPTION = '{desc}' where MODEL_ID= {tbModelID.Text}";
                    SqlCommand comm2 = new SqlCommand(query, conn);
                    comm2.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Update!");
                    conn.Close();

                    tbModelID.Text = "";
                    tbModelDesc.Text = "";
                    pictInsert.Enabled = true;
                    pictUpdate.Enabled = false;
                    pictDelete.Enabled = false;

                    //REFRESH DATA
                    refreshData();
                }
                else
                {
                    MessageBox.Show("ID Model atau Description sudah ada di database");
                }
            }
        }

        private void pictDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                conn.Open();
                int id = Convert.ToInt32(tbModelID.Text);
                String query = $"delete from m_model where MODEL_ID like {id}";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menghapus");
                conn.Close();

                tbModelID.Text = "";
                tbModelDesc.Text = "";
                pictInsert.Enabled = true;
                pictUpdate.Enabled = false;
                pictDelete.Enabled = false;

                //REFRESH DATA
                refreshData();
            }
        }

        private void pictSearch_Click(object sender, EventArgs e)
        {
            if (rbDesc.Checked)
            {
                conn.Open();
                DataSet ds = new DataSet();
                String query = $"SELECT *" +
                              $"FROM m_model mdl " +
                              $"WHERE DESCRIPTION like '%{tbDescCari.Text}%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();

            }
            else
            {
                conn.Open();
                DataSet ds = new DataSet();
                String query = $"SELECT *" +
                              $"FROM m_model mdl " +
                              $"WHERE model_id like '%{tbModelIDCari.Text}%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();

            }
        }

        private void pictPrint_Click(object sender, EventArgs e)
        {
            ReportViewerMasterModel rp = new ReportViewerMasterModel();
            rp.Show();
        }

        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            tbModelIDCari.Enabled = false;
            tbDescCari.Enabled = true;
        }

        private void rbModel_CheckedChanged(object sender, EventArgs e)
        {
            tbModelIDCari.Enabled = true;
            tbDescCari.Enabled = false;
        }
    }
}
