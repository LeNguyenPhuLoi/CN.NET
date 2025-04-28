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
    public partial class Frm_NoiQuy : Form
    {
        public Frm_NoiQuy()
        {
            InitializeComponent();
        }

        BUS_NoiQuy BUS_NoiQuy = new BUS_NoiQuy();

        private void Frm_NoiQuy_Load(object sender, EventArgs e)
        {
            dgv_NoiQuy.DataSource = BUS_NoiQuy.LoadNQ();
            cbo_PhuongThucTim.SelectedIndex = 0;
        }

        public void Clear()
        {
            txt_MaNQ.Clear();
            txt_MoTa.Clear();
            txt_MucPhat.Clear();
            rtxt_GhiChu.Clear();
            cbo_PhuongThucTim.SelectedIndex = 0;
            txt_TuKhoa.Clear();
            dgv_NoiQuy.DataSource = BUS_NoiQuy.LoadNQ();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_NoiQuy_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgv_NoiQuy_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_NoiQuy.CurrentCell.RowIndex;
                txt_MaNQ.Text = dgv_NoiQuy.Rows[dong].Cells[0].Value.ToString();
                txt_MoTa.Text = dgv_NoiQuy.Rows[dong].Cells[1].Value.ToString();
                txt_MucPhat.Text = dgv_NoiQuy.Rows[dong].Cells[2].Value.ToString();
                rtxt_GhiChu.Text = dgv_NoiQuy.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_NoiQuy nq = new ET_NoiQuy(txt_MaNQ.Text, txt_MoTa.Text, float.Parse(txt_MucPhat.Text), rtxt_GhiChu.Text);
                if (BUS_NoiQuy.ThemNQ(nq) == true)
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

            dgv_NoiQuy.DataSource = BUS_NoiQuy.LoadNQ();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_NoiQuy nq = new ET_NoiQuy(txt_MaNQ.Text, txt_MoTa.Text, float.Parse(txt_MucPhat.Text), rtxt_GhiChu.Text);
                if (BUS_NoiQuy.SuaNQ(nq) == true)
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

            dgv_NoiQuy.DataSource = BUS_NoiQuy.LoadNQ();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_NoiQuy nq = new ET_NoiQuy(txt_MaNQ.Text, txt_MoTa.Text, float.Parse(txt_MucPhat.Text), rtxt_GhiChu.Text);
                    if (BUS_NoiQuy.XoaNQ(nq) == true)
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
            dgv_NoiQuy.DataSource = BUS_NoiQuy.LoadNQ();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThucTim.Text) 
                {
                    case "Mã Nội Quy":
                        dgv_NoiQuy.DataSource = BUS_NoiQuy.TimNQTheoMa(txt_TuKhoa.Text);
                        break;

                    case "Mô Tả":
                        dgv_NoiQuy.DataSource = BUS_NoiQuy.TimNQTheoMoTa(txt_TuKhoa.Text);
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
