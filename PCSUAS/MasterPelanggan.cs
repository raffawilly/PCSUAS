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
    public partial class MasterPelanggan : Form
    {
        SqlConnection conn;
        public MasterPelanggan()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
                throw;
            }
        }

        private void m_pelangganBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_pelangganBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);

        }

        private void MasterPelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_kota' table. You can move, or remove it, as needed.
            this.m_kotaTableAdapter.Fill(this.dbProjectUasDataSet.m_kota);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.dbProjectUasDataSet.m_pelanggan);

        }

        private void iDLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewMasterPelanggan vPel = new ViewMasterPelanggan();
            vPel.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReportViewerMasterPelanggan Print = new ReportViewerMasterPelanggan();
            Print.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Validate();
                this.m_pelangganBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
                DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                    String kode = p_CODETextBox.Text;
                    String query = $"delete from m_pelanggan where p_code like '{kode}'";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Menghapus");
                    conn.Close();
                }
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message + ex.GetType().ToString());
                this.m_pelangganBindingSource.CancelEdit();
            }
            catch (ArgumentException ex)
            {
                // This block catches exceptions such as a value that's beyond
                // the maximum length for a column in a dataset.
                MessageBox.Show(ex.Message, "Argument Exception");
                this.m_pelangganBindingSource.CancelEdit();
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occurred. " +
                    "The row was not updated.", "Concurrency Exception");
                this.m_pelangganTableAdapter.Fill(this.dbProjectUasDataSet.m_pelanggan);
            }

            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
