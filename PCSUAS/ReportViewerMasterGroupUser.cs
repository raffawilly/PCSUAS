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
    public partial class ReportViewerMasterGroupUser : Form
    {
        public ReportViewerMasterGroupUser()
        {
            InitializeComponent();
        }

        private void ReportViewerMasterGroupUser_Load(object sender, EventArgs e)
        {
            CrystalReportMasterGroupUser crp = new CrystalReportMasterGroupUser();
            crystalReportViewer1.ReportSource = crp;

        }
    }
}
