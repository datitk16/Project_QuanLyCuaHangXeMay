namespace MoHinh3Tang
{
    partial class fmSanPham
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sadasdsad = new System.Windows.Forms.Label();
            this.adsasdsa = new System.Windows.Forms.Label();
            this.adsad = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.btnReaalod = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 15);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1164, 214);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.DonViTinh,
            this.DonGia,
            this.Hinh});
            this.dataGridView1.Location = new System.Drawing.Point(20, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1162, 303);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 230;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 230;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 200;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình";
            this.Hinh.Name = "Hinh";
            this.Hinh.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // sadasdsad
            // 
            this.sadasdsad.AutoSize = true;
            this.sadasdsad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sadasdsad.Location = new System.Drawing.Point(32, 105);
            this.sadasdsad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sadasdsad.Name = "sadasdsad";
            this.sadasdsad.Size = new System.Drawing.Size(79, 16);
            this.sadasdsad.TabIndex = 4;
            this.sadasdsad.Text = "Đơn vị tính";
            // 
            // adsasdsa
            // 
            this.adsasdsa.AutoSize = true;
            this.adsasdsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsasdsa.Location = new System.Drawing.Point(32, 137);
            this.adsasdsa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adsasdsa.Name = "adsasdsa";
            this.adsasdsa.Size = new System.Drawing.Size(63, 16);
            this.adsasdsa.TabIndex = 5;
            this.adsasdsa.Text = "Đơn Giá";
            // 
            // adsad
            // 
            this.adsad.AutoSize = true;
            this.adsad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsad.Location = new System.Drawing.Point(32, 178);
            this.adsad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adsad.Name = "adsad";
            this.adsad.Size = new System.Drawing.Size(39, 16);
            this.adsad.TabIndex = 6;
            this.adsad.Text = "Hình";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(224, 29);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(339, 22);
            this.txtMaSanPham.TabIndex = 7;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(224, 65);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(339, 22);
            this.txtTenSanPham.TabIndex = 8;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(224, 99);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(339, 22);
            this.txtDonViTinh.TabIndex = 9;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(224, 137);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(339, 22);
            this.txtDonGia.TabIndex = 10;
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(224, 178);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.Size = new System.Drawing.Size(339, 22);
            this.txtHinh.TabIndex = 11;
            // 
            // btnReaalod
            // 
            this.btnReaalod.Location = new System.Drawing.Point(632, 27);
            this.btnReaalod.Name = "btnReaalod";
            this.btnReaalod.Size = new System.Drawing.Size(75, 23);
            this.btnReaalod.TabIndex = 12;
            this.btnReaalod.Text = "Reload";
            this.btnReaalod.UseVisualStyleBackColor = true;
            this.btnReaalod.Click += new System.EventHandler(this.btnReaalod_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(632, 68);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(632, 116);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(733, 28);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(733, 65);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(733, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(632, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(176, 23);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReaalod);
            this.Controls.Add(this.txtHinh);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.adsad);
            this.Controls.Add(this.adsasdsa);
            this.Controls.Add(this.sadasdsad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmSanPham";
            this.Text = "fmSanPham";
            this.Load += new System.EventHandler(this.fmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sadasdsad;
        private System.Windows.Forms.Label adsasdsa;
        private System.Windows.Forms.Label adsad;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.Button btnReaalod;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
    }
}