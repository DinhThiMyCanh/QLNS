namespace QLNS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHSL = new System.Windows.Forms.TextBox();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtHSL);
            this.panel1.Controls.Add(this.cboPhongBan);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(91, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 289);
            this.panel1.TabIndex = 0;
            // 
            // txtHSL
            // 
            this.txtHSL.Location = new System.Drawing.Point(173, 168);
            this.txtHSL.Name = "txtHSL";
            this.txtHSL.Size = new System.Drawing.Size(237, 35);
            this.txtHSL.TabIndex = 7;
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(173, 116);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(237, 37);
            this.cboPhongBan.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(173, 68);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(237, 35);
            this.txtHoTen.TabIndex = 5;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(173, 24);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(237, 35);
            this.txtMaNV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hệ số lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Location = new System.Drawing.Point(22, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cán bộ";
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(6, 34);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 62;
            this.data.Size = new System.Drawing.Size(727, 163);
            this.data.TabIndex = 0;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Location = new System.Drawing.Point(19, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(477, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 37);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(136, 25);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(312, 35);
            this.txtTen.TabIndex = 0;
            this.txtTen.Text = "Nhập tên nhân viên cần tìm";
            this.txtTen.Click += new System.EventHandler(this.txtTen_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(614, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 289);
            this.panel2.TabIndex = 3;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(13, 226);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(127, 42);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(13, 171);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(127, 42);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(13, 117);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(13, 57);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 46);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHSL;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
    }
}

