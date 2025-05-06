namespace GUI
{
    partial class Frm_KhuyenMai
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
            this.dtp_ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_kytu = new System.Windows.Forms.TextBox();
            this.cbo_phuongthuctim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_khuyenmai = new System.Windows.Forms.DataGridView();
            this.txt_tenkm = new System.Windows.Forms.TextBox();
            this.txt_makm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dieukien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khuyenmai)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_ngaybatdau
            // 
            this.dtp_ngaybatdau.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaybatdau.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaybatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaybatdau.Location = new System.Drawing.Point(212, 204);
            this.dtp_ngaybatdau.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaybatdau.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
            this.dtp_ngaybatdau.Size = new System.Drawing.Size(218, 32);
            this.dtp_ngaybatdau.TabIndex = 65;
            this.dtp_ngaybatdau.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 29);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ngày Bắt Đầu";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(1046, 163);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(115, 34);
            this.btn_thoat.TabIndex = 61;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(902, 163);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(115, 34);
            this.btn_lammoi.TabIndex = 60;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(1109, 84);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 34);
            this.btn_xoa.TabIndex = 59;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(985, 84);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 34);
            this.btn_sua.TabIndex = 58;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(860, 84);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 34);
            this.btn_them.TabIndex = 57;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(735, 258);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 34);
            this.btn_tim.TabIndex = 56;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_kytu
            // 
            this.txt_kytu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kytu.Location = new System.Drawing.Point(491, 258);
            this.txt_kytu.Name = "txt_kytu";
            this.txt_kytu.Size = new System.Drawing.Size(217, 34);
            this.txt_kytu.TabIndex = 55;
            // 
            // cbo_phuongthuctim
            // 
            this.cbo_phuongthuctim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_phuongthuctim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phuongthuctim.FormattingEnabled = true;
            this.cbo_phuongthuctim.Items.AddRange(new object[] {
            "Mã Khuyến Mãi",
            "Tên Khuyến Mãi"});
            this.cbo_phuongthuctim.Location = new System.Drawing.Point(256, 255);
            this.cbo_phuongthuctim.Name = "cbo_phuongthuctim";
            this.cbo_phuongthuctim.Size = new System.Drawing.Size(223, 37);
            this.cbo_phuongthuctim.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 29);
            this.label6.TabIndex = 53;
            this.label6.Text = "Phương Thức Tìm";
            // 
            // dgv_khuyenmai
            // 
            this.dgv_khuyenmai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khuyenmai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_khuyenmai.Location = new System.Drawing.Point(0, 318);
            this.dgv_khuyenmai.Name = "dgv_khuyenmai";
            this.dgv_khuyenmai.RowHeadersWidth = 51;
            this.dgv_khuyenmai.RowTemplate.Height = 24;
            this.dgv_khuyenmai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_khuyenmai.Size = new System.Drawing.Size(1177, 315);
            this.dgv_khuyenmai.TabIndex = 52;
            this.dgv_khuyenmai.Click += new System.EventHandler(this.dgv_khuyenmai_Click);
            // 
            // txt_tenkm
            // 
            this.txt_tenkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkm.Location = new System.Drawing.Point(212, 143);
            this.txt_tenkm.Name = "txt_tenkm";
            this.txt_tenkm.Size = new System.Drawing.Size(217, 34);
            this.txt_tenkm.TabIndex = 50;
            // 
            // txt_makm
            // 
            this.txt_makm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makm.Location = new System.Drawing.Point(212, 89);
            this.txt_makm.Name = "txt_makm";
            this.txt_makm.Size = new System.Drawing.Size(217, 34);
            this.txt_makm.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tên Khuyến Mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã Khuyến Mãi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(348, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 52);
            this.label1.TabIndex = 44;
            this.label1.Text = "Quản Trị Khuyến Mãi";
            // 
            // dtp_ngayketthuc
            // 
            this.dtp_ngayketthuc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayketthuc.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayketthuc.Location = new System.Drawing.Point(633, 91);
            this.dtp_ngayketthuc.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_ngayketthuc.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
            this.dtp_ngayketthuc.Size = new System.Drawing.Size(218, 32);
            this.dtp_ngayketthuc.TabIndex = 67;
            this.dtp_ngayketthuc.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 29);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ngày Kết Thúc";
            // 
            // txt_dieukien
            // 
            this.txt_dieukien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dieukien.Location = new System.Drawing.Point(634, 162);
            this.txt_dieukien.Name = "txt_dieukien";
            this.txt_dieukien.Size = new System.Drawing.Size(217, 34);
            this.txt_dieukien.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 68;
            this.label5.Text = "Điều Kiện";
            // 
            // Frm_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 633);
            this.Controls.Add(this.txt_dieukien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_ngayketthuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_ngaybatdau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_kytu);
            this.Controls.Add(this.cbo_phuongthuctim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_khuyenmai);
            this.Controls.Add(this.txt_tenkm);
            this.Controls.Add(this.txt_makm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_KhuyenMai";
            this.Text = "Frm_KhuyenMai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_KhuyenMai_FormClosing);
            this.Load += new System.EventHandler(this.Frm_KhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khuyenmai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_ngaybatdau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_kytu;
        private System.Windows.Forms.ComboBox cbo_phuongthuctim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_khuyenmai;
        private System.Windows.Forms.TextBox txt_tenkm;
        private System.Windows.Forms.TextBox txt_makm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ngayketthuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dieukien;
        private System.Windows.Forms.Label label5;
    }
}