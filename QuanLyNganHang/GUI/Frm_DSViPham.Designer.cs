namespace GUI
{
    partial class Frm_DSViPham
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
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.cbo_Xem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_TimNV = new System.Windows.Forms.ComboBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_TuKhoa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_PhuongThucTim = new System.Windows.Forms.ComboBox();
            this.crv_ViPham = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rpt_DSViPham1 = new GUI.Report.Rpt_DSViPham();
            this.dtp_Tim = new System.Windows.Forms.DateTimePicker();
            this.cbo_TimMoTa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(1140, 12);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(95, 29);
            this.btn_LamMoi.TabIndex = 73;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // cbo_Xem
            // 
            this.cbo_Xem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Xem.FormattingEnabled = true;
            this.cbo_Xem.Items.AddRange(new object[] {
            "Danh Sách Vi Phạm",
            "Chi Tiết Vi Phạm"});
            this.cbo_Xem.Location = new System.Drawing.Point(61, 12);
            this.cbo_Xem.Name = "cbo_Xem";
            this.cbo_Xem.Size = new System.Drawing.Size(246, 29);
            this.cbo_Xem.TabIndex = 72;
            this.cbo_Xem.SelectedIndexChanged += new System.EventHandler(this.cbo_Xem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Xem";
            // 
            // cbo_TimNV
            // 
            this.cbo_TimNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TimNV.FormattingEnabled = true;
            this.cbo_TimNV.Location = new System.Drawing.Point(771, 12);
            this.cbo_TimNV.Name = "cbo_TimNV";
            this.cbo_TimNV.Size = new System.Drawing.Size(282, 29);
            this.cbo_TimNV.TabIndex = 70;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(1059, 12);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 29);
            this.btn_Tim.TabIndex = 69;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_TuKhoa
            // 
            this.txt_TuKhoa.Location = new System.Drawing.Point(771, 12);
            this.txt_TuKhoa.Name = "txt_TuKhoa";
            this.txt_TuKhoa.Size = new System.Drawing.Size(282, 29);
            this.txt_TuKhoa.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 21);
            this.label12.TabIndex = 67;
            this.label12.Text = "Phương Thức Tìm";
            // 
            // cbo_PhuongThucTim
            // 
            this.cbo_PhuongThucTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PhuongThucTim.FormattingEnabled = true;
            this.cbo_PhuongThucTim.Items.AddRange(new object[] {
            "Mã Vi Phạm",
            "Tên Nhân Viên",
            "Mô Tả",
            "Ngày Vi Phạm"});
            this.cbo_PhuongThucTim.Location = new System.Drawing.Point(483, 12);
            this.cbo_PhuongThucTim.Name = "cbo_PhuongThucTim";
            this.cbo_PhuongThucTim.Size = new System.Drawing.Size(282, 29);
            this.cbo_PhuongThucTim.TabIndex = 66;
            this.cbo_PhuongThucTim.SelectedIndexChanged += new System.EventHandler(this.cbo_PhuongThucTim_SelectedIndexChanged);
            // 
            // crv_ViPham
            // 
            this.crv_ViPham.ActiveViewIndex = 0;
            this.crv_ViPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_ViPham.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_ViPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_ViPham.Location = new System.Drawing.Point(0, 83);
            this.crv_ViPham.Name = "crv_ViPham";
            this.crv_ViPham.ReportSource = this.Rpt_DSViPham1;
            this.crv_ViPham.Size = new System.Drawing.Size(1249, 540);
            this.crv_ViPham.TabIndex = 74;
            // 
            // dtp_Tim
            // 
            this.dtp_Tim.CustomFormat = "dd/MM/yyyy";
            this.dtp_Tim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Tim.Location = new System.Drawing.Point(771, 12);
            this.dtp_Tim.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_Tim.Name = "dtp_Tim";
            this.dtp_Tim.Size = new System.Drawing.Size(282, 29);
            this.dtp_Tim.TabIndex = 75;
            // 
            // cbo_TimMoTa
            // 
            this.cbo_TimMoTa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TimMoTa.FormattingEnabled = true;
            this.cbo_TimMoTa.Location = new System.Drawing.Point(771, 12);
            this.cbo_TimMoTa.Name = "cbo_TimMoTa";
            this.cbo_TimMoTa.Size = new System.Drawing.Size(282, 29);
            this.cbo_TimMoTa.TabIndex = 76;
            // 
            // Frm_DSViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 623);
            this.Controls.Add(this.cbo_TimMoTa);
            this.Controls.Add(this.dtp_Tim);
            this.Controls.Add(this.crv_ViPham);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.cbo_Xem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_TimNV);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_TuKhoa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbo_PhuongThucTim);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_DSViPham";
            this.Text = "Frm_DSViPham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DSViPham_FormClosing);
            this.Load += new System.EventHandler(this.Frm_DSViPham_Load);
            this.Resize += new System.EventHandler(this.Frm_DSViPham_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.ComboBox cbo_Xem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_TimNV;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_TuKhoa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_PhuongThucTim;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_ViPham;
        private Report.Rpt_DSViPham Rpt_DSViPham1;
        private System.Windows.Forms.DateTimePicker dtp_Tim;
        private System.Windows.Forms.ComboBox cbo_TimMoTa;
    }
}