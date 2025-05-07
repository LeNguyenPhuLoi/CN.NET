namespace GUI
{
    partial class Frm_DSKhachHang
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
            this.cbo_kieuxem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_tim = new System.Windows.Forms.ComboBox();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.crv_khachhang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rpt_DSKhachHang2 = new GUI.Report.Rpt_DSKhachHang();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểu Xem";
            // 
            // cbo_kieuxem
            // 
            this.cbo_kieuxem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_kieuxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_kieuxem.FormattingEnabled = true;
            this.cbo_kieuxem.Items.AddRange(new object[] {
            "DS Khách Hàng",
            "Tìm Khách Hàng"});
            this.cbo_kieuxem.Location = new System.Drawing.Point(113, 16);
            this.cbo_kieuxem.Name = "cbo_kieuxem";
            this.cbo_kieuxem.Size = new System.Drawing.Size(211, 33);
            this.cbo_kieuxem.TabIndex = 1;
            this.cbo_kieuxem.TextChanged += new System.EventHandler(this.cbo_kieuxem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phương Thức Tìm";
            // 
            // cbo_tim
            // 
            this.cbo_tim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tim.FormattingEnabled = true;
            this.cbo_tim.Items.AddRange(new object[] {
            "Mã Khách Hàng",
            "Tên Khách Hàng",
            "SĐT Khách Hàng"});
            this.cbo_tim.Location = new System.Drawing.Point(519, 14);
            this.cbo_tim.Name = "cbo_tim";
            this.cbo_tim.Size = new System.Drawing.Size(253, 33);
            this.cbo_tim.TabIndex = 3;
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(778, 15);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(204, 30);
            this.txt_tim.TabIndex = 4;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(988, 13);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(119, 39);
            this.btn_lammoi.TabIndex = 5;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(1130, 14);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(119, 38);
            this.btn_tim.TabIndex = 6;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // crv_khachhang
            // 
            this.crv_khachhang.ActiveViewIndex = 0;
            this.crv_khachhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_khachhang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_khachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_khachhang.Location = new System.Drawing.Point(0, 57);
            this.crv_khachhang.Name = "crv_khachhang";
            this.crv_khachhang.ReportSource = this.Rpt_DSKhachHang2;
            this.crv_khachhang.Size = new System.Drawing.Size(1270, 526);
            this.crv_khachhang.TabIndex = 7;
            // 
            // Frm_DSKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 583);
            this.Controls.Add(this.crv_khachhang);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.cbo_tim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_kieuxem);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DSKhachHang";
            this.Text = "Frm_DSKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DSKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.Frm_DSKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_kieuxem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_tim;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_khachhang;
        private Report.Rpt_DSKhachHang Rpt_DSKhachHang2;
    }
}