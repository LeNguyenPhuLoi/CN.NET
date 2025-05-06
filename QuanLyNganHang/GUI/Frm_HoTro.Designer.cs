namespace GUI
{
    partial class Frm_HoTro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.dgv_hotro = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_phuongthuctim = new System.Windows.Forms.ComboBox();
            this.txt_kytu = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cbo_dvht = new System.Windows.Forms.ComboBox();
            this.cbo_timdvht = new System.Windows.Forms.ComboBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_makm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hotro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(395, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Trị Hỗ Trợ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dịch Vụ Hỗ Trợ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Khuyến Mãi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(259, 105);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(217, 34);
            this.txt_makh.TabIndex = 5;
            // 
            // dgv_hotro
            // 
            this.dgv_hotro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hotro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hotro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_hotro.Location = new System.Drawing.Point(0, 339);
            this.dgv_hotro.Name = "dgv_hotro";
            this.dgv_hotro.RowHeadersWidth = 51;
            this.dgv_hotro.RowTemplate.Height = 24;
            this.dgv_hotro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hotro.Size = new System.Drawing.Size(1325, 277);
            this.dgv_hotro.TabIndex = 9;
            this.dgv_hotro.Click += new System.EventHandler(this.dgv_hotro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phương Thức Tìm";
            // 
            // cbo_phuongthuctim
            // 
            this.cbo_phuongthuctim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phuongthuctim.FormattingEnabled = true;
            this.cbo_phuongthuctim.Items.AddRange(new object[] {
            "Mã Khách Hàng",
            "DVHT"});
            this.cbo_phuongthuctim.Location = new System.Drawing.Point(303, 271);
            this.cbo_phuongthuctim.Name = "cbo_phuongthuctim";
            this.cbo_phuongthuctim.Size = new System.Drawing.Size(223, 37);
            this.cbo_phuongthuctim.TabIndex = 11;
            this.cbo_phuongthuctim.TextChanged += new System.EventHandler(this.cbo_phuongthuctim_TextChanged);
            // 
            // txt_kytu
            // 
            this.txt_kytu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kytu.Location = new System.Drawing.Point(538, 274);
            this.txt_kytu.Name = "txt_kytu";
            this.txt_kytu.Size = new System.Drawing.Size(217, 34);
            this.txt_kytu.TabIndex = 12;
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(782, 274);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 34);
            this.btn_tim.TabIndex = 13;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(907, 100);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 34);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(1032, 100);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 34);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(1156, 100);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 34);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(949, 179);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(115, 34);
            this.btn_lammoi.TabIndex = 17;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(1093, 179);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(115, 34);
            this.btn_thoat.TabIndex = 18;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbo_dvht
            // 
            this.cbo_dvht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_dvht.FormattingEnabled = true;
            this.cbo_dvht.Items.AddRange(new object[] {
            "THÔNG DỊCH THỊ TRƯỜNG",
            "TƯ VẤN ĐẦU TƯ",
            "GIAO DỊCH NGOẠI TỆ",
            "NẠP TIỀN",
            "CHUYỂN KHOẢN",
            "TẠO TÀI KHOẢN"});
            this.cbo_dvht.Location = new System.Drawing.Point(253, 193);
            this.cbo_dvht.Name = "cbo_dvht";
            this.cbo_dvht.Size = new System.Drawing.Size(217, 33);
            this.cbo_dvht.TabIndex = 0;
            // 
            // cbo_timdvht
            // 
            this.cbo_timdvht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_timdvht.FormattingEnabled = true;
            this.cbo_timdvht.Items.AddRange(new object[] {
            "THÔNG DỊCH THỊ TRƯỜNG",
            "TƯ VẤN ĐẦU TƯ",
            "GIAO DỊCH NGOẠI TỆ",
            "NẠP TIỀN",
            "CHUYỂN KHOẢN",
            "TẠO TÀI KHOẢN"});
            this.cbo_timdvht.Location = new System.Drawing.Point(538, 274);
            this.cbo_timdvht.Name = "cbo_timdvht";
            this.cbo_timdvht.Size = new System.Drawing.Size(217, 33);
            this.cbo_timdvht.TabIndex = 21;
            // 
            // txt_manv
            // 
            this.txt_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.Location = new System.Drawing.Point(697, 105);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(189, 30);
            this.txt_manv.TabIndex = 22;
            // 
            // txt_makm
            // 
            this.txt_makm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makm.Location = new System.Drawing.Point(697, 200);
            this.txt_makm.Name = "txt_makm";
            this.txt_makm.Size = new System.Drawing.Size(189, 30);
            this.txt_makm.TabIndex = 23;
            // 
            // Frm_HoTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 616);
            this.Controls.Add(this.txt_makm);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.cbo_timdvht);
            this.Controls.Add(this.cbo_dvht);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_kytu);
            this.Controls.Add(this.cbo_phuongthuctim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_hotro);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_HoTro";
            this.Text = "Frm_HoTro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_HoTro_FormClosing);
            this.Load += new System.EventHandler(this.Frm_HoTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hotro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.DataGridView dgv_hotro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_phuongthuctim;
        private System.Windows.Forms.TextBox txt_kytu;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cbo_dvht;
        private System.Windows.Forms.ComboBox cbo_timdvht;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_makm;
    }
}