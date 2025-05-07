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
    public partial class frmTaiKhoanDangNhap : Form
    {
        public frmTaiKhoanDangNhap()
        {
            InitializeComponent();
        }
        BUS_TaiKhoan bustk = new BUS_TaiKhoan();
        BUS_TaiKhoanDangNhap bustkdn = new BUS_TaiKhoanDangNhap();
        private void frmTaiKhoanDangNhap_Load(object sender, EventArgs e)
        {
            dgvLogin.DataSource = bustkdn.LoadTKL();
            AddToCombo(bustk.LoadNV(), cboMaNV);
        }

        public void AddToCombo(IQueryable list, ComboBox c)
        {
            foreach (var a in list)
            {
                c.Items.Add(a);
            }
        }

        public string GetMa(string s)
        {
            string[] arr = s.Split('-');
            return arr[0];
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_TaiKhoanDangNhap et = new ET_TaiKhoanDangNhap(txtTenDN.Text, txtPass.Text,
                                                             cboQuyen.Text, GetMa(cboMaNV.Text));
            if(bustkdn.ThemTKL(et) == true)
            {
                MessageBox.Show("Thêm thành công!!");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
            dgvLogin.DataSource = bustkdn.LoadTKL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ET_TaiKhoanDangNhap et = new ET_TaiKhoanDangNhap(txtTenDN.Text, txtPass.Text,
                                                             cboQuyen.Text, GetMa(cboMaNV.Text));
                if (bustkdn.XoaTKL(et) == true)
                {
                    MessageBox.Show("Xóa thành công!!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                dgvLogin.DataSource = bustkdn.LoadTKL();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_TaiKhoanDangNhap et = new ET_TaiKhoanDangNhap(txtTenDN.Text, txtPass.Text,
                                                             cboQuyen.Text, GetMa(cboMaNV.Text));
            if (bustkdn.CapNhatTKL(et) == true)
            {
                MessageBox.Show("Cập Nhật thành công!!");
            }
            else
            {
                MessageBox.Show("Cập Nhật không thành công!");
            }
            dgvLogin.DataSource = bustkdn.LoadTKL();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenDN.Clear();
            txtPass.Clear();
            cboQuyen.SelectedIndex = 0;
            cboMaNV.SelectedIndex = -1;
            txtTenDN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvLogin.CurrentRow.Index;
                txtTenDN.Text = dgvLogin.Rows[dong].Cells[0].Value.ToString();
                txtPass.Text = dgvLogin.Rows[dong].Cells[1].Value.ToString();
                cboQuyen.Text = dgvLogin.Rows[dong].Cells[2].Value.ToString();
                cboMaNV.Text = bustk.LayTheoMaNV(dgvLogin.Rows[dong].Cells[3].Value.ToString()).FirstOrDefault() ?? "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTaiKhoanDangNhap_FormClosing(object sender, FormClosingEventArgs e)
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
