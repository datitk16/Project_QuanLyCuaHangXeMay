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
    public partial class fmChiTietHoaDon : Form
    {
        DataTable dtChiTietHD = null;
        bool Them;
        string err;
        BLChiTietHoaDon dbCTHD = new BLChiTietHoaDon();
        public fmChiTietHoaDon()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtChiTietHD = new DataTable();
                dtChiTietHD.Clear();
                DataSet ds = dbCTHD.LayChiTietHoaDon();
                dtChiTietHD = ds.Tables[0];

                dgvChiTietHoaDon.DataSource = dtChiTietHD;

               
            }
            catch
            {

            }
        }
        private void fmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaHopDong.ResetText();
            this.txtMaSanPham.ResetText();
            this.txtSoLuong.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaHopDong.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLChiTietHoaDon blCTHD = new BLChiTietHoaDon();
                    blCTHD.ThemChiTietHoaDon(this.txtMaHopDong.Text, this.txtMaSanPham.Text, this.txtSoLuong.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLChiTietHoaDon blCTHD = new BLChiTietHoaDon();
                blCTHD.CapNhatChiTietHoaDon(this.txtMaHopDong.Text, this.txtMaSanPham.Text, this.txtSoLuong.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvChiTietHoaDon.CurrentCell.RowIndex;
            this.txtMaHopDong.Text = dgvChiTietHoaDon.Rows[r].Cells[0].Value.ToString();
            this.txtMaSanPham.Text = dgvChiTietHoaDon.Rows[r].Cells[1].Value.ToString();
            this.txtSoLuong.Text = dgvChiTietHoaDon.Rows[r].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvChiTietHoaDon_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnThem.Enabled = false;
            this.txtMaHopDong.Enabled = false;
            this.txtMaSanPham.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvChiTietHoaDon.CurrentCell.RowIndex;
                string strTHANHPHO = dgvChiTietHoaDon.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbCTHD.XoaChiTietHoaDon(ref err, strTHANHPHO);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaHopDong.ResetText();
            this.txtMaSanPham.ResetText();
            this.txtSoLuong.ResetText();
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnThoat.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            dgvChiTietHoaDon_CellClick(null, null);
        }

        private void btnReaalod_Click(object sender, EventArgs e)
        {
            LoadData();
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
    }
}
