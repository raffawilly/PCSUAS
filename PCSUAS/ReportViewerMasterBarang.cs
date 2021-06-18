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
    public partial class ReportViewerMasterBarang : Form
    {
        public ReportViewerMasterBarang()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReportMasterBarang report = new CrystalReportMasterBarang();
            crystalReportViewer1.ReportSource = report;
        }
    }
}
