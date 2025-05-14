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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private bool isLoggingOut = false;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLoggingOut = true;
            GUI.frmLogin frmLogin = new GUI.frmLogin();
            frmLogin.Show();

            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLoggingOut)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn thoát Chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel= false;
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NhanVien frm = new Frm_NhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HoTro frm = new Frm_HoTro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ViPham frm = new Frm_ViPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang frm = new Frm_KhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void biênLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BienLai frm = new Frm_BienLai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KhuyenMai frm = new Frm_KhuyenMai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PhongBan frm = new Frm_PhongBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nộiQuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NoiQuy frm = new Frm_NoiQuy();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loạiTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiTaiKhoan frm = new frmLoaiTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tiềnTệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTienTe frm = new frmTienTe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tàiKhoảnĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoanDangNhap frm = new frmTaiKhoanDangNhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DSKhachHang frm = new Frm_DSKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchHỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DSHoTro frm = new Frm_DSHoTro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DSBienLai frm = new Frm_DSBienLai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DSNhanVien frm = new Frm_DSNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DSViPham frm = new Frm_DSViPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchNộiQuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DSNoiQuy frm = new Frm_DSNoiQuy();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DSPhongBan frm = new Frm_DSPhongBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchChiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DSChiNhanh frm = new Frm_DSChiNhanh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSTaiKhoan frm = new frmDSTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void chiNhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ChiNhanh frm = new Frm_ChiNhanh();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
