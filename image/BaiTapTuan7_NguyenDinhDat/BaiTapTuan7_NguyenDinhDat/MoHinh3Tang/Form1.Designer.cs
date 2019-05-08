namespace MoHinh3Tang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvdangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvdangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvnhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvdanhmucsanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvchitiethoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.hóaĐToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dgvdangnhap,
            this.dgvdangxuat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // dgvdangnhap
            // 
            this.dgvdangnhap.Name = "dgvdangnhap";
            this.dgvdangnhap.Size = new System.Drawing.Size(137, 22);
            this.dgvdangnhap.Text = "Đăng Nhập";
            // 
            // dgvdangxuat
            // 
            this.dgvdangxuat.Name = "dgvdangxuat";
            this.dgvdangxuat.Size = new System.Drawing.Size(137, 22);
            this.dgvdangxuat.Text = "Đăng Xuất";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dgvkhachhang,
            this.dgvnhanvien,
            this.dgvdanhmucsanpham,
            this.dgvchitiethoadon,
            this.hóaĐToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.Size = new System.Drawing.Size(196, 22);
            this.dgvkhachhang.Text = "Danh mục khách hàng";
            this.dgvkhachhang.Click += new System.EventHandler(this.dgvkhachhang_Click);
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.Size = new System.Drawing.Size(196, 22);
            this.dgvnhanvien.Text = "Danh mục nhân viên";
            this.dgvnhanvien.Click += new System.EventHandler(this.dgvnhanvien_Click);
            // 
            // dgvdanhmucsanpham
            // 
            this.dgvdanhmucsanpham.Name = "dgvdanhmucsanpham";
            this.dgvdanhmucsanpham.Size = new System.Drawing.Size(196, 22);
            this.dgvdanhmucsanpham.Text = "Danh mục sản phẩm";
            this.dgvdanhmucsanpham.Click += new System.EventHandler(this.dgvdanhmucsanpham_Click);
            // 
            // dgvchitiethoadon
            // 
            this.dgvchitiethoadon.Name = "dgvchitiethoadon";
            this.dgvchitiethoadon.Size = new System.Drawing.Size(196, 22);
            this.dgvchitiethoadon.Text = "Chi tiết hóa đơn";
            this.dgvchitiethoadon.Click += new System.EventHandler(this.dgvchitiethoadon_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(62, 19);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Hệ Thống";
            // 
            // hóaĐToolStripMenuItem
            // 
            this.hóaĐToolStripMenuItem.Name = "hóaĐToolStripMenuItem";
            this.hóaĐToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.hóaĐToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐToolStripMenuItem.Click += new System.EventHandler(this.hóaĐToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người Tạo: Nguyễn Đình Đạt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "MSSV: 16110304";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dgvdangnhap;
        private System.Windows.Forms.ToolStripMenuItem dgvdangxuat;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem dgvkhachhang;
        private System.Windows.Forms.ToolStripMenuItem dgvnhanvien;
        private System.Windows.Forms.ToolStripMenuItem dgvdanhmucsanpham;
        private System.Windows.Forms.ToolStripMenuItem dgvchitiethoadon;
        private System.Windows.Forms.ToolStripMenuItem hóaĐToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

