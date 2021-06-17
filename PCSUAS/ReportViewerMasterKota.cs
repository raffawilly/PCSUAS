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
    public partial class ReportViewerMasterKota : Form
    {
        public ReportViewerMasterKota()
        {
            InitializeComponent();
        }

        private void ReportViewerMasterKota_Load(object sender, EventArgs e)
        {
            CrystalReportMasterKota report = new CrystalReportMasterKota();
            crystalReportViewer1.ReportSource = report;
        }
    }
}
