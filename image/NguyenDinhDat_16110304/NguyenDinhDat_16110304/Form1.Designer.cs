namespace WindowsFormsApp2
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvTHANHPHO = new System.Windows.Forms.DataGridView();
            this.ThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenThanhPho = new System.Windows.Forms.TextBox();
            this.txtMaThanhPho = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANHPHO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnXoa);
            this.panel.Controls.Add(this.btnHuy);
            this.panel.Controls.Add(this.btnLuu);
            this.panel.Controls.Add(this.btnSua);
            this.panel.Controls.Add(this.btnThem);
            this.panel.Controls.Add(this.dgvTHANHPHO);
            this.panel.Controls.Add(this.btnReload);
            this.panel.Controls.Add(this.btnThoat);
            this.panel.Controls.Add(this.panel1);
            this.panel.Location = new System.Drawing.Point(2, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(799, 444);
            this.panel.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(630, 360);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 50);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(456, 360);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 50);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(346, 360);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 50);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(149, 360);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 50);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 360);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 50);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvTHANHPHO
            // 
            this.dgvTHANHPHO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHANHPHO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThanhPho,
            this.TenThanhPho});
            this.dgvTHANHPHO.Location = new System.Drawing.Point(48, 143);
            this.dgvTHANHPHO.Name = "dgvTHANHPHO";
            this.dgvTHANHPHO.Size = new System.Drawing.Size(685, 150);
            this.dgvTHANHPHO.TabIndex = 3;
            // 
            // ThanhPho
            // 
            this.ThanhPho.DataPropertyName = "MaThanhPho";
            this.ThanhPho.HeaderText = "Thành Phố";
            this.ThanhPho.Name = "ThanhPho";
            this.ThanhPho.Width = 200;
            // 
            // TenThanhPho
            // 
            this.TenThanhPho.DataPropertyName = "TenThanhPho";
            this.TenThanhPho.HeaderText = "Tên Thành Phố";
            this.TenThanhPho.Name = "TenThanhPho";
            this.TenThanhPho.Width = 300;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(630, 75);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(93, 50);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(630, 9);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 51);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenThanhPho);
            this.panel1.Controls.Add(this.txtMaThanhPho);
            this.panel1.Location = new System.Drawing.Point(38, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 116);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Thành Phố : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thành Phố :";
            // 
            // txtTenThanhPho
            // 
            this.txtTenThanhPho.Location = new System.Drawing.Point(177, 66);
            this.txtTenThanhPho.Name = "txtTenThanhPho";
            this.txtTenThanhPho.Size = new System.Drawing.Size(223, 20);
            this.txtTenThanhPho.TabIndex = 1;
            // 
            // txtMaThanhPho
            // 
            this.txtMaThanhPho.Location = new System.Drawing.Point(177, 22);
            this.txtMaThanhPho.Name = "txtMaThanhPho";
            this.txtMaThanhPho.Size = new System.Drawing.Size(153, 20);
            this.txtMaThanhPho.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANHPHO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvTHANHPHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThanhPho;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenThanhPho;
        private System.Windows.Forms.TextBox txtMaThanhPho;
    }
}

