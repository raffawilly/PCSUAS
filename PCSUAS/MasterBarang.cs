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
    public partial class MasterBarang : Form
    {
        public MasterBarang()
        {
            InitializeComponent();
        }

        private void m_barangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_barangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);

        }

        private void MasterBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_merk' table. You can move, or remove it, as needed.
            this.m_merkTableAdapter.Fill(this.dbProjectUasDataSet.m_merk);
            this.m_barangTableAdapter.Fill(this.dbProjectUasDataSet.m_barang);

        }

        private void pERSAMAANLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void m_barangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
                try
                {
                    //this.Validate();
                    this.m_barangBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
                }
                catch (DataException ex)
                {
                    MessageBox.Show(ex.Message + ex.GetType().ToString());
                    this.m_barangBindingSource.CancelEdit();
                }
                catch (ArgumentException ex)
                {
                    // This block catches exceptions such as a value that's beyond
                    // the maximum length for a column in a dataset.
                    MessageBox.Show(ex.Message, "Argument Exception");
                    this.m_barangBindingSource.CancelEdit();
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("A concurrency error occurred. " +
                        "The row was not updated.", "Concurrency Exception");
                    this.m_barangTableAdapter.Fill(this.dbProjectUasDataSet.m_barang);
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Server error # " + ex.Number +
                        ": " + ex.Message, ex.GetType().ToString());
                }

            
            m_barangBindingSource.MoveNext();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewMasterBarang vBrg = new ViewMasterBarang();
            vBrg.Show();
            
        }
    }
}
