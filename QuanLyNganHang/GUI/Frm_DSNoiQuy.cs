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
using ET;

namespace GUI
{
    public partial class Frm_DSNoiQuy : Form
    {
        public Frm_DSNoiQuy()
        {
            InitializeComponent();
        }

        BUS_NoiQuy BUS_NoiQuy = new BUS_NoiQuy();

        private void Frm_DSNoiQuy_Load(object sender, EventArgs e)
        {
            cbo_Xem.SelectedIndex = 0;
            cbo_PhuongThucTim.SelectedIndex = 0;
        }

        public void Clear()
        {
            cbo_PhuongThucTim.SelectedIndex = 0;
            txt_TuKhoa.Clear();
        }

        private void cbo_Xem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Xem.SelectedIndex == 0) 
                {
                    label12.Visible = false;
                    cbo_PhuongThucTim.Visible = false;
                    txt_TuKhoa.Visible = false;
                    btn_LamMoi.Visible = false;
                    btn_Tim.Visible = false;

                    GUI.Report.Rpt_DSNoiQuy rpt = new GUI.Report.Rpt_DSNoiQuy();
                    rpt.SetDataSource(BUS_NoiQuy.LayNQChoReport());
                    crv_NoiQuy.ReportSource = rpt;
                    crv_NoiQuy.Refresh();
                }
                else
                {
                    label12.Visible = true;
                    cbo_PhuongThucTim.Visible = true;
                    txt_TuKhoa.Visible = true;
                    btn_LamMoi.Visible = true;
                    btn_Tim.Visible = true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
            GUI.Report.Rpt_DSNoiQuy rpt = new GUI.Report.Rpt_DSNoiQuy();
            rpt.SetDataSource(BUS_NoiQuy.LayNQChoReport());
            crv_NoiQuy.ReportSource = rpt;
            crv_NoiQuy.Refresh();
        }

        private void Frm_DSNoiQuy_Resize(object sender, EventArgs e)
        {
            try
            {
                crv_NoiQuy.Size = new Size(
                                    (int)(this.Width * 0.85),
                                    (int)(this.Height * 0.85)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {                        
                GUI.Report.Rpt_DSNoiQuy rpt = new GUI.Report.Rpt_DSNoiQuy();
                switch (cbo_PhuongThucTim.Text) 
                {
                    case "Mã Nội Quy":
                        rpt.SetDataSource(BUS_NoiQuy.LayNQChoReportTheoMa(txt_TuKhoa.Text));
                        crv_NoiQuy.ReportSource = rpt;
                        crv_NoiQuy.Refresh();
                        break;

                    case "Mô Tả":
                        rpt.SetDataSource(BUS_NoiQuy.LayNQChoReportTheoMoTa(txt_TuKhoa.Text));
                        crv_NoiQuy.ReportSource = rpt;
                        crv_NoiQuy.Refresh();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void Frm_DSNoiQuy_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
