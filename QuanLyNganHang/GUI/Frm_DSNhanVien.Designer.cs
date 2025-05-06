namespace GUI
{
    partial class Frm_DSNhanVien
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
            this.cbo_TimCN = new System.Windows.Forms.ComboBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_TuKhoa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_PhuongThucTim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Xem = new System.Windows.Forms.ComboBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.crv_NhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rpt_DSNhanVien1 = new GUI.Report.Rpt_DSNhanVien();
            this.SuspendLayout();
            // 
            // cbo_TimCN
            // 
            this.cbo_TimCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TimCN.FormattingEnabled = true;
            this.cbo_TimCN.Location = new System.Drawing.Point(773, 21);
            this.cbo_TimCN.Name = "cbo_TimCN";
            this.cbo_TimCN.Size = new System.Drawing.Size(282, 29);
            this.cbo_TimCN.TabIndex = 62;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(1061, 21);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 29);
            this.btn_Tim.TabIndex = 61;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_TuKhoa
            // 
            this.txt_TuKhoa.Location = new System.Drawing.Point(773, 21);
            this.txt_TuKhoa.Name = "txt_TuKhoa";
            this.txt_TuKhoa.Size = new System.Drawing.Size(282, 29);
            this.txt_TuKhoa.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(324, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 21);
            this.label12.TabIndex = 59;
            this.label12.Text = "Phương Thức Tìm";
            // 
            // cbo_PhuongThucTim
            // 
            this.cbo_PhuongThucTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PhuongThucTim.FormattingEnabled = true;
            this.cbo_PhuongThucTim.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Tên Nhân Viên",
            "SĐT",
            "Chi Nhánh"});
            this.cbo_PhuongThucTim.Location = new System.Drawing.Point(485, 21);
            this.cbo_PhuongThucTim.Name = "cbo_PhuongThucTim";
            this.cbo_PhuongThucTim.Size = new System.Drawing.Size(282, 29);
            this.cbo_PhuongThucTim.TabIndex = 58;
            this.cbo_PhuongThucTim.SelectedIndexChanged += new System.EventHandler(this.cbo_PhuongThucTim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Xem";
            // 
            // cbo_Xem
            // 
            this.cbo_Xem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Xem.FormattingEnabled = true;
            this.cbo_Xem.Items.AddRange(new object[] {
            "Danh Sách Nhân Viên",
            "Chi Tiết Nhân Viên"});
            this.cbo_Xem.Location = new System.Drawing.Point(63, 21);
            this.cbo_Xem.Name = "cbo_Xem";
            this.cbo_Xem.Size = new System.Drawing.Size(246, 29);
            this.cbo_Xem.TabIndex = 64;
            this.cbo_Xem.TextChanged += new System.EventHandler(this.cbo_Xem_TextChanged);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(1142, 21);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(95, 29);
            this.btn_LamMoi.TabIndex = 65;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // crv_NhanVien
            // 
            this.crv_NhanVien.ActiveViewIndex = 0;
            this.crv_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_NhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_NhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_NhanVien.Location = new System.Drawing.Point(0, 69);
            this.crv_NhanVien.Name = "crv_NhanVien";
            this.crv_NhanVien.ReportSource = this.Rpt_DSNhanVien1;
            this.crv_NhanVien.Size = new System.Drawing.Size(1249, 485);
            this.crv_NhanVien.TabIndex = 66;
            // 
            // Frm_DSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 554);
            this.Controls.Add(this.crv_NhanVien);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.cbo_Xem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_TimCN);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_TuKhoa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbo_PhuongThucTim);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_DSNhanVien";
            this.Text = "Frm_DSNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DSNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.Frm_DSNhanVien_Load);
            this.Resize += new System.EventHandler(this.Frm_DSNhanVien_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_TimCN;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_TuKhoa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_PhuongThucTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Xem;
        private System.Windows.Forms.Button btn_LamMoi;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_NhanVien;
        private Report.Rpt_DSNhanVien Rpt_DSNhanVien1;
    }
}