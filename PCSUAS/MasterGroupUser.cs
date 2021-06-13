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
    public partial class MasterGroupUser : Form
    {
        public MasterGroupUser()
        {
            InitializeComponent();
        }

        private void m_groupuserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_groupuserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);

        }

        private void MasterGroupUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_users' table. You can move, or remove it, as needed.
            this.m_usersTableAdapter.Fill(this.dbProjectUasDataSet.m_users);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_hakaksesgroupuser' table. You can move, or remove it, as needed.
            this.m_hakaksesgroupuserTableAdapter.Fill(this.dbProjectUasDataSet.m_hakaksesgroupuser);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_groupuser' table. You can move, or remove it, as needed.
            this.m_groupuserTableAdapter.Fill(this.dbProjectUasDataSet.m_groupuser);

        }
    }
}
