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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GUI
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        BUS_TaiKhoan bustk = new BUS_TaiKhoan();
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = bustk.LoadTK();
            AddToCombo(bustk.LoadTT(),cboLoaiTien);
            AddToCombo(bustk.LoadKH(), cboMaKH);
            AddToCombo(bustk.LoadNV(), cboMaNV);
            AddToCombo(bustk.LoadLTK(), cboLoaiTK);
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
            ET_TaiKhoan etTaiKhoan = new ET_TaiKhoan(txtMaTK.Text, float.Parse(txtSoDu.Text),
                                                    DateTime.Parse(dtpNgayLap.Text), GetMa(cboMaKH.Text),
                                                    GetMa(cboLoaiTK.Text), GetMa(cboLoaiTien.Text),
                                                    GetMa(cboMaNV.Text));
            //goi ham thuc hien
            if(bustk.ThemTK(etTaiKhoan) == true)
            {
                MessageBox.Show("Thêm thành công!!");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
            dgvTaiKhoan.DataSource = bustk.LoadTK();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ET_TaiKhoan etTaiKhoan = new ET_TaiKhoan(txtMaTK.Text, float.Parse(txtSoDu.Text),
                                                    DateTime.Parse(dtpNgayLap.Text), GetMa(cboMaKH.Text),
                                                    GetMa(cboLoaiTK.Text), GetMa(cboLoaiTien.Text),
                                                    GetMa(cboMaNV.Text));
                //goi ham thuc hien
                if (bustk.XoaTK(etTaiKhoan) == true)
                {
                    MessageBox.Show("Xóa tài khoản thành công!!!");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công");
                }
                dgvTaiKhoan.DataSource = bustk.LoadTK();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_TaiKhoan etTaiKhoan = new ET_TaiKhoan(txtMaTK.Text, float.Parse(txtSoDu.Text),
                                                    DateTime.Parse(dtpNgayLap.Text), GetMa(cboMaKH.Text),
                                                    GetMa(cboLoaiTK.Text), GetMa(cboLoaiTien.Text),
                                                    GetMa(cboMaNV.Text));
            //goi ham thuc hien
            if (bustk.CapNhatTK(etTaiKhoan) == true)
            {
                MessageBox.Show("Cập nhật thành công!!");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
            dgvTaiKhoan.DataSource = bustk.LoadTK();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTK.Clear();
            txtSoDu.Clear();
            dtpNgayLap.Value = DateTime.Now;
            cboMaKH.SelectedIndex = -1;
            cboMaNV.SelectedIndex = -1;
            cboLoaiTien.SelectedIndex = -1;
            cboLoaiTK.SelectedIndex = -1;
            txtMaTK.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvTaiKhoan.CurrentRow.Index;
                txtMaTK.Text = dgvTaiKhoan.Rows[dong].Cells[0].Value.ToString();
                txtSoDu.Text = dgvTaiKhoan.Rows[dong].Cells[1].Value.ToString();
                dtpNgayLap.Text = dgvTaiKhoan.Rows[dong].Cells[2].Value.ToString();
                cboMaKH.Text = bustk.LayTheoMaKH(dgvTaiKhoan.Rows[dong].Cells[3].Value.ToString()).FirstOrDefault() ?? "";
                cboLoaiTK.Text = bustk.LayTheoMaLTK(dgvTaiKhoan.Rows[dong].Cells[4].Value.ToString()).FirstOrDefault() ?? "";
                cboLoaiTien.Text = bustk.LayTheoMaTT(dgvTaiKhoan.Rows[dong].Cells[5].Value.ToString()).FirstOrDefault() ?? "";
                cboMaNV.Text= bustk.LayTheoMaNV(dgvTaiKhoan.Rows[dong].Cells[6].Value.ToString()).FirstOrDefault() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
