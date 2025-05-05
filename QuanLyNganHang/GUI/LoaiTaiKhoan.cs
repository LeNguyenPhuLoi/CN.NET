using BUS;
using ET;
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
    public partial class frmLoaiTaiKhoan : Form
    {
        public frmLoaiTaiKhoan()
        {
            InitializeComponent();
        }
        BUS_LoaiTaiKhoan busltk = new BUS_LoaiTaiKhoan();

        private void LoaiTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvLoaiTaiKhoan.DataSource = busltk.LoadLTK();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_LoaiTaiKhoan et = new ET_LoaiTaiKhoan(txtMaLoai.Text, txtTenNH.Text);
            //goi ham thuc hien
            if (busltk.ThemLTK(et) == true)
            {
                MessageBox.Show("Thêm Thành Công!!");
            }
            else
            {
                MessageBox.Show("Thêm Không thành công!");
            }
            dgvLoaiTaiKhoan.DataSource = busltk.LoadLTK();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ET_LoaiTaiKhoan et = new ET_LoaiTaiKhoan(txtMaLoai.Text, txtTenNH.Text);
                //goi ham thuc hien
                if (busltk.XoaLTK(et) == true)
                {
                    MessageBox.Show("Xóa Thành Công!!");
                }
                else
                {
                    MessageBox.Show("Xóa Không thành công!");
                }
                dgvLoaiTaiKhoan.DataSource = busltk.LoadLTK();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_LoaiTaiKhoan et = new ET_LoaiTaiKhoan(txtMaLoai.Text, txtTenNH.Text);
            //goi ham thuc hien
            if (busltk.CapNhatLTK(et) == true)
            {
                MessageBox.Show("Cập Nhật Thành Công!!");
            }
            else
            {
                MessageBox.Show("Cập Nhật Không thành công!");
            }
            dgvLoaiTaiKhoan.DataSource = busltk.LoadLTK();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLoai.Clear();
            txtTenNH.Clear();
            txtMaLoai.Focus();
        }

        private void dgvLoaiTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvLoaiTaiKhoan.CurrentCell.RowIndex;
                txtMaLoai.Text = dgvLoaiTaiKhoan.Rows[dong].Cells[0].Value.ToString();
                txtTenNH.Text = dgvLoaiTaiKhoan.Rows[dong].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmLoaiTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
