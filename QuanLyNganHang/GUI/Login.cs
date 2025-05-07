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

namespace GUI
{
    public partial class frmLogin : Form
    {
        BUS_Login buslq = new BUS_Login();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            ET_Login user = buslq.DangNhap(username, password);

            if (user == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Phân quyền
            if (buslq.IsAdmin(user))
            {
                //Form frmAdmin = new frmAdmin(user); // bạn cần tạo form này
                //frmAdmin.Show();
                MessageBox.Show("nguoi dung");
            }
            else if (buslq.IsNhanVien(user))
            {
                //Form frmNhanVien = new frmNhanVien(user); // bạn cần tạo form này
                //frmNhanVien.Show();
                MessageBox.Show("quan ly");
            }

            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
       
        }
    }
}
