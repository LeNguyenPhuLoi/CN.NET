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
    public partial class Frm_ChiNhanh : Form
    {
        public Frm_ChiNhanh()
        {
            InitializeComponent();
        }

        BUS_ChiNhanh BUS_ChiNhanh = new BUS_ChiNhanh();

        private void Frm_ChiNhanh_Load(object sender, EventArgs e)
        {
            dgv_ChiNhanh.DataSource = BUS_ChiNhanh.LoadCN();
            cbo_PhuongThucTim.SelectedIndex = 0;
        }

        public void Clear()
        {
            txt_MaCN.Clear();
            txt_TenCN.Clear();
            txt_DiaChi.Clear();
            cbo_PhuongThucTim.SelectedIndex = 0;
            txt_TuKhoa.Clear();
            dgv_ChiNhanh.DataSource = BUS_ChiNhanh.LoadCN();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ChiNhanh_FormClosing(object sender, FormClosingEventArgs e)
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
                ET_ChiNhanh cn = new ET_ChiNhanh(txt_MaCN.Text,txt_TenCN.Text,txt_DiaChi.Text);
                if(BUS_ChiNhanh.ThemCN(cn) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            
            dgv_ChiNhanh.DataSource = BUS_ChiNhanh.LoadCN();
        }

        private void dgv_ChiNhanh_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_ChiNhanh.CurrentCell.RowIndex;
                txt_MaCN.Text = dgv_ChiNhanh.Rows[dong].Cells[0].Value.ToString();
                txt_TenCN.Text = dgv_ChiNhanh.Rows[dong].Cells[1].Value.ToString();
                txt_DiaChi.Text = dgv_ChiNhanh.Rows[dong].Cells[2].Value.ToString();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ChiNhanh cn = new ET_ChiNhanh(txt_MaCN.Text, txt_TenCN.Text, txt_DiaChi.Text);
                if (BUS_ChiNhanh.SuaCN(cn) == true)
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

            dgv_ChiNhanh.DataSource = BUS_ChiNhanh.LoadCN();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                try
                {
                    ET_ChiNhanh cn = new ET_ChiNhanh(txt_MaCN.Text, txt_TenCN.Text, txt_DiaChi.Text);
                    if (BUS_ChiNhanh.XoaCN(cn) == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
            }
            dgv_ChiNhanh.DataSource = BUS_ChiNhanh.LoadCN();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThucTim.Text)
                {
                    case "Mã Chi Nhánh":
                        dgv_ChiNhanh.DataSource = BUS_ChiNhanh.TimCNTheoMa(txt_TuKhoa.Text);
                        break;

                    case "Tên Chi Nhánh":
                        dgv_ChiNhanh.DataSource = BUS_ChiNhanh.TimCNTheoTen(txt_TuKhoa.Text);
                        break;

                    case "Địa Chỉ":
                        dgv_ChiNhanh.DataSource = BUS_ChiNhanh.TimCNTheoDiaChi(txt_TuKhoa.Text);
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
