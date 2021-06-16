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
    public partial class ReportMasterGroup : Form
    {
        public ReportMasterGroup()
        {
            InitializeComponent();
        }

        private void ReportMasterGroup_Load(object sender, EventArgs e)
        {
            CrystalMasterGroup crp = new CrystalMasterGroup();
            crystalReportViewer1.ReportSource = crp;
        }
    }
}
