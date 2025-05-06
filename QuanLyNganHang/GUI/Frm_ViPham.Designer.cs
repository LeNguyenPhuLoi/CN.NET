namespace GUI
{
    partial class Frm_ViPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxt_GhiChu = new System.Windows.Forms.RichTextBox();
            this.txt_SoLanViPham = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TienPhat = new System.Windows.Forms.TextBox();
            this.txt_MaVP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_NgayViPham = new System.Windows.Forms.DateTimePicker();
            this.cbo_NhanVien = new System.Windows.Forms.ComboBox();
            this.cbo_NoiQuy = new System.Windows.Forms.ComboBox();
            this.dgv_ViPham = new System.Windows.Forms.DataGridView();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_TuKhoa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_PhuongThucTim = new System.Windows.Forms.ComboBox();
            this.dtp_TimNgay = new System.Windows.Forms.DateTimePicker();
            this.cbo_TimNV = new System.Windows.Forms.ComboBox();
            this.cbo_TimNQ = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxt_GhiChu
            // 
            this.rtxt_GhiChu.Location = new System.Drawing.Point(649, 169);
            this.rtxt_GhiChu.Name = "rtxt_GhiChu";
            this.rtxt_GhiChu.Size = new System.Drawing.Size(282, 73);
            this.rtxt_GhiChu.TabIndex = 86;
            this.rtxt_GhiChu.Text = "";
            // 
            // txt_SoLanViPham
            // 
            this.txt_SoLanViPham.Location = new System.Drawing.Point(649, 125);
            this.txt_SoLanViPham.Name = "txt_SoLanViPham";
            this.txt_SoLanViPham.Size = new System.Drawing.Size(282, 29);
            this.txt_SoLanViPham.TabIndex = 85;
            this.txt_SoLanViPham.Leave += new System.EventHandler(this.txt_SoLanViPham_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 84;
            this.label8.Text = "Ghi Chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 83;
            this.label7.Text = "Số Lần Vi Phạm";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(1095, 168);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(98, 29);
            this.btn_Thoat.TabIndex = 82;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(1095, 120);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(98, 29);
            this.btn_LamMoi.TabIndex = 81;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(980, 187);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa.TabIndex = 80;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(980, 143);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua.TabIndex = 79;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(980, 103);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 29);
            this.btn_Them.TabIndex = 78;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TienPhat
            // 
            this.txt_TienPhat.Location = new System.Drawing.Point(649, 81);
            this.txt_TienPhat.Name = "txt_TienPhat";
            this.txt_TienPhat.ReadOnly = true;
            this.txt_TienPhat.Size = new System.Drawing.Size(282, 29);
            this.txt_TienPhat.TabIndex = 77;
            // 
            // txt_MaVP
            // 
            this.txt_MaVP.Location = new System.Drawing.Point(185, 81);
            this.txt_MaVP.Name = "txt_MaVP";
            this.txt_MaVP.Size = new System.Drawing.Size(282, 29);
            this.txt_MaVP.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 75;
            this.label3.Text = "Tiền Phạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 74;
            this.label2.Text = "Mã Vi Phạm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(476, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 42);
            this.label1.TabIndex = 73;
            this.label1.Text = "Quản Trị Vi Phạm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 87;
            this.label4.Text = "Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 89;
            this.label5.Text = "Nội Quy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 91;
            this.label6.Text = "Ngày Vi Phạm";
            // 
            // dtp_NgayViPham
            // 
            this.dtp_NgayViPham.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayViPham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayViPham.Location = new System.Drawing.Point(185, 213);
            this.dtp_NgayViPham.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayViPham.Name = "dtp_NgayViPham";
            this.dtp_NgayViPham.Size = new System.Drawing.Size(282, 29);
            this.dtp_NgayViPham.TabIndex = 92;
            // 
            // cbo_NhanVien
            // 
            this.cbo_NhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NhanVien.FormattingEnabled = true;
            this.cbo_NhanVien.Location = new System.Drawing.Point(185, 125);
            this.cbo_NhanVien.Name = "cbo_NhanVien";
            this.cbo_NhanVien.Size = new System.Drawing.Size(282, 29);
            this.cbo_NhanVien.TabIndex = 93;
            // 
            // cbo_NoiQuy
            // 
            this.cbo_NoiQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NoiQuy.FormattingEnabled = true;
            this.cbo_NoiQuy.Location = new System.Drawing.Point(185, 169);
            this.cbo_NoiQuy.Name = "cbo_NoiQuy";
            this.cbo_NoiQuy.Size = new System.Drawing.Size(282, 29);
            this.cbo_NoiQuy.TabIndex = 94;
            this.cbo_NoiQuy.SelectedIndexChanged += new System.EventHandler(this.cbo_NoiQuy_SelectedIndexChanged);
            // 
            // dgv_ViPham
            // 
            this.dgv_ViPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ViPham.Location = new System.Drawing.Point(0, 313);
            this.dgv_ViPham.MultiSelect = false;
            this.dgv_ViPham.Name = "dgv_ViPham";
            this.dgv_ViPham.ReadOnly = true;
            this.dgv_ViPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViPham.Size = new System.Drawing.Size(1245, 326);
            this.dgv_ViPham.TabIndex = 95;
            this.dgv_ViPham.Click += new System.EventHandler(this.dgv_ViPham_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(976, 263);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 29);
            this.btn_Tim.TabIndex = 99;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_TuKhoa
            // 
            this.txt_TuKhoa.Location = new System.Drawing.Point(673, 263);
            this.txt_TuKhoa.Name = "txt_TuKhoa";
            this.txt_TuKhoa.Size = new System.Drawing.Size(282, 29);
            this.txt_TuKhoa.TabIndex = 98;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 266);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 21);
            this.label12.TabIndex = 97;
            this.label12.Text = "Phương Thức Tìm";
            // 
            // cbo_PhuongThucTim
            // 
            this.cbo_PhuongThucTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PhuongThucTim.FormattingEnabled = true;
            this.cbo_PhuongThucTim.Items.AddRange(new object[] {
            "Mã Vi Phạm",
            "Nhân Viên",
            "Nội Quy",
            "Ngày Vi Phạm"});
            this.cbo_PhuongThucTim.Location = new System.Drawing.Point(385, 263);
            this.cbo_PhuongThucTim.Name = "cbo_PhuongThucTim";
            this.cbo_PhuongThucTim.Size = new System.Drawing.Size(282, 29);
            this.cbo_PhuongThucTim.TabIndex = 96;
            this.cbo_PhuongThucTim.TextChanged += new System.EventHandler(this.cbo_PhuongThucTim_TextChanged);
            // 
            // dtp_TimNgay
            // 
            this.dtp_TimNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_TimNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TimNgay.Location = new System.Drawing.Point(673, 263);
            this.dtp_TimNgay.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtp_TimNgay.Name = "dtp_TimNgay";
            this.dtp_TimNgay.Size = new System.Drawing.Size(282, 29);
            this.dtp_TimNgay.TabIndex = 100;
            // 
            // cbo_TimNV
            // 
            this.cbo_TimNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TimNV.FormattingEnabled = true;
            this.cbo_TimNV.Location = new System.Drawing.Point(673, 263);
            this.cbo_TimNV.Name = "cbo_TimNV";
            this.cbo_TimNV.Size = new System.Drawing.Size(282, 29);
            this.cbo_TimNV.TabIndex = 101;
            // 
            // cbo_TimNQ
            // 
            this.cbo_TimNQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TimNQ.FormattingEnabled = true;
            this.cbo_TimNQ.Location = new System.Drawing.Point(673, 263);
            this.cbo_TimNQ.Name = "cbo_TimNQ";
            this.cbo_TimNQ.Size = new System.Drawing.Size(282, 29);
            this.cbo_TimNQ.TabIndex = 102;
            // 
            // Frm_ViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 639);
            this.Controls.Add(this.cbo_TimNQ);
            this.Controls.Add(this.cbo_TimNV);
            this.Controls.Add(this.dtp_TimNgay);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_TuKhoa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbo_PhuongThucTim);
            this.Controls.Add(this.dgv_ViPham);
            this.Controls.Add(this.cbo_NoiQuy);
            this.Controls.Add(this.cbo_NhanVien);
            this.Controls.Add(this.dtp_NgayViPham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxt_GhiChu);
            this.Controls.Add(this.txt_SoLanViPham);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TienPhat);
            this.Controls.Add(this.txt_MaVP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ViPham";
            this.Text = "Frm_ViPham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ViPham_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_GhiChu;
        private System.Windows.Forms.TextBox txt_SoLanViPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_TienPhat;
        private System.Windows.Forms.TextBox txt_MaVP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_NgayViPham;
        private System.Windows.Forms.ComboBox cbo_NhanVien;
        private System.Windows.Forms.ComboBox cbo_NoiQuy;
        private System.Windows.Forms.DataGridView dgv_ViPham;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_TuKhoa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_PhuongThucTim;
        private System.Windows.Forms.DateTimePicker dtp_TimNgay;
        private System.Windows.Forms.ComboBox cbo_TimNV;
        private System.Windows.Forms.ComboBox cbo_TimNQ;
    }
}