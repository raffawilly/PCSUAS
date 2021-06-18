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
    public partial class btnCari : Form
    {
        SqlConnection conn;
        public btnCari()
        {
            InitializeComponent();
        }

        private void m_barangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_barangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
        }

        private void ViewMasterBarang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT *" +
                           $"FROM m_barang";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }


        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT *" +
                          $"FROM m_barang " +
                          $"WHERE description like '%{tbCari.Text}%'" +
                          $"or kode like '%{tbCari.Text}%'" +
                          $"or part_no like '%{tbCari.Text}%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }
    }
}
