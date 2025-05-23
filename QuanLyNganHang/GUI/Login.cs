﻿using BUS;
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
        public Form NextForm { get; set; }
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

            if (buslq.IsAdmin(user))
            {
                NextForm = new frmMenu();
            }
            else if (buslq.IsNhanVien(user))
            {
                NextForm = new frmUser();
            }
            else
            {
                MessageBox.Show("Không xác định quyền người dùng.");
                return;
            }

            NextForm.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
