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
    public partial class MasterSupplier : Form
    {
        SqlConnection conn;
        public MasterSupplier()
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

        private void m_supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Supplier ID has been used ");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("You Can't change the data for a while");
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }

        }

        private void MasterSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_kota' table. You can move, or remove it, as needed.
            this.m_kotaTableAdapter.Fill(this.dbProjectUasDataSet.m_kota);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.dbProjectUasDataSet.m_supplier);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void p_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Supplier ID has been used ");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("You Can't change the data for a while");
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Supplier ID has been used ");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("You Can't change the data for a while");
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Supplier ID has been used ");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("You Can't change the data for a while");
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Supplier ID has been used ");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("You Can't change the data for a while");
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewMasterSupplier vSup = new ViewMasterSupplier();
            vSup.Show();
        }

        private void pictPrint_Click(object sender, EventArgs e)
        {
            ReportViewerMasterSupplier report = new ReportViewerMasterSupplier();
            report.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
                DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                    String kode = p_IDTextBox.Text;
                    String query = $"delete from m_supplier where p_id like '{kode}'";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Menghapus");
                    conn.Close();
                }
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message + ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (ArgumentException ex)
            {
                // This block catches exceptions such as a value that's beyond
                // the maximum length for a column in a dataset.
                MessageBox.Show(ex.Message, "Argument Exception");
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occurred. " +
                    "The row was not updated.", "Concurrency Exception");
                this.m_supplierTableAdapter.Fill(this.dbProjectUasDataSet.m_supplier);
            }

            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
