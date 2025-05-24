using BUS;
using GUI.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDSTaiKhoan : Form
    {
        BUS_TaiKhoan BUS_TaiKhoans = new BUS_TaiKhoan();
        public frmDSTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmDSTaiKhoan_Load(object sender, EventArgs e)
        {
            GUI.Report.rpt_DSTaiKhoan rpt = new GUI.Report.rpt_DSTaiKhoan();
            rpt.SetDataSource(BUS_TaiKhoans.LayTaiKhoanReportDataTable());
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
