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
    public partial class MasterHakAkses : Form
    {
        public MasterHakAkses()
        {
            InitializeComponent();
        }

        private void m_hakaksesgroupuserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_hakaksesgroupuserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);

        }

        private void MasterHakAkses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_hakaksesgroupuser' table. You can move, or remove it, as needed.
            this.m_hakaksesgroupuserTableAdapter.Fill(this.dbProjectUasDataSet.m_hakaksesgroupuser);

        }
    }
}
