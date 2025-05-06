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
    public partial class Frm_ViPham : Form
    {
        public Frm_ViPham()
        {
            InitializeComponent();
        }

        BUS_ViPham BUS_ViPham = new BUS_ViPham();

        private void Frm_ViPham_Load(object sender, EventArgs e)
        {
            dtp_NgayViPham.MaxDate = DateTime.Now;
            dtp_TimNgay.MaxDate = DateTime.Now;
            dgv_ViPham.DataSource = BUS_ViPham.LoadVP();
            dgv_ViPham.Columns["NOIQUY"].Visible = false;
            dgv_ViPham.Columns["NHANVIEN"].Visible = false;
            AddToCBO(BUS_ViPham.LoadTenNV(), cbo_NhanVien);
            AddToCBO(BUS_ViPham.LoadMoTaNQ(), cbo_NoiQuy);
            AddToCBO(BUS_ViPham.LoadTenNV(), cbo_TimNV);
            AddToCBO(BUS_ViPham.LoadMoTaNQ(), cbo_TimNQ);
            cbo_PhuongThucTim.SelectedIndex = 0;
        }

        public void AddToCBO(IQueryable list, ComboBox c)
        {
            foreach (var item in list)
            {
                c.Items.Add(item);
            }
        }

        public void Clear()
        {
            txt_MaVP.Clear();
            cbo_NhanVien.Text = null;
            cbo_NoiQuy.Text = null;
            dtp_NgayViPham.Text = dtp_NgayViPham.MaxDate.ToString();
            txt_TienPhat.Clear();
            txt_SoLanViPham.Clear();
            rtxt_GhiChu.Clear();
            cbo_PhuongThucTim.SelectedIndex = 0;
            txt_TuKhoa.Clear();
            dtp_TimNgay.Value = dtp_TimNgay.MaxDate;
            txt_TuKhoa.Visible = true;
            dtp_TimNgay.Visible = false;
            cbo_TimNV.Text = null;
            cbo_TimNV.Visible = false;
            cbo_TimNQ.Text = null;
            cbo_TimNQ.Visible = false;
            dgv_ViPham.DataSource = BUS_ViPham.LoadVP();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_ViPham_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_ViPham.CurrentCell.RowIndex;
                txt_MaVP.Text = dgv_ViPham.Rows[dong].Cells[0].Value.ToString();
                cbo_NhanVien.Text = BUS_ViPham.LayTenNVTheoMa(dgv_ViPham.Rows[dong].Cells[1].Value.ToString());
                cbo_NoiQuy.Text = BUS_ViPham.LayMoTaTheoMa(dgv_ViPham.Rows[dong].Cells[2].Value.ToString());
                dtp_NgayViPham.Text = dgv_ViPham.Rows[dong].Cells[3].Value.ToString();
                txt_TienPhat.Text = dgv_ViPham.Rows[dong].Cells[4].Value.ToString();
                txt_SoLanViPham.Text = dgv_ViPham.Rows[dong].Cells[5].Value.ToString();
                rtxt_GhiChu.Text = dgv_ViPham.Rows[dong].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void txt_SoLanViPham_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_SoLanViPham.Text, out _))
            {
                MessageBox.Show("Số lần vi phạm chỉ được nhập số nguyên và không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SoLanViPham.Focus();
            }
            else
            {
                txt_TienPhat.Text = (Convert.ToDouble(txt_SoLanViPham.Text) * BUS_ViPham.LayMucPhatTheoMoTa(cbo_NoiQuy.Text)).ToString();
            }
        }

        private void Frm_ViPham_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbo_NoiQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_SoLanViPham.Text != "")
            {
                txt_TienPhat.Text = (Convert.ToDouble(txt_SoLanViPham.Text) * BUS_ViPham.LayMucPhatTheoMoTa(cbo_NoiQuy.Text)).ToString();
            }
            else
            {
                txt_TienPhat.Text = "0";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoLanViPham.Text != "")
                {
                    ET_ViPham vp = new ET_ViPham(txt_MaVP.Text,
                                                BUS_ViPham.LayMaNVTheoTen(cbo_NhanVien.Text),
                                                BUS_ViPham.LayMaNQTheoMoTa(cbo_NoiQuy.Text),
                                                Convert.ToDateTime(dtp_NgayViPham.Text),
                                                float.Parse(txt_TienPhat.Text),
                                                Convert.ToInt32(txt_SoLanViPham.Text),
                                                rtxt_GhiChu.Text);
                    if (BUS_ViPham.ThemVP(vp) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Số lần vi phạm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_ViPham.DataSource = BUS_ViPham.LoadVP();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoLanViPham.Text != "")
                {
                    ET_ViPham vp = new ET_ViPham(txt_MaVP.Text,
                                                BUS_ViPham.LayMaNVTheoTen(cbo_NhanVien.Text),
                                                BUS_ViPham.LayMaNQTheoMoTa(cbo_NoiQuy.Text),
                                                Convert.ToDateTime(dtp_NgayViPham.Text),
                                                float.Parse(txt_TienPhat.Text),
                                                Convert.ToInt32(txt_SoLanViPham.Text),
                                                rtxt_GhiChu.Text);
                    if (BUS_ViPham.SuaVP(vp) == true)
                    {
                        MessageBox.Show("Sửa thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Số lần vi phạm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_ViPham.DataSource = BUS_ViPham.LoadVP();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoLanViPham.Text != "")
                {
                    ET_ViPham vp = new ET_ViPham(txt_MaVP.Text,
                                                BUS_ViPham.LayMaNVTheoTen(cbo_NhanVien.Text),
                                                BUS_ViPham.LayMaNQTheoMoTa(cbo_NoiQuy.Text),
                                                Convert.ToDateTime(dtp_NgayViPham.Text),
                                                float.Parse(txt_TienPhat.Text),
                                                Convert.ToInt32(txt_SoLanViPham.Text),
                                                rtxt_GhiChu.Text);
                    if (BUS_ViPham.XoaVP(vp) == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Số lần vi phạm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_ViPham.DataSource = BUS_ViPham.LoadVP();
        }

        private void cbo_PhuongThucTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThucTim.Text)
                {
                    case "Mã Vi Phạm":
                        txt_TuKhoa.Visible = true;
                        dtp_TimNgay.Visible = false;
                        cbo_TimNV.Visible = false;
                        cbo_TimNQ.Visible = false;
                        break;

                    case "Nhân Viên":
                        txt_TuKhoa.Visible = false;
                        dtp_TimNgay.Visible = false;
                        cbo_TimNV.Visible = true;
                        cbo_TimNQ.Visible = false;
                        break;

                    case "Nội Quy":
                        txt_TuKhoa.Visible = false;
                        dtp_TimNgay.Visible = false;
                        cbo_TimNV.Visible = false;
                        cbo_TimNQ.Visible = true;
                        break;

                    case "Ngày Vi Phạm":
                        txt_TuKhoa.Visible = false;
                        dtp_TimNgay.Visible = true;
                        cbo_TimNV.Visible = false;
                        cbo_TimNQ.Visible = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThucTim.Text)
                {
                    case "Mã Vi Phạm":
                        dgv_ViPham.DataSource = BUS_ViPham.TimVPTheoMa(txt_TuKhoa.Text);
                        break;

                    case "Nhân Viên":
                        dgv_ViPham.DataSource = BUS_ViPham.TimVPTheoTenNV(cbo_TimNV.Text);
                        break;

                    case "Nội Quy":
                        dgv_ViPham.DataSource = BUS_ViPham.TimVPTheoMoTa(cbo_TimNQ.Text);
                        break;

                    case "Ngày Vi Phạm":
                        dgv_ViPham.DataSource = BUS_ViPham.TimVPTheoNgay(dtp_TimNgay.Value);
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
