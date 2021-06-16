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

        private void m_kotaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_kotaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);

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
        private void MasterKota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_kota' table. You can move, or remove it, as needed.
            this.m_kotaTableAdapter.Fill(this.dbProjectUasDataSet.m_kota);

        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cekKosong())
            {
                conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
                conn.Open();
                String query = $"Insert into m_kota  values('{tbNamaKota.Text}')";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                this.Validate();

                refreshData();
                clear();
            }
            



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            tbNamaKota.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cekKosong())
            {
                conn.Open();
                String kota = tbNamaKota.Text;
                conn.Close();
                conn.Open();
                String query = $"update m_kota set namakota = '{kota}' where namakota= '{kota}'";
                SqlCommand comm2 = new SqlCommand(query, conn);
                comm2.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update!");
                conn.Close();
                clear();
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
                //REFRESH DATA
                refreshData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
    }
}
