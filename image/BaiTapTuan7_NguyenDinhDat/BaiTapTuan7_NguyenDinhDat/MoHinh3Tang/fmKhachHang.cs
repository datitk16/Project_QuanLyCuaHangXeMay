using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using MoHinh3Tang.BSlayer;
namespace MoHinh3Tang
{
    public partial class fmKhachHang : Form
    {
        DataTable dtKhachHang = null;
        bool them;
        string err;
        BLKhachHang dbKhachHang = new BLKhachHang();
        public fmKhachHang()
        {
            InitializeComponent();
        }
        void LoatData()
        {
            try
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();

                DataSet ds = dbKhachHang.LayDanhSachKhachHang();
                dtKhachHang = ds.Tables[0];
                dgvKhachHang.DataSource = dtKhachHang;


            }
            catch
            {

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Form1 fmain = new Form1();
                fmain.Show();
                this.Hide();
            }
        }

        private void fmKhachHang_Load(object sender, EventArgs e)
        {
            LoatData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtMaKhachHang.ResetText();
            this.txtTenCT.ResetText();
            this.txtThanhPho.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaKhachHang.Focus();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    BLKhachHang blTP = new BLKhachHang();
                    blTP.ThemKhachHang(this.txtMaKhachHang.Text, this.txtTenCT.Text, this.txtDiaChi.Text, this.txtThanhPho.Text, this.txtDienThoai.Text, ref err);
                    LoatData();
                    MessageBox.Show("Đã thêm xong");
                    this.txtDiaChi.ResetText();
                    this.txtDienThoai.ResetText();
                    this.txtMaKhachHang.ResetText();
                    this.txtTenCT.ResetText();
                    this.txtThanhPho.ResetText();

                }
                catch
                {
                    MessageBox.Show("Không thêm dược");
                }
            }
            else
            {
                BLKhachHang blTP = new BLKhachHang();
                blTP.CapNhatKhachHang(this.txtMaKhachHang.Text, this.txtTenCT.Text, this.txtDiaChi.Text, 
                this.txtThanhPho.Text, this.txtDienThoai.Text, ref err);
                LoatData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            dgvKhachHang_CellClick(null, null);
            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaKhachHang.Enabled = false;
            this.txtTenCT.Focus();


        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            this.txtMaKhachHang.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            this.txtTenCT.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            this.txtThanhPho.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            this.txtDienThoai.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvKhachHang.CurrentCell.RowIndex;
                string strKHACHHANG = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa không", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    dbKhachHang.XoaKhachHang(ref err, strKHACHHANG);
                    LoatData();
                    MessageBox.Show("Đã xóa xong");
                }
            }
            catch
            {

            }

        }

        private void btnReaalod_Click(object sender, EventArgs e)
        {
            LoatData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtMaKhachHang.ResetText();
            this.txtTenCT.ResetText();
            this.txtThanhPho.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát   
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            dgvKhachHang_CellClick(null, null);
        }
    }
}
