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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            Frm_KhuyenMai frm = new Frm_KhuyenMai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Frm_KhachHang frm = new Frm_KhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDSKhachHang_Click(object sender, EventArgs e)
        {
            Frm_DSKhachHang frm = new Frm_DSKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            Frm_HoTro frm = new Frm_HoTro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnBienLai_Click(object sender, EventArgs e)
        {
            Frm_BienLai frm = new Frm_BienLai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDSTaiKhoan_Click(object sender, EventArgs e)
        {
            frmDSTaiKhoan frm = new frmDSTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDSHOTro_Click(object sender, EventArgs e)
        {
            Frm_DSHoTro frm = new Frm_DSHoTro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDSBienLai_Click(object sender, EventArgs e)
        {
            Frm_DSBienLai frm = new Frm_DSBienLai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát Chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

            GUI.frmLogin frmLogin = new GUI.frmLogin();
            frmLogin.NextForm = new frmLogin();
            frmLogin.Show();

            this.Hide();
        }
    }
}
