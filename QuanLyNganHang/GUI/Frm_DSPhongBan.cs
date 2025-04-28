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
    public partial class Frm_DSPhongBan : Form
    {
        public Frm_DSPhongBan()
        {
            InitializeComponent();
        }

        BUS_PhongBan BUS_PhongBan = new BUS_PhongBan();

        private void Frm_DSPhongBan_Load(object sender, EventArgs e)
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

                    GUI.Report.Rpt_DSPhongBan rpt = new GUI.Report.Rpt_DSPhongBan();
                    rpt.SetDataSource(BUS_PhongBan.LayPBChoReport());
                    crv_PhongBan.ReportSource = rpt;
                    crv_PhongBan.Refresh();
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
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
            GUI.Report.Rpt_DSPhongBan rpt = new GUI.Report.Rpt_DSPhongBan();
            rpt.SetDataSource(BUS_PhongBan.LayPBChoReport());
            crv_PhongBan.ReportSource = rpt;
            crv_PhongBan.Refresh();
        }

        private void Frm_DSPhongBan_Resize(object sender, EventArgs e)
        {
            try
            {
                crv_PhongBan.Size = new Size(
                                    (int)(this.Width * 0.85),
                                    (int)(this.Height * 0.85)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void Frm_DSPhongBan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Report.Rpt_DSPhongBan rpt = new GUI.Report.Rpt_DSPhongBan();
                switch (cbo_PhuongThucTim.Text) 
                {
                    case "Mã Phòng Ban":
                        rpt.SetDataSource(BUS_PhongBan.LayPBChoReportTheoMa(Convert.ToInt32(txt_TuKhoa.Text)));
                        crv_PhongBan.ReportSource = rpt;
                        crv_PhongBan.Refresh();
                        break;

                    case "Tên Phòng Ban":
                        rpt.SetDataSource(BUS_PhongBan.LayPBChoReportTheoTen(txt_TuKhoa.Text));
                        crv_PhongBan.ReportSource = rpt;
                        crv_PhongBan.Refresh();
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
