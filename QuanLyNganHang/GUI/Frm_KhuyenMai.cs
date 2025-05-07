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
    public partial class Frm_KhuyenMai : Form
    {
        public Frm_KhuyenMai()
        {
            InitializeComponent();
        }

        BUS_KhuyenMai BUS_KhuyenMai = new BUS_KhuyenMai();

        private void Frm_KhuyenMai_Load(object sender, EventArgs e)
        {
            dgv_khuyenmai.DataSource = BUS_KhuyenMai.LoadKM();
            cbo_phuongthuctim.SelectedIndex = 0;
        }

        public void Clear()
        {
            txt_makm.Clear();
            txt_tenkm.Clear();
            dtp_ngaybatdau.Text = dtp_ngaybatdau.MinDate.ToString();
            dtp_ngayketthuc.Text = dtp_ngayketthuc.MinDate.ToString();
            txt_dieukien.Clear();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_KhuyenMai_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgv_khuyenmai_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_khuyenmai.CurrentCell.RowIndex;
                txt_makm.Text = dgv_khuyenmai.Rows[dong].Cells[0].Value.ToString();
                txt_tenkm.Text = dgv_khuyenmai.Rows[dong].Cells[1].Value.ToString();
                dtp_ngaybatdau.Text = dgv_khuyenmai.Rows[dong].Cells[2].Value.ToString();
                dtp_ngayketthuc.Text = dgv_khuyenmai.Rows[dong].Cells[3].Value.ToString();
                txt_dieukien.Text = dgv_khuyenmai.Rows[dong].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhuyenMai km = new ET_KhuyenMai(txt_makm.Text,
                                                    txt_tenkm.Text,
                                                    dtp_ngaybatdau.Value,
                                                    dtp_ngayketthuc.Value,
                                                    txt_dieukien.Text);
                if(BUS_KhuyenMai.ThemKM(km) == true)
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
            dgv_khuyenmai.DataSource = BUS_KhuyenMai.LoadKM();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhuyenMai km = new ET_KhuyenMai(txt_makm.Text,
                                                    txt_tenkm.Text,
                                                    dtp_ngaybatdau.Value,
                                                    dtp_ngayketthuc.Value,
                                                    txt_dieukien.Text);
                if (BUS_KhuyenMai.SuaKM(km) == true)
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
            dgv_khuyenmai.DataSource = BUS_KhuyenMai.LoadKM();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                ET_KhuyenMai km = new ET_KhuyenMai(txt_makm.Text,
                                                    txt_tenkm.Text,
                                                    dtp_ngaybatdau.Value,
                                                    dtp_ngayketthuc.Value,
                                                    txt_dieukien.Text);
                if (BUS_KhuyenMai.XoaKM(km) == true)
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
            dgv_khuyenmai.DataSource = BUS_KhuyenMai.LoadKM();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_phuongthuctim.Text)
                {
                    case "Mã Khuyến Mãi":
                        dgv_khuyenmai.DataSource = BUS_KhuyenMai.TimKMTheoMa(txt_kytu.Text);
                        break;

                    case "Tên Khuyến Mãi":
                        dgv_khuyenmai.DataSource = BUS_KhuyenMai.TimKMTheoTen(txt_kytu.Text);
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
