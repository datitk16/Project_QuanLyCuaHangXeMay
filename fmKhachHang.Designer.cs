namespace project_QLBanXeMay
{
    partial class fmKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nhanvien = new System.Windows.Forms.Label();
            this.dgvKHachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReaload = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.txtDiaChiKH);
            this.groupBox1.Controls.Add(this.txtSDTKH);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(34, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Khách Hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tìm Kiếm Tên";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(141, 111);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(596, 31);
            this.txtSearch.TabIndex = 16;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(570, 52);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(192, 22);
            this.txtDiaChiKH.TabIndex = 10;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(570, 18);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(192, 22);
            this.txtSDTKH.TabIndex = 9;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(141, 52);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(192, 22);
            this.txtTenKH.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(141, 18);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(192, 22);
            this.txtMaKH.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa Chỉ Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SDT Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // nhanvien
            // 
            this.nhanvien.AutoSize = true;
            this.nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhanvien.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nhanvien.Location = new System.Drawing.Point(343, 34);
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.Size = new System.Drawing.Size(209, 24);
            this.nhanvien.TabIndex = 2;
            this.nhanvien.Text = "Quản Lý Khách Hàng";
            // 
            // dgvKHachHang
            // 
            this.dgvKHachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SDTKH,
            this.DiaChiKH});
            this.dgvKHachHang.Location = new System.Drawing.Point(34, 287);
            this.dgvKHachHang.Name = "dgvKHachHang";
            this.dgvKHachHang.Size = new System.Drawing.Size(513, 387);
            this.dgvKHachHang.TabIndex = 4;
            this.dgvKHachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKHachHang_CellClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 150;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 150;
            // 
            // SDTKH
            // 
            this.SDTKH.DataPropertyName = "SDTKH";
            this.SDTKH.HeaderText = "Số Điện Thoại";
            this.SDTKH.Name = "SDTKH";
            this.SDTKH.Width = 150;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.DataPropertyName = "DiaChiKH";
            this.DiaChiKH.HeaderText = "Địa Chỉ Khách Hàng";
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.Width = 150;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.MediumPurple;
            this.btnHuy.Image = global::project_QLBanXeMay.Properties.Resources.cancel_removebg;
            this.btnHuy.Location = new System.Drawing.Point(721, 597);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 77);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLuu.Image = global::project_QLBanXeMay.Properties.Resources.save__1__removebg__1_;
            this.btnLuu.Location = new System.Drawing.Point(721, 505);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 77);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Pink;
            this.btnThoat.Image = global::project_QLBanXeMay.Properties.Resources.iconExit_removebg;
            this.btnThoat.Location = new System.Drawing.Point(581, 597);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 77);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReaload
            // 
            this.btnReaload.BackColor = System.Drawing.Color.Purple;
            this.btnReaload.Image = global::project_QLBanXeMay.Properties.Resources.iconRealod_removebg;
            this.btnReaload.Location = new System.Drawing.Point(581, 505);
            this.btnReaload.Name = "btnReaload";
            this.btnReaload.Size = new System.Drawing.Size(94, 77);
            this.btnReaload.TabIndex = 15;
            this.btnReaload.UseVisualStyleBackColor = false;
            this.btnReaload.Click += new System.EventHandler(this.btnReaload_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Image = global::project_QLBanXeMay.Properties.Resources.iconSearch_removebg;
            this.btnTimKiem.Location = new System.Drawing.Point(721, 411);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 77);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Image = global::project_QLBanXeMay.Properties.Resources.iconDelete_removebg;
            this.btnXoa.Location = new System.Drawing.Point(581, 411);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 77);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSua.Image = global::project_QLBanXeMay.Properties.Resources.iconEdit_removebg;
            this.btnSua.Location = new System.Drawing.Point(721, 311);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 77);
            this.btnSua.TabIndex = 12;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.Image = global::project_QLBanXeMay.Properties.Resources.iconAdd_removebg;
            this.btnThem.Location = new System.Drawing.Point(581, 311);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 77);
            this.btnThem.TabIndex = 11;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(899, 686);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReaload);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvKHachHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nhanvien);
            this.Name = "fmKhachHang";
            this.Text = "fmKhachHang";
            this.Load += new System.EventHandler(this.fmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nhanvien;
        private System.Windows.Forms.DataGridView dgvKHachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKH;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReaload;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}