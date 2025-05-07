namespace GUI
{
    partial class Frm_BienLai
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
            this.dtp_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_kytu = new System.Windows.Forms.TextBox();
            this.cbo_phuongthuctim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_bienlai = new System.Windows.Forms.DataGridView();
            this.txt_sotien = new System.Windows.Forms.TextBox();
            this.txt_loaibl = new System.Windows.Forms.TextBox();
            this.txt_mabl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_timbl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bienlai)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaylap.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaylap.Location = new System.Drawing.Point(642, 91);
            this.dtp_ngaylap.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaylap.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(218, 32);
            this.dtp_ngaylap.TabIndex = 65;
            this.dtp_ngaylap.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 29);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ngày Lập";
            // 
            // txt_manv
            // 
            this.txt_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.Location = new System.Drawing.Point(639, 141);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(217, 34);
            this.txt_manv.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(463, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 29);
            this.label7.TabIndex = 62;
            this.label7.Text = "Mã Nhân Viên";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(1053, 163);
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
            this.btn_lammoi.Location = new System.Drawing.Point(909, 163);
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
            this.btn_xoa.Location = new System.Drawing.Point(1116, 84);
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
            this.btn_sua.Location = new System.Drawing.Point(992, 84);
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
            this.btn_them.Location = new System.Drawing.Point(867, 84);
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
            this.btn_tim.Location = new System.Drawing.Point(742, 258);
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
            this.txt_kytu.Location = new System.Drawing.Point(498, 258);
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
            "Mã Biên Lai",
            "Loại Biên Lai",
            "Mã Nhân Viên",
            "Mã Khách Hàng"});
            this.cbo_phuongthuctim.Location = new System.Drawing.Point(263, 255);
            this.cbo_phuongthuctim.Name = "cbo_phuongthuctim";
            this.cbo_phuongthuctim.Size = new System.Drawing.Size(223, 37);
            this.cbo_phuongthuctim.TabIndex = 54;
            this.cbo_phuongthuctim.TextChanged += new System.EventHandler(this.cbo_phuongthuctim_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 29);
            this.label6.TabIndex = 53;
            this.label6.Text = "Phương Thức Tìm";
            // 
            // dgv_bienlai
            // 
            this.dgv_bienlai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bienlai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bienlai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_bienlai.Location = new System.Drawing.Point(0, 337);
            this.dgv_bienlai.Name = "dgv_bienlai";
            this.dgv_bienlai.RowHeadersWidth = 51;
            this.dgv_bienlai.RowTemplate.Height = 24;
            this.dgv_bienlai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bienlai.Size = new System.Drawing.Size(1190, 315);
            this.dgv_bienlai.TabIndex = 52;
            this.dgv_bienlai.Click += new System.EventHandler(this.dgv_bienlai_Click);
            // 
            // txt_sotien
            // 
            this.txt_sotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotien.Location = new System.Drawing.Point(219, 190);
            this.txt_sotien.Name = "txt_sotien";
            this.txt_sotien.Size = new System.Drawing.Size(217, 34);
            this.txt_sotien.TabIndex = 51;
            // 
            // txt_loaibl
            // 
            this.txt_loaibl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loaibl.Location = new System.Drawing.Point(219, 143);
            this.txt_loaibl.Name = "txt_loaibl";
            this.txt_loaibl.Size = new System.Drawing.Size(217, 34);
            this.txt_loaibl.TabIndex = 50;
            // 
            // txt_mabl
            // 
            this.txt_mabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mabl.Location = new System.Drawing.Point(219, 89);
            this.txt_mabl.Name = "txt_mabl";
            this.txt_mabl.Size = new System.Drawing.Size(217, 34);
            this.txt_mabl.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "Số Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Loại Biên Lai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã Biên Lai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(355, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 52);
            this.label1.TabIndex = 44;
            this.label1.Text = "Quản Trị Biên Lai";
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(639, 190);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(217, 34);
            this.txt_makh.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // cbo_timbl
            // 
            this.cbo_timbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_timbl.FormattingEnabled = true;
            this.cbo_timbl.Items.AddRange(new object[] {
            "CỔ PHIẾU",
            "ĐỔI NGOẠI TỆ",
            "NẠP TIỀN",
            "CHUYỂN KHOẢN",
            "TẠO TÀI KHOẢN"});
            this.cbo_timbl.Location = new System.Drawing.Point(498, 258);
            this.cbo_timbl.Name = "cbo_timbl";
            this.cbo_timbl.Size = new System.Drawing.Size(217, 33);
            this.cbo_timbl.TabIndex = 68;
            // 
            // Frm_BienLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 652);
            this.Controls.Add(this.cbo_timbl);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_ngaylap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_kytu);
            this.Controls.Add(this.cbo_phuongthuctim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_bienlai);
            this.Controls.Add(this.txt_sotien);
            this.Controls.Add(this.txt_loaibl);
            this.Controls.Add(this.txt_mabl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_BienLai";
            this.Text = "Frm_BienLai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_BienLai_FormClosing);
            this.Load += new System.EventHandler(this.Frm_BienLai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bienlai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_ngaylap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_kytu;
        private System.Windows.Forms.ComboBox cbo_phuongthuctim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_bienlai;
        private System.Windows.Forms.TextBox txt_sotien;
        private System.Windows.Forms.TextBox txt_loaibl;
        private System.Windows.Forms.TextBox txt_mabl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_timbl;
    }
}