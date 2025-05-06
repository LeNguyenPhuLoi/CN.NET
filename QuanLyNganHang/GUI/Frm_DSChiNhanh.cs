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

namespace GUI
{
    public partial class Frm_DSChiNhanh : Form
    {
        public Frm_DSChiNhanh()
        {
            InitializeComponent();
        }

        BUS_ChiNhanh BUS_ChiNhanh = new BUS_ChiNhanh();

        private void Frm_DSChiNhanh_Load(object sender, EventArgs e)
        {
            cbo_Xem.SelectedIndex = 0;
            cbo_PhuongThucTim.SelectedIndex = 0;
        }

        public void Clear()
        {
            cbo_PhuongThucTim.Text = null;
            txt_TuKhoa.Clear();
            cbo_PhuongThucTim.SelectedIndex = 0;
        }

        private void Frm_DSChiNhanh_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbo_Xem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbo_Xem.SelectedIndex == 0)
                {
                    label12.Visible = false;
                    cbo_PhuongThucTim.Visible = false;
                    txt_TuKhoa.Visible = false;
                    btn_Tim.Visible = false;
                    btn_LamMoi.Visible = false;

                    GUI.Report.Rpt_DSChiNhanh rpt = new GUI.Report.Rpt_DSChiNhanh();
                    rpt.SetDataSource(BUS_ChiNhanh.LayCNChoReport());
                    crv_ChiNhanh.ReportSource = rpt;
                    crv_ChiNhanh.Refresh();
                }
                else
                {
                    label12.Visible = true;
                    cbo_PhuongThucTim.Visible = true;
                    txt_TuKhoa.Visible = true;
                    btn_Tim.Visible = true;
                    btn_LamMoi.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
            GUI.Report.Rpt_DSChiNhanh rpt = new GUI.Report.Rpt_DSChiNhanh();
            rpt.SetDataSource(BUS_ChiNhanh.LayCNChoReport());
            crv_ChiNhanh.ReportSource = rpt;
            crv_ChiNhanh.Refresh();
        }

        private void Frm_DSChiNhanh_Resize(object sender, EventArgs e)
        {
            try
            {
                crv_ChiNhanh.Size = new Size(
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
                GUI.Report.Rpt_DSChiNhanh rpt = new GUI.Report.Rpt_DSChiNhanh();
                switch (cbo_PhuongThucTim.Text) 
                {
                    case "Mã Chi Nhánh":
                        rpt.SetDataSource(BUS_ChiNhanh.LayCNChoReportTheoMaCN(txt_TuKhoa.Text));
                        crv_ChiNhanh.ReportSource = rpt;
                        crv_ChiNhanh.Refresh();
                        break;

                    case "Tên Chi Nhánh":
                        rpt.SetDataSource(BUS_ChiNhanh.LayCNChoReportTheoTenCN(txt_TuKhoa.Text));
                        crv_ChiNhanh.ReportSource = rpt;
                        crv_ChiNhanh.Refresh();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
