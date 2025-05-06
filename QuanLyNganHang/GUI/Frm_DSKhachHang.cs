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
    public partial class Frm_DSKhachHang : Form
    {
        public Frm_DSKhachHang()
        {
            InitializeComponent();
        }

        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();

        private void Frm_DSKhachHang_Load(object sender, EventArgs e)
        {
            cbo_kieuxem.SelectedIndex = 0;
            GUI.Report.Rpt_DSKhachHang rpt = new GUI.Report.Rpt_DSKhachHang();
            rpt.SetDataSource(BUS_KhachHang.LayKH());
            crv_khachhang.ReportSource = rpt;
            crv_khachhang.Refresh();
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
                    cbo_tim.SelectedIndex = 0;
                    GUI.Report.Rpt_DSKhachHang rpt = new GUI.Report.Rpt_DSKhachHang();
                    rpt.SetDataSource(BUS_KhachHang.LayKH());
                    crv_khachhang.ReportSource = rpt;   
                    crv_khachhang.Refresh();
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
            GUI.Report.Rpt_DSKhachHang rpt = new GUI.Report.Rpt_DSKhachHang();
            rpt.SetDataSource(BUS_KhachHang.LayKH());
            crv_khachhang.ReportSource = rpt;
            crv_khachhang.Refresh();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Report.Rpt_DSKhachHang rpt = new GUI.Report.Rpt_DSKhachHang();
                switch (cbo_tim.Text)
                {
                    case "Mã Khách Hàng":
                        rpt.SetDataSource(BUS_KhachHang.LayKHTheoMa(txt_tim.Text));
                        crv_khachhang.ReportSource = rpt;
                        crv_khachhang.Refresh();
                        break;

                    case "Tên Khách Hàng":
                        rpt.SetDataSource(BUS_KhachHang.LayKHTheoTen(txt_tim.Text));
                        crv_khachhang.ReportSource = rpt;
                        crv_khachhang.Refresh();
                        break;

                    case "SĐT Khách Hàng":
                        rpt.SetDataSource(BUS_KhachHang.LayKHTheoSDT(int.Parse(txt_tim.Text)));
                        crv_khachhang.ReportSource = rpt;
                        crv_khachhang.Refresh();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void Frm_DSKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
