namespace GUI
{
    partial class Frm_DSBienLai
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
            this.cbo_loaibl = new System.Windows.Forms.ComboBox();
            this.crv_bienlai = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rpt_DSBienLai1 = new GUI.Report.Rpt_DSBienLai();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIỂU XEM";
            // 
            // cbo_kieuxem
            // 
            this.cbo_kieuxem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_kieuxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_kieuxem.FormattingEnabled = true;
            this.cbo_kieuxem.Items.AddRange(new object[] {
            "DS Biên Lai",
            "Tìm Biên Lai"});
            this.cbo_kieuxem.Location = new System.Drawing.Point(133, 14);
            this.cbo_kieuxem.Name = "cbo_kieuxem";
            this.cbo_kieuxem.Size = new System.Drawing.Size(198, 33);
            this.cbo_kieuxem.TabIndex = 1;
            this.cbo_kieuxem.TextChanged += new System.EventHandler(this.cbo_kieuxem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "PHƯƠNG THỨC TÌM";
            // 
            // cbo_tim
            // 
            this.cbo_tim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tim.FormattingEnabled = true;
            this.cbo_tim.Items.AddRange(new object[] {
            "Mã Biên Lai",
            "Loại Biên Lai",
            "Mã Nhân Viên",
            "Mã Khách Hàng"});
            this.cbo_tim.Location = new System.Drawing.Point(567, 14);
            this.cbo_tim.Name = "cbo_tim";
            this.cbo_tim.Size = new System.Drawing.Size(190, 33);
            this.cbo_tim.TabIndex = 3;
            this.cbo_tim.TextChanged += new System.EventHandler(this.cbo_tim_TextChanged);
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(763, 16);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(186, 30);
            this.txt_tim.TabIndex = 4;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(957, 16);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(129, 35);
            this.btn_lammoi.TabIndex = 5;
            this.btn_lammoi.Text = "LÀM MỚI";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(1092, 16);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(95, 35);
            this.btn_tim.TabIndex = 6;
            this.btn_tim.Text = "TÌM";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // cbo_loaibl
            // 
            this.cbo_loaibl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loaibl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_loaibl.FormattingEnabled = true;
            this.cbo_loaibl.Items.AddRange(new object[] {
            "CỔ PHIẾU",
            "ĐỔI NGOẠI TỆ",
            "NẠP TIỀN",
            "CHUYỂN KHOẢN",
            "TẠO TÀI KHOẢN"});
            this.cbo_loaibl.Location = new System.Drawing.Point(763, 13);
            this.cbo_loaibl.Name = "cbo_loaibl";
            this.cbo_loaibl.Size = new System.Drawing.Size(186, 33);
            this.cbo_loaibl.TabIndex = 8;
            // 
            // crv_bienlai
            // 
            this.crv_bienlai.ActiveViewIndex = 0;
            this.crv_bienlai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_bienlai.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_bienlai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_bienlai.Location = new System.Drawing.Point(0, 57);
            this.crv_bienlai.Name = "crv_bienlai";
            this.crv_bienlai.ReportSource = this.Rpt_DSBienLai1;
            this.crv_bienlai.Size = new System.Drawing.Size(1224, 583);
            this.crv_bienlai.TabIndex = 9;
            // 
            // Frm_DSBienLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 640);
            this.Controls.Add(this.crv_bienlai);
            this.Controls.Add(this.cbo_loaibl);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.cbo_tim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_kieuxem);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DSBienLai";
            this.Text = "Frm_DSBienLai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DSBienLai_FormClosing);
            this.Load += new System.EventHandler(this.Frm_DSBienLai_Load);
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
        private System.Windows.Forms.ComboBox cbo_loaibl;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_bienlai;
        private Report.Rpt_DSBienLai Rpt_DSBienLai1;
    }
}