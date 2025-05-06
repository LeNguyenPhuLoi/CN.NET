using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using ET;

namespace GUI
{
    public partial class Frm_HoTro : Form
    {
        public Frm_HoTro()
        {
            InitializeComponent();
        }

        BUS_HoTro BUS_HoTro = new BUS_HoTro();

        private void Frm_HoTro_Load(object sender, EventArgs e)
        {
            dgv_hotro.DataSource = BUS_HoTro.LoadHT();
            cbo_dvht.SelectedIndex = 0;
            cbo_phuongthuctim.SelectedIndex = 0;
            cbo_timdvht.SelectedIndex = 0;
        }

        public void Clear()
        {
            txt_manv.Clear();
            txt_manv.Clear();
            cbo_dvht.SelectedIndex = 0;
            txt_makh.Clear();
            dgv_hotro.DataSource = BUS_HoTro.LoadHT();
            cbo_phuongthuctim.SelectedIndex=0;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_HoTro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát?","Thông báo!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgv_hotro_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_hotro.CurrentCell.RowIndex;
                txt_makh.Text = dgv_hotro.Rows[dong].Cells[0].Value.ToString();
                cbo_dvht.Text = dgv_hotro.Rows[dong].Cells[1].Value.ToString();
                txt_manv.Text = dgv_hotro.Rows[dong].Cells[2].Value.ToString();
                txt_makm.Text = dgv_hotro.Rows[dong].Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi" +ex.Message);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_HoTro ht = new ET_HoTro(txt_makh.Text,
                                            cbo_dvht.Text,
                                            txt_manv.Text,
                                            txt_makm.Text);
                if (BUS_HoTro.ThemHT(ht) == true)
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
            dgv_hotro.DataSource = BUS_HoTro.LoadHT();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_HoTro ht = new ET_HoTro(txt_makh.Text,
                                            cbo_dvht.Text,
                                           txt_manv.Text,
                                            txt_makm.Text);
                if (BUS_HoTro.SuaHT(ht) == false)
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
            dgv_hotro.DataSource = BUS_HoTro.LoadHT();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                ET_HoTro ht = new ET_HoTro(txt_makh.Text,
                                            cbo_dvht.Text,
                                            txt_manv.Text,
                                            txt_makm.Text);
                if (BUS_HoTro.XoaHT(ht) == true)
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
            dgv_hotro.DataSource = BUS_HoTro.LoadHT();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch(cbo_phuongthuctim.Text)
                {
                    case "Mã Khách Hàng":
                        dgv_hotro.DataSource = BUS_HoTro.TimHTTheoMaKH(txt_kytu.Text);
                        break;

                    case "DVHT":
                        dgv_hotro.DataSource = BUS_HoTro.TimHTTheoDVHT(cbo_timdvht.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void cbo_phuongthuctim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbo_phuongthuctim.Text == "DVHT")
                {
                    cbo_timdvht.Visible = true;
                    txt_kytu.Visible = false;
                }
                else
                {
                    cbo_timdvht.Visible = false;
                    txt_kytu.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
