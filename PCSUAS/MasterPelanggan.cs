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
    public partial class MasterPelanggan : Form
    {
        public MasterPelanggan()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            ReportViewerMasterPelanggan Print = new ReportViewerMasterPelanggan();
            Print.Show();
        }
    }
}
