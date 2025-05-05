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
    public partial class frmTienTe : Form
    {
        public frmTienTe()
        {
            InitializeComponent();
        }

        BUS_TienTe bustt = new BUS_TienTe();
        private void frmTienTe_Load(object sender, EventArgs e)
        {
            dgvTienTe.DataSource = bustt.LoadTT();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_TienTe et = new ET_TienTe(txtMaTT.Text, txtTenTT.Text);
            //goi ham thuc hien
            if (bustt.ThemTT(et) == true)
            {
                MessageBox.Show("Thêm thành công!!");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ET_TienTe et = new ET_TienTe(txtMaTT.Text, txtTenTT.Text);
                //goi ham thuc hien
                if (bustt.XoaTT(et) == true)
                {
                    MessageBox.Show("Xóa thành công!!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_TienTe et = new ET_TienTe(txtMaTT.Text, txtTenTT.Text);
            //goi ham thuc hien
            if (bustt.CapNhatTT(et) == true)
            {
                MessageBox.Show("Cập Nhật thành công!!");
            }
            else
            {
                MessageBox.Show("Cập Nhật không thành công!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTT.Clear();
            txtTenTT.Clear();
            txtMaTT.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTienTe_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvTienTe.CurrentCell.RowIndex;
                txtMaTT.Text = dgvTienTe.Rows[dong].Cells[0].Value.ToString();
                txtTenTT.Text = dgvTienTe.Rows[dong].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex);
            }

        }

        private void frmTienTe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
