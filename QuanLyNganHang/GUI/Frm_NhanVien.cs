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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }

        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            dtp_NgaySinh.MaxDate = DateTime.Now.AddYears(-18);
            dgv_NhanVien.DataSource = BUS_NhanVien.LoadNV();
            cbo_TimCN.Visible = false;
            txt_TuKhoa.Visible = true;
            rdb_Nam.Checked = true;
            dgv_NhanVien.Columns["CHINHANH"].Visible = false;
            dgv_NhanVien.Columns["PHONGBAN"].Visible = false;
            AddToCBO(BUS_NhanVien.LoadTenPB(), cbo_PhongBan);
            AddToCBO(BUS_NhanVien.LoadTenCN(), cbo_ChiNhanh);
            AddToCBO(BUS_NhanVien.LoadTenCN(), cbo_TimCN);
            cbo_PhuongThucTim.SelectedIndex = 0;
        }

        public void AddToCBO(IQueryable list, ComboBox cbo)
        {
            foreach (var item in list)
            {
                cbo.Items.Add(item);
            }
        }

        public void Clear()
        {
            txt_MaNV.Clear();
            txt_TenNV.Clear();
            rdb_Nam.Checked = true;
            dtp_NgaySinh.Text = dtp_NgaySinh.MinDate.ToString();
            txt_Chuc.Clear();
            txt_Lương.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            cbo_PhongBan.Text = null;
            cbo_ChiNhanh.Text = null;
            cbo_PhuongThucTim.SelectedIndex = 0;
            txt_TuKhoa.Clear();
            cbo_TimCN.Text = null;
            dgv_NhanVien.DataSource = BUS_NhanVien.LoadNV();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgv_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_NhanVien.CurrentCell.RowIndex;
                txt_MaNV.Text = dgv_NhanVien.Rows[dong].Cells[0].Value.ToString();
                txt_TenNV.Text = dgv_NhanVien.Rows[dong].Cells[1].Value.ToString();
                if (dgv_NhanVien.Rows[dong].Cells[2].Value.ToString() == "NAM")
                    rdb_Nam.Checked = true;
                else
                    rdb_Nu.Checked = true;
                dtp_NgaySinh.Text = dgv_NhanVien.Rows[dong].Cells[3].Value.ToString();
                txt_Chuc.Text = dgv_NhanVien.Rows[dong].Cells[4].Value.ToString();
                txt_Lương.Text = dgv_NhanVien.Rows[dong].Cells[5].Value.ToString();
                txt_DiaChi.Text = dgv_NhanVien.Rows[dong].Cells[6].Value.ToString();
                txt_SDT.Text = dgv_NhanVien.Rows[dong].Cells[7].Value.ToString();
                cbo_PhongBan.Text = BUS_NhanVien.LayTenPBTheoMa(Convert.ToInt32(dgv_NhanVien.Rows[dong].Cells[8].Value.ToString()));
                cbo_ChiNhanh.Text = BUS_NhanVien.LayTenCNTheoMa(dgv_NhanVien.Rows[dong].Cells[9].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        public string LayGioiTinh()
        {
            if (rdb_Nam.Checked == true)
            {
                return "NAM";
            }
            else
            {
                return "NỮ";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_NhanVien nv = new ET_NhanVien(txt_MaNV.Text,
                                                            txt_TenNV.Text,
                                                            LayGioiTinh(),
                                                            dtp_NgaySinh.Value,
                                                            txt_Chuc.Text,
                                                            float.Parse(txt_Lương.Text),
                                                            txt_DiaChi.Text,
                                                            Convert.ToInt32(txt_SDT.Text),
                                                            BUS_NhanVien.LayMaPBTheoTen(cbo_PhongBan.Text),
                                                            BUS_NhanVien.LayMaCNTheoTen(cbo_ChiNhanh.Text));
                if (BUS_NhanVien.ThemNV(nv) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }

            dgv_NhanVien.DataSource = BUS_NhanVien.LoadNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_NhanVien nv = new ET_NhanVien(txt_MaNV.Text,
                                                            txt_TenNV.Text,
                                                            LayGioiTinh(),
                                                            dtp_NgaySinh.Value,
                                                            txt_Chuc.Text,
                                                            float.Parse(txt_Lương.Text),
                                                            txt_DiaChi.Text,
                                                            Convert.ToInt32(txt_SDT.Text),
                                                            BUS_NhanVien.LayMaPBTheoTen(cbo_PhongBan.Text),
                                                            BUS_NhanVien.LayMaCNTheoTen(cbo_ChiNhanh.Text));
                if (BUS_NhanVien.SuaNV(nv) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }

            dgv_NhanVien.DataSource = BUS_NhanVien.LoadNV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_NhanVien nv = new ET_NhanVien(txt_MaNV.Text,
                                                txt_TenNV.Text,
                                                LayGioiTinh(),
                                                dtp_NgaySinh.Value,
                                                txt_Chuc.Text,
                                                float.Parse(txt_Lương.Text),
                                                txt_DiaChi.Text,
                                                Convert.ToInt32(txt_SDT.Text),
                                                BUS_NhanVien.LayMaPBTheoTen(cbo_PhongBan.Text),
                                                BUS_NhanVien.LayMaCNTheoTen(cbo_ChiNhanh.Text));
                    if (BUS_NhanVien.XoaNV(nv) == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }

            dgv_NhanVien.DataSource = BUS_NhanVien.LoadNV();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThucTim.Text)
                {
                    case "Mã Nhân Viên":
                        dgv_NhanVien.DataSource = BUS_NhanVien.TimNVTheoMa(txt_TuKhoa.Text);
                        break;

                    case "Tên Nhân Viên":
                        dgv_NhanVien.DataSource = BUS_NhanVien.TimNVTheoTen(txt_TuKhoa.Text);
                        break;

                    case "SĐT":
                        dgv_NhanVien.DataSource = BUS_NhanVien.TimNVTheoSDT(Convert.ToInt32(txt_TuKhoa.Text));
                        break;

                    case "Chi Nhánh":
                        dgv_NhanVien.DataSource = BUS_NhanVien.TimNVTheoCN(cbo_TimCN.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void cbo_PhuongThucTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbo_PhuongThucTim.Text == "Chi Nhánh")
                {
                    cbo_TimCN.Visible = true;
                    txt_TuKhoa.Visible = false;
                }
                else
                {
                    cbo_TimCN.Visible = false;
                    txt_TuKhoa.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
