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
    public partial class ViewMasterPelanggan : Form
    {
        public ViewMasterPelanggan()
        {
            InitializeComponent();
        }

        private void m_pelangganBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_pelangganBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);

        }

        private void ViewMasterPelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.dbProjectUasDataSet.m_pelanggan);

        }
    }
}
