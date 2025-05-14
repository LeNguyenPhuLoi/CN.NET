namespace GUI
{
    partial class frmLoaiTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiTaiKhoan));
            this.dgvLoaiTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenNH = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiTaiKhoan
            // 
            this.dgvLoaiTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoaiTaiKhoan.Location = new System.Drawing.Point(0, 232);
            this.dgvLoaiTaiKhoan.Name = "dgvLoaiTaiKhoan";
            this.dgvLoaiTaiKhoan.RowHeadersWidth = 51;
            this.dgvLoaiTaiKhoan.RowTemplate.Height = 24;
            this.dgvLoaiTaiKhoan.Size = new System.Drawing.Size(503, 218);
            this.dgvLoaiTaiKhoan.TabIndex = 47;
            this.dgvLoaiTaiKhoan.Click += new System.EventHandler(this.dgvLoaiTaiKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(387, 139);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 40);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(296, 139);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 40);
            this.btnLamMoi.TabIndex = 45;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(205, 139);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 40);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(114, 139);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 40);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 139);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 40);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenNH
            // 
            this.txtTenNH.Location = new System.Drawing.Point(205, 93);
            this.txtTenNH.Name = "txtTenNH";
            this.txtTenNH.Size = new System.Drawing.Size(267, 22);
            this.txtTenNH.TabIndex = 41;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(205, 42);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(185, 22);
            this.txtMaLoai.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên Ngân hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã Loại Tại Khoản:";
            // 
            // frmLoaiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.dgvLoaiTaiKhoan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenNH);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoaiTaiKhoan";
            this.Text = "Thông Tin Loại Tài Khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiTaiKhoan_FormClosing);
            this.Load += new System.EventHandler(this.LoaiTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenNH;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}