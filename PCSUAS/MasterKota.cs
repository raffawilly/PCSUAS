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
    public partial class MasterKota : Form
    {
        SqlConnection conn;
        public MasterKota()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT *" +
                           $"FROM m_kota";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();


        }

        private bool cekKosong()
        {
            if (tbNamaKota.Text.Length == 0 )
            {
                MessageBox.Show("Isi Data Dengan Benar!");
                return false;
            }
            return true;
        }
        private void clear()
        {
            tbNamaKota.Text = "";
        }
        private void refreshData()
        {
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT namakota " +
                           $"FROM m_kota";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cekKosong())
            {
                conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
                conn.Open();
                String count = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                          $"FROM m_kota kota " +
                          $"WHERE namakota = '{tbNamaKota.Text}'";
                SqlCommand comm = new SqlCommand(count, conn);
                int jmlh = Convert.ToInt32(comm.ExecuteScalar().ToString());
                if (jmlh == 0)
                {
                    String query = $"Insert into m_kota  values('{tbNamaKota.Text}')";
                    comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Validate();

                    refreshData();
                    clear();
                }
                else
                {
                    MessageBox.Show("Nama Menu sudah ada di database");
                    conn.Close();
                }
               
            }
            



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            tbNamaKota.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                conn.Open();
                String kota = tbNamaKota.Text;
                String query = $"delete from m_kota where namakota like '{kota}'";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menghapus");
                conn.Close();
                clear();
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;

                //REFRESH DATA
                refreshData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                conn.Open();
                DataSet ds = new DataSet();
                String query = $"SELECT *" +
                              $"FROM m_kota " +
                              $"WHERE namakota like '%{tbCari.Text}%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportViewerMasterKota report = new ReportViewerMasterKota();
            report.Show();
        }
    }
}
