using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ET;
using BUS;

namespace GUI
{
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }

        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            dgv_khachhang.DataSource = BUS_KhachHang.LoadKH();
            cbo_phuongthuctim.SelectedIndex = 0;
        }

        public void Clear()
        {
            txt_makh.Clear();
            txt_tenkh.Clear();
            txt_sdt.Clear();
            rdb_nam.Checked = true;
            txt_diachi.Clear();
            dtp_ngaysinh.Text = dtp_ngaysinh.MinDate.ToString();
            cbo_phuongthuctim.SelectedIndex = 0;
            txt_kytu.Clear();
            dgv_khachhang.DataSource = BUS_KhachHang.LoadKH();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgv_khachhang_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_khachhang.CurrentCell.RowIndex;
                txt_makh.Text = dgv_khachhang.Rows[dong].Cells[0].Value.ToString();
                txt_tenkh.Text = dgv_khachhang.Rows[dong].Cells[1].Value.ToString();
                txt_sdt.Text = dgv_khachhang.Rows[dong].Cells[2].Value.ToString();
                if (dgv_khachhang.Rows[dong].Cells[3].Value.ToString() == "NAM")
                    rdb_nam.Checked = true;
                else
                    rdb_Nu.Checked = true;
                txt_diachi.Text = dgv_khachhang.Rows[dong].Cells[4].Value.ToString();
                dtp_ngaysinh.Text = dgv_khachhang.Rows[dong].Cells[5].Value.ToString();
            }
            catch(Exception ex) 
            {
                 MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        public string LayGioiTinh()
        {
            if (rdb_nam.Checked == true)
            {
                return "NAM";
            }
            else
            {
                return "NỮ";
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhachHang kh = new ET_KhachHang(txt_makh.Text,
                                                   txt_tenkh.Text,
                                                   int.Parse(txt_sdt.Text),
                                                   LayGioiTinh(),
                                                   txt_diachi.Text,
                                                   dtp_ngaysinh.Value);
                if(BUS_KhachHang.ThemKH(kh) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_khachhang.DataSource = BUS_KhachHang.LoadKH();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhachHang kh = new ET_KhachHang(txt_makh.Text,
                                                   txt_tenkh.Text,
                                                   int.Parse(txt_sdt.Text),
                                                   LayGioiTinh(),
                                                   txt_diachi.Text,
                                                   dtp_ngaysinh.Value);
                if (BUS_KhachHang.SuaKH(kh) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_khachhang.DataSource = BUS_KhachHang.LoadKH();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa?","Thông báo!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    ET_KhachHang kh = new ET_KhachHang(txt_makh.Text,
                                                      txt_tenkh.Text,
                                                      int.Parse(txt_sdt.Text),
                                                      LayGioiTinh(),
                                                      txt_diachi.Text,
                                                      dtp_ngaysinh.Value);
                     if (BUS_KhachHang.XoaKH(kh) == true)
                     {
                        MessageBox.Show("Xóa thành công!");
                        Clear();
                     }
                     else
                     {
                        MessageBox.Show("Xóa thất bại!");
                     }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_khachhang.DataSource = BUS_KhachHang.LoadKH();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_phuongthuctim.Text)
                {
                    case "Mã Khách Hàng":
                        dgv_khachhang.DataSource = BUS_KhachHang.TimKHTheoMa(txt_kytu.Text);
                        break;

                    case "Tên Khách Hàng":
                        dgv_khachhang.DataSource = BUS_KhachHang.TimKHTheoTen(txt_kytu.Text);
                        break;

                    case "SĐT Khách Hàng":
                        dgv_khachhang.DataSource = BUS_KhachHang.TimKHTheoSDT(int.Parse(txt_kytu.Text));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
