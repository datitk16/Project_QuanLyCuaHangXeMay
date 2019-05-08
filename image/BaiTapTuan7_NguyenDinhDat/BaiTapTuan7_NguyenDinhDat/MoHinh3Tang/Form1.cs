using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoHinh3Tang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvkhachhang_Click(object sender, EventArgs e)
        {
            fmKhachHang fmain = new fmKhachHang();
            fmain.Show();
            this.Hide();
        }

        private void dgvnhanvien_Click(object sender, EventArgs e)
        {
            frNhanVien fmain = new frNhanVien();
            fmain.Show();
            this.Hide();
        }

        private void dgvdanhmucsanpham_Click(object sender, EventArgs e)
        {
            fmSanPham fmain = new fmSanPham();
            fmain.Show();
            this.Hide();
        }

        private void dgvchitiethoadon_Click(object sender, EventArgs e)
        {
            fmChiTietHoaDon fmain = new fmChiTietHoaDon();
            fmain.Show();
            this.Hide();
        }

        private void hóaĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmHoaDon fmain = new fmHoaDon();
            fmain.Show();
            this.Hide();
        }
    }
}
