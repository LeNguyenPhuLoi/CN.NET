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
    public partial class Frm_DSHoTro : Form
    {
        public Frm_DSHoTro()
        {
            InitializeComponent();
        }

        BUS_HoTro BUS_HoTro = new BUS_HoTro();

        private void Frm_DSHoTro_Load(object sender, EventArgs e)
        {
            cbo_kieuxem.SelectedIndex = 0;
            GUI.Report.Rpt_DSHoTro rpt = new GUI.Report.Rpt_DSHoTro();
            rpt.SetDataSource(BUS_HoTro.LayHT());
            crv_hotro.ReportSource = rpt;
            crv_hotro.Refresh();
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
                    cbo_dvht.Visible = false;
                    GUI.Report.Rpt_DSHoTro rpt = new GUI.Report.Rpt_DSHoTro();
                    rpt.SetDataSource(BUS_HoTro.LayHT());
                    crv_hotro.ReportSource = rpt;
                    crv_hotro.Refresh();
                }
                else
                {
                    label2.Visible = true;
                    cbo_tim.Visible=true;  
                    txt_tim.Visible=true;
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
            GUI.Report.Rpt_DSHoTro rpt = new GUI.Report.Rpt_DSHoTro();
            rpt.SetDataSource(BUS_HoTro.LayHT());
            crv_hotro.ReportSource = rpt;
            crv_hotro.Refresh();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Report.Rpt_DSHoTro rpt = new GUI.Report.Rpt_DSHoTro();
                switch(cbo_tim.Text)
                {
                    case "Mã Khách Hàng":
                        rpt.SetDataSource(BUS_HoTro.LayHTTheoMa(txt_tim.Text));
                        crv_hotro.ReportSource = rpt;
                        crv_hotro.Refresh();
                        break;

                    case "DVHT":
                        rpt.SetDataSource(BUS_HoTro.LayHTTheoDVHT(cbo_dvht.Text));
                        crv_hotro.ReportSource = rpt;
                        crv_hotro.Refresh();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void Frm_DSHoTro_FormClosing(object sender, FormClosingEventArgs e)
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
                if (cbo_tim.Text == "DVHT")
                {
                    cbo_dvht.Visible = true;
                    txt_tim.Visible = false;
                }
                else
                {
                    cbo_dvht.Visible = false;
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
