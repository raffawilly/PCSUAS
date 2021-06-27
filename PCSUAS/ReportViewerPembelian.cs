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
    public partial class ReportViewerPembelian : Form
    {
        public ReportViewerPembelian()
        {
            InitializeComponent();
        }

        private void ReportViewerPembelian_Load(object sender, EventArgs e)
        {
            CrystalReportPembelian crp = new CrystalReportPembelian();
            crystalReportViewer1.ReportSource = crp;
        }
    }
}
