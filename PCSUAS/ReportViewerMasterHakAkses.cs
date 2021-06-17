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
    public partial class ReportViewerMasterHakAkses : Form
    {
        public ReportViewerMasterHakAkses()
        {
            InitializeComponent();
        }

        private void ReportViewerMasterHakAkses_Load(object sender, EventArgs e)
        {
            CrystalReportMasterHakAkses report = new CrystalReportMasterHakAkses();
            crystalReportViewer1.ReportSource = report;
        }
    }
}
