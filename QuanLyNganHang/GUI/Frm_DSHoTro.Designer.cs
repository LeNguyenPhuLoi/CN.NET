namespace GUI
{
    partial class Frm_DSHoTro
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
            this.cbo_kieuxem = new System.Windows.Forms.ComboBox();
            this.cbo_tim = new System.Windows.Forms.ComboBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.crv_hotro = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rpt_DSHoTro1 = new GUI.Report.Rpt_DSHoTro();
            this.cbo_dvht = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIỂU XEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "PHƯƠNG THỨC TÌM";
            // 
            // cbo_kieuxem
            // 
            this.cbo_kieuxem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_kieuxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_kieuxem.FormattingEnabled = true;
            this.cbo_kieuxem.Items.AddRange(new object[] {
            "DS Hỗ Trợ",
            "Tìm Hỗ Trợ"});
            this.cbo_kieuxem.Location = new System.Drawing.Point(133, 17);
            this.cbo_kieuxem.Name = "cbo_kieuxem";
            this.cbo_kieuxem.Size = new System.Drawing.Size(210, 33);
            this.cbo_kieuxem.TabIndex = 2;
            this.cbo_kieuxem.TextChanged += new System.EventHandler(this.cbo_kieuxem_TextChanged);
            // 
            // cbo_tim
            // 
            this.cbo_tim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tim.FormattingEnabled = true;
            this.cbo_tim.Items.AddRange(new object[] {
            "Mã Khách Hàng",
            "DVHT"});
            this.cbo_tim.Location = new System.Drawing.Point(581, 22);
            this.cbo_tim.Name = "cbo_tim";
            this.cbo_tim.Size = new System.Drawing.Size(203, 33);
            this.cbo_tim.TabIndex = 3;
            this.cbo_tim.TextChanged += new System.EventHandler(this.cbo_tim_TextChanged);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(1064, 25);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(124, 32);
            this.btn_lammoi.TabIndex = 4;
            this.btn_lammoi.Text = "LÀM MỚI";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(1198, 25);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(87, 34);
            this.btn_tim.TabIndex = 5;
            this.btn_tim.Text = "TÌM";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(790, 22);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(224, 30);
            this.txt_tim.TabIndex = 6;
            // 
            // crv_hotro
            // 
            this.crv_hotro.ActiveViewIndex = 0;
            this.crv_hotro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_hotro.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_hotro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_hotro.Location = new System.Drawing.Point(0, 65);
            this.crv_hotro.Name = "crv_hotro";
            this.crv_hotro.ReportSource = this.Rpt_DSHoTro1;
            this.crv_hotro.Size = new System.Drawing.Size(1297, 539);
            this.crv_hotro.TabIndex = 7;
            // 
            // cbo_dvht
            // 
            this.cbo_dvht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_dvht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_dvht.FormattingEnabled = true;
            this.cbo_dvht.Items.AddRange(new object[] {
            "THÔNG DỊCH THỊ TRƯỜNG",
            "TƯ VẤN ĐẦU TƯ",
            "GIAO DỊCH NGOẠI TỆ",
            "NẠP TIỀN",
            "CHUYỂN KHOẢN",
            "TẠO TÀI KHOẢN"});
            this.cbo_dvht.Location = new System.Drawing.Point(790, 22);
            this.cbo_dvht.Name = "cbo_dvht";
            this.cbo_dvht.Size = new System.Drawing.Size(224, 30);
            this.cbo_dvht.TabIndex = 8;
            // 
            // Frm_DSHoTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 604);
            this.Controls.Add(this.cbo_dvht);
            this.Controls.Add(this.crv_hotro);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.cbo_tim);
            this.Controls.Add(this.cbo_kieuxem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DSHoTro";
            this.Text = "Frm_DSHoTro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DSHoTro_FormClosing);
            this.Load += new System.EventHandler(this.Frm_DSHoTro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_kieuxem;
        private System.Windows.Forms.ComboBox cbo_tim;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_hotro;
        private Report.Rpt_DSHoTro Rpt_DSHoTro1;
        private System.Windows.Forms.ComboBox cbo_dvht;
    }
}