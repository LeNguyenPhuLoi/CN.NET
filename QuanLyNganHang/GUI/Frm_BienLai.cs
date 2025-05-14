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
    public partial class Frm_BienLai : Form
    {
        public Frm_BienLai()
        {
            InitializeComponent();
        }

        BUS_BienLai BUS_BienLai = new BUS_BienLai();
        private void Frm_BienLai_Load(object sender, EventArgs e)
        {
            dgv_bienlai.DataSource = BUS_BienLai.LoadBL();
            cbo_phuongthuctim.SelectedIndex = 0;
            cbo_timbl.SelectedIndex = 0;
        }

        public void Clear()
        {
            txt_mabl.Clear();
            txt_loaibl.Clear();
            txt_sotien.Clear();
            dtp_ngaylap.Text = dtp_ngaylap.MinDate.ToString();
            txt_manv.Clear();
            txt_makh.Clear();
            txt_kytu.Clear();
            cbo_phuongthuctim.SelectedIndex = 0;
            dgv_bienlai.DataSource = BUS_BienLai.LoadBL();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_BienLai_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgv_bienlai_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_bienlai.CurrentCell.RowIndex;
                txt_mabl.Text = dgv_bienlai.Rows[dong].Cells[0].Value.ToString();
                txt_loaibl.Text = dgv_bienlai.Rows[dong].Cells[1].Value.ToString();
                txt_sotien.Text = dgv_bienlai.Rows[dong].Cells[2].Value.ToString();
                dtp_ngaylap.Text = dgv_bienlai.Rows[dong].Cells[3].Value.ToString();
                txt_manv.Text = dgv_bienlai.Rows[dong].Cells[4].Value.ToString();
                txt_makh.Text = dgv_bienlai.Rows[dong].Cells[5].Value.ToString();
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
                ET_BienLai bl = new ET_BienLai(txt_mabl.Text,
                                                txt_loaibl.Text,
                                                int.Parse(txt_sotien.Text),
                                                dtp_ngaylap.Value,
                                                txt_manv.Text,
                                                txt_makh.Text);
                if (BUS_BienLai.ThemBL(bl) == true)
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
            dgv_bienlai.DataSource = BUS_BienLai.LoadBL();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_BienLai bl = new ET_BienLai(txt_mabl.Text,
                                                txt_loaibl.Text,
                                                int.Parse(txt_sotien.Text),
                                                dtp_ngaylap.Value,
                                                txt_manv.Text,
                                                txt_makh.Text);
                if (BUS_BienLai.SuaBL(bl) == true)
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
            dgv_bienlai.DataSource = BUS_BienLai.LoadBL();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                ET_BienLai bl = new ET_BienLai(txt_mabl.Text,
                                                txt_loaibl.Text,
                                                int.Parse(txt_sotien.Text),
                                                dtp_ngaylap.Value,
                                                txt_manv.Text,
                                                txt_makh.Text);
                if (BUS_BienLai.XoaBL(bl) == true)
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
            dgv_bienlai.DataSource = BUS_BienLai.LoadBL();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_phuongthuctim.Text)
                {
                    case "Mã Biên Lai":
                        dgv_bienlai.DataSource = BUS_BienLai.TimBLTheoMa(txt_kytu.Text);
                        break;

                    case "Loại Biên Lai":
                        dgv_bienlai.DataSource = BUS_BienLai.TimBLTheoLoai(cbo_timbl.Text);
                        break;

                    case "Mã Nhân Viên":
                        dgv_bienlai.DataSource = BUS_BienLai.TimBLTheoMaNV(txt_kytu.Text);
                        break;

                    case "Mã Khách Hàng":
                        dgv_bienlai.DataSource = BUS_BienLai.TimBLTheoMaKH(txt_kytu.Text);
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
                if(cbo_phuongthuctim.Text == "Loại Biên Lai")
                {
                    cbo_timbl.Visible = true;
                    txt_kytu.Visible = false;
                }
                else
                {
                    cbo_timbl.Visible = false;
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
