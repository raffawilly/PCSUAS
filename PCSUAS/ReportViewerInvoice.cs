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
    public partial class ReportViewerInvoice : Form
    {
        public ReportViewerInvoice()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReportInvoice crp = new CrystalReportInvoice();
            crystalReportViewer1.ReportSource = crp;
        }
    }
}
