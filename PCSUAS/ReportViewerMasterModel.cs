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
    public partial class ReportViewerMasterModel : Form
    {
        public ReportViewerMasterModel()
        {
            InitializeComponent();
        }

        private void ReportViewerMasterModel_Load(object sender, EventArgs e)
        {
            CrystalReport1 crp = new CrystalReport1();
            crystalReportViewer1.ReportSource = crp;
        }
    }
}
