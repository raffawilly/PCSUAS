using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCSUAS
{
    public partial class ViewMasterBarang : Form
    {
        public ViewMasterBarang()
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
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.dbProjectUasDataSet.m_barang);

        }
    }
}
