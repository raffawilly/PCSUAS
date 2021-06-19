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
    public partial class ReportViewerMasterMerk : Form
    {
        public ReportViewerMasterMerk()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReportMasterMerk report = new CrystalReportMasterMerk();
            crystalReportViewer1.ReportSource = report;
        }
    }
}
