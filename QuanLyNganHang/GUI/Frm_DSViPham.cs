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
    public partial class Frm_DSViPham : Form
    {
        public Frm_DSViPham()
        {
            InitializeComponent();
        }

        BUS_ViPham BUS_ViPham = new BUS_ViPham();

        private void Frm_DSViPham_Load(object sender, EventArgs e)
        {
            dtp_Tim.MaxDate = DateTime.Now;
            cbo_PhuongThucTim.SelectedIndex = 0;
            cbo_Xem.SelectedIndex = 0;
            AddToCBO(BUS_ViPham.LoadTenNV(),cbo_TimNV);
            AddToCBO(BUS_ViPham.LoadMoTaNQ(), cbo_TimMoTa);
        }

        public void AddToCBO(IQueryable list, ComboBox cbo)
        {
            foreach (var item in list)
            {
                cbo.Items.Add(item);
            }
        }

        public void Clear()
        {
            cbo_PhuongThucTim.SelectedIndex = 0;
            txt_TuKhoa.Clear();
            cbo_TimNV.Text = null;
            cbo_TimMoTa.Text = null;
            dtp_Tim.Text = dtp_Tim.MaxDate.ToString();
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
                    cbo_TimNV.Visible = false;
                    cbo_TimMoTa.Visible = false;
                    dtp_Tim.Visible = false;
                    btn_LamMoi.Visible = false;
                    btn_Tim.Visible = false;

                    GUI.Report.Rpt_DSViPham rpt = new GUI.Report.Rpt_DSViPham();
                    rpt.SetDataSource(BUS_ViPham.LayVPChoReport());
                    crv_ViPham.ReportSource = rpt;
                    crv_ViPham.Refresh();
                }
                else
                {
                    cbo_PhuongThucTim.SelectedIndex = 0;
                    label12.Visible = true;
                    cbo_PhuongThucTim.Visible = true;
                    cbo_TimNV.Visible = false;
                    dtp_Tim.Visible = false;
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

        private void cbo_PhuongThucTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThucTim.SelectedIndex)
                {
                    case 0:
                        cbo_TimNV.Visible = false;
                        dtp_Tim.Visible = false;
                        txt_TuKhoa.Visible = true;
                        cbo_TimMoTa.Visible = false;
                        break;

                    case 1:
                        cbo_TimNV.Visible = true;
                        dtp_Tim.Visible = false;
                        txt_TuKhoa.Visible = false;
                        cbo_TimMoTa.Visible = false;
                        break;

                    case 2:
                        cbo_TimNV.Visible = false;
                        dtp_Tim.Visible = false;
                        txt_TuKhoa.Visible = false;
                        cbo_TimMoTa.Visible = true;
                        break;

                    case 3:
                        cbo_TimNV.Visible = false;
                        dtp_Tim.Visible = true;
                        txt_TuKhoa.Visible = false;
                        cbo_TimMoTa.Visible = false;
                        break;
                }
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
                GUI.Report.Rpt_DSViPham rpt = new GUI.Report.Rpt_DSViPham();
                switch (cbo_PhuongThucTim.Text)
                {
                    case "Mã Vi Phạm":
                        rpt.SetDataSource(BUS_ViPham.LayVPChoReportTheoMaVP(txt_TuKhoa.Text));
                        crv_ViPham.ReportSource = rpt;
                        crv_ViPham.Refresh();
                        break;

                    case "Tên Nhân Viên":
                        rpt.SetDataSource(BUS_ViPham.LayVPChoReportTheoTenNV(cbo_TimNV.Text));
                        crv_ViPham.ReportSource = rpt;
                        crv_ViPham.Refresh();
                        break;

                    case "Mô Tả":
                        rpt.SetDataSource(BUS_ViPham.LayVPChoReportTheoMoTa(cbo_TimMoTa.Text));
                        crv_ViPham.ReportSource = rpt;
                        crv_ViPham.Refresh();
                        break;

                    case "Ngày Vi Phạm":
                        rpt.SetDataSource(BUS_ViPham.LayVPChoReportTheoNgay(dtp_Tim.Value));
                        crv_ViPham.ReportSource = rpt;
                        crv_ViPham.Refresh();
                        break;
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
            GUI.Report.Rpt_DSViPham rpt = new GUI.Report.Rpt_DSViPham();
            rpt.SetDataSource(BUS_ViPham.LayVPChoReport());
            crv_ViPham.ReportSource = rpt;
            crv_ViPham.Refresh();
        }

        private void Frm_DSViPham_Resize(object sender, EventArgs e)
        {
            try
            {
                crv_ViPham.Size = new Size(
                                    (int)(this.Width * 0.85),
                                    (int)(this.Height * 0.85)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void Frm_DSViPham_FormClosing(object sender, FormClosingEventArgs e)
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
