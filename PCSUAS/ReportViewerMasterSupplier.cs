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
    public partial class ReportViewerMasterSupplier : Form
    {
        public ReportViewerMasterSupplier()
        {
            InitializeComponent();
        }

        private void ReportViewerMasterSupplier_Load(object sender, EventArgs e)
        {
            CrystalReportMasterSupplier report = new CrystalReportMasterSupplier();
            crystalReportViewer1.ReportSource = report;
        }
    }
}
