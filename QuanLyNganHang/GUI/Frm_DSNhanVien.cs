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
    public partial class Frm_DSNhanVien : Form
    {
        public Frm_DSNhanVien()
        {
            InitializeComponent();
        }

        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();

        private void Frm_DSNhanVien_Load(object sender, EventArgs e)
        {
            cbo_Xem.SelectedIndex = 0;
            AddToCBO(BUS_NhanVien.LoadTenCN(), cbo_TimCN);
            cbo_TimCN.Visible = false;
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
            cbo_PhuongThucTim.Text = null;
            txt_TuKhoa.Clear();
            cbo_TimCN.Text = null;
        }

        private void cbo_Xem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Xem.SelectedIndex == 0)
                {
                    label12.Visible = false;
                    cbo_PhuongThucTim.Visible = false;
                    Ancbo_TimCN();
                    txt_TuKhoa.Visible = false;
                    btn_Tim.Visible = false;
                    btn_LamMoi.Visible = false;

                    GUI.Report.Rpt_DSNhanVien rpt = new GUI.Report.Rpt_DSNhanVien();
                    rpt.SetDataSource(BUS_NhanVien.LayNVChoReport());
                    crv_NhanVien.ReportSource = rpt;
                    crv_NhanVien.Refresh();

                }
                else
                {
                    label12.Visible = true;
                    cbo_PhuongThucTim.Visible = true;
                    Ancbo_TimCN();
                    txt_TuKhoa.Visible = true;
                    btn_Tim.Visible = true;
                    btn_LamMoi.Visible = true;
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
            GUI.Report.Rpt_DSNhanVien rpt = new GUI.Report.Rpt_DSNhanVien();
            rpt.SetDataSource(BUS_NhanVien.LayNVChoReport());
            crv_NhanVien.ReportSource = rpt;
            crv_NhanVien.Refresh();
        }

        public void Ancbo_TimCN()
        {
            if (cbo_PhuongThucTim.SelectedIndex == 3)
            {
                txt_TuKhoa.Visible = false;
                cbo_TimCN.Visible = true;
            }
            else
            {
                txt_TuKhoa.Visible = true;
                cbo_TimCN.Visible = false;
            }
        }

        private void cbo_PhuongThucTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Ancbo_TimCN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void Frm_DSNhanVien_Resize(object sender, EventArgs e)
        {
            try
            {
                crv_NhanVien.Size = new Size(
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
                GUI.Report.Rpt_DSNhanVien rpt = new GUI.Report.Rpt_DSNhanVien();
                switch (cbo_PhuongThucTim.Text) 
                {
                    case "Mã Nhân Viên":
                        rpt.SetDataSource(BUS_NhanVien.LayNVChoReportTheoMaNV(txt_TuKhoa.Text));
                        crv_NhanVien.ReportSource = rpt;
                        crv_NhanVien.Refresh();
                        break;

                    case "Tên Nhân Viên":
                        rpt.SetDataSource(BUS_NhanVien.LayNVChoReportTheoTenNV(txt_TuKhoa.Text));
                        crv_NhanVien.ReportSource = rpt;
                        crv_NhanVien.Refresh();
                        break;

                    case "SĐT":
                        rpt.SetDataSource(BUS_NhanVien.LayNVChoReportTheoSDT(Convert.ToInt32(txt_TuKhoa.Text)));
                        crv_NhanVien.ReportSource = rpt;
                        crv_NhanVien.Refresh();
                        break;

                    case "Chi Nhánh":
                        rpt.SetDataSource(BUS_NhanVien.LayNVChoReportTheoCN(cbo_TimCN.Text));
                        crv_NhanVien.ReportSource = rpt;
                        crv_NhanVien.Refresh();
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void Frm_DSNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
