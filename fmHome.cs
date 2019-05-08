using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_QLBanXeMay
{
    public partial class fmHome : Form
    {



        public fmHome()
        {
            InitializeComponent();
        }

        private void fmHome_Load(object sender, EventArgs e)
        {
           
        }

        private void qUẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fmDangNhap fmDangNhap = new fmDangNhap();
            fmDangNhap.Show();


        }

        private void đĂNGNHẬPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            fmDangNhap fmDangNhap = new fmDangNhap();
            fmDangNhap.Show();
        }

        private void qUẢNLÝHÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmHoaDon fmhoadon = new fmHoaDon();
            fmhoadon.Show();
           
        }

        private void qUÁNLÝNHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNhanVien fmnhanvien = new fmNhanVien();
            fmnhanvien.Show();
        }

        private void qUẢNLÝSẢNPHẨMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmSanPham fmsanpham = new fmSanPham();
            fmsanpham.Show();
        }

        private void qUẢNLÝNHÀPHÂNPHỐIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNhaPhanPhoi fmnpp = new fmNhaPhanPhoi();
            fmnpp.Show();
        }

        private void qUẢNLÝKHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmKhachHang fmkh = new fmKhachHang();
            fmkh.Show();
        }
    }
}
