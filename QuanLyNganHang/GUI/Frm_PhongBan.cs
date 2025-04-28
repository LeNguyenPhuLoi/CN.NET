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
    public partial class Frm_PhongBan : Form
    {
        public Frm_PhongBan()
        {
            InitializeComponent();
        }

        BUS_PhongBan BUS_PhongBan = new BUS_PhongBan();

        private void Frm_PhongBan_Load(object sender, EventArgs e)
        {
            dgv_PhongBan.DataSource = BUS_PhongBan.LoadPB();
            dgv_PhongBan.Columns["NHANVIEN"].Visible = false;
            AddToCBO(BUS_PhongBan.LoadNV(), cbo_TrPhong);
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
            txt_MaPB.Clear();
            txt_TenPB.Clear();
            cbo_TrPhong.Text = null;
            cbo_PhuongThucTim.SelectedIndex = 0;
            txt_TuKhoa.Clear();
            dgv_PhongBan.DataSource = BUS_PhongBan.LoadPB();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_PhongBan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_PhongBan pb = new ET_PhongBan(Convert.ToInt32(txt_MaPB.Text), txt_TenPB.Text, BUS_PhongBan.LayMaNVTheoTen(cbo_TrPhong.Text));

                if (BUS_PhongBan.ThemPB(pb) == true)
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
            dgv_PhongBan.DataSource = BUS_PhongBan.LoadPB();
        }

        private void dgv_PhongBan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_PhongBan.CurrentCell.RowIndex;
                txt_MaPB.Text = dgv_PhongBan.Rows[dong].Cells[0].Value.ToString();
                txt_TenPB.Text = dgv_PhongBan.Rows[dong].Cells[1].Value.ToString();
                cbo_TrPhong.Text = BUS_PhongBan.LayTenNVTheoMa(dgv_PhongBan.Rows[dong].Cells[2].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_PhongBan pb = new ET_PhongBan(Convert.ToInt32(txt_MaPB.Text), txt_TenPB.Text, BUS_PhongBan.LayMaNVTheoTen(cbo_TrPhong.Text));

                if (BUS_PhongBan.SuaPB(pb) == true)
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

            dgv_PhongBan.DataSource = BUS_PhongBan.LoadPB();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_PhongBan pb = new ET_PhongBan(Convert.ToInt32(txt_MaPB.Text), txt_TenPB.Text, BUS_PhongBan.LayMaNVTheoTen(cbo_TrPhong.Text));

                    if (BUS_PhongBan.XoaPB(pb) == true)
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

            dgv_PhongBan.DataSource = BUS_PhongBan.LoadPB();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try 
            {
                switch (cbo_PhuongThucTim.Text) 
                {
                    case "Mã Phòng Ban":
                        dgv_PhongBan.DataSource = BUS_PhongBan.TimPBTheoMa(Convert.ToInt32(txt_TuKhoa.Text));
                        break;

                    case "Tên Phòng Ban":
                        dgv_PhongBan.DataSource = BUS_PhongBan.TimPBTheoTen(txt_TuKhoa.Text);
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
