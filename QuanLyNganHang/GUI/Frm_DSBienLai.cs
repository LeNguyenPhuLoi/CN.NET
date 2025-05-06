using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using CrystalDecisions.CrystalReports.Engine;
using ET;
using GUI.Report;

namespace GUI
{
    public partial class Frm_DSBienLai : Form
    {
        public Frm_DSBienLai()
        {
            InitializeComponent();
        }

        BUS_BienLai BUS_BienLai = new BUS_BienLai();

        private void Frm_DSBienLai_Load(object sender, EventArgs e)
        {
            cbo_kieuxem.SelectedIndex = 0;
            GUI.Report.Rpt_DSBienLai rpt = new GUI.Report.Rpt_DSBienLai();
            rpt.SetDataSource(BUS_BienLai.LAYBL());
            crv_bienlai.ReportSource = rpt;
            crv_bienlai.Refresh();
        }

        public void Clear()
        {
            txt_tim.Clear();
            cbo_tim.SelectedIndex = 0;
        }

        private void cbo_kieuxem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbo_kieuxem.SelectedIndex == 0)
                {
                    label2.Visible = false;
                    cbo_tim.Visible = false;
                    txt_tim.Visible = false;
                    cbo_loaibl.Visible = false;
                    GUI.Report.Rpt_DSBienLai rpt = new GUI.Report.Rpt_DSBienLai();
                    rpt.SetDataSource(BUS_BienLai.LAYBL());
                    crv_bienlai.ReportSource = rpt;
                    crv_bienlai.Refresh();
                }
                else
                {
                    label2.Visible = true;
                    cbo_tim.Visible = true;
                    txt_tim.Visible = true;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Clear();
            GUI.Report.Rpt_DSBienLai rpt = new GUI.Report.Rpt_DSBienLai();
            rpt.SetDataSource(BUS_BienLai.LAYBL());
            crv_bienlai.ReportSource = rpt;
            crv_bienlai.Refresh();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Report.Rpt_DSBienLai rpt = new GUI.Report.Rpt_DSBienLai();
                switch (cbo_tim.Text)
                {
                    case "Mã Biên Lai":
                        rpt.SetDataSource(BUS_BienLai.LAYBLTheoMa(txt_tim.Text));
                        crv_bienlai.ReportSource = rpt;
                        crv_bienlai.Refresh();
                        break;

                    case "Loại Biên Lai":
                        rpt.SetDataSource(BUS_BienLai.LayBLTheoLoai( cbo_loaibl.Text));
                        crv_bienlai.ReportSource = rpt;
                        crv_bienlai.Refresh();
                        break;

                    case "Mã Nhân Viên":
                        rpt.SetDataSource(BUS_BienLai.LayBLTheoMaNV(txt_tim.Text));
                        crv_bienlai.ReportSource = rpt;
                        crv_bienlai.Refresh();
                        break;

                    case "Mã Khách Hàng":
                        rpt.SetDataSource(BUS_BienLai.LayBLTheoMaKH(txt_tim.Text));
                        crv_bienlai.ReportSource = rpt;
                        crv_bienlai.Refresh();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void Frm_DSBienLai_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void cbo_tim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_tim.Text == "Loại Biên Lai")
                {
                    cbo_loaibl.Visible = true;
                    txt_tim.Visible = false;
                }
                else
                {
                    cbo_loaibl.Visible = false;
                    txt_tim.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
