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
    public partial class ViewMasterSupplier : Form
    {
        SqlConnection conn;
        public ViewMasterSupplier()
        {
            InitializeComponent();
        }

        private void m_supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);

        }

        private void ViewMasterSupplier_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT *" +
                           $"FROM m_supplier";
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
                          $"FROM m_supplier " +
                          $"WHERE p_id like '%{tbCari.Text}%'" +
                          $"or nama like '%{tbCari.Text}%'" +
                           $"or alamat like '%{tbCari.Text}%'" +
                          $"or kota like '%{tbCari.Text}%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }
    }
}
