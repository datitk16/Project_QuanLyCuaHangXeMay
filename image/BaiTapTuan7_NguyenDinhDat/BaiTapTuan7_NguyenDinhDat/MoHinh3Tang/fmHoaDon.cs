using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using MoHinh3Tang.BSlayer;

namespace MoHinh3Tang
{
    public partial class fmHoaDon : Form
    {
        DataTable dtHoaDon = null;
        bool Them;
        string err;
        BLHoaDon dbHD = new BLHoaDon();
        public fmHoaDon()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                 dtHoaDon= new DataTable();
                dtHoaDon.Clear();

                DataSet ds = dbHD.LayHoaDon();
                dtHoaDon = ds.Tables[0];

                dataGridView1.DataSource = dtHoaDon;

            }
            catch
            {

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaHopDong.ResetText();
            this.txtMaKhachHang.ResetText();
            this.txtMaNhanVien.ResetText();
            this.txtNgayLapHD.ResetText();
            this.txtNgayNhanHang.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            dataGridView1_CellClick(null, null);
            
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

        private void fmHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaHopDong.ResetText();
            this.txtMaKhachHang.ResetText();
            this.txtMaNhanVien.ResetText();
            this.txtNgayLapHD.ResetText();
            this.txtNgayNhanHang.ResetText();

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
                    BLHoaDon blHD = new BLHoaDon();
                    blHD.ThemHoaDon(this.txtMaHopDong.Text, this.txtMaKhachHang.Text, this.txtMaNhanVien.Text, this.txtNgayLapHD.Text, this.txtNgayNhanHang.Text, ref err);
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
                BLHoaDon blHD = new BLHoaDon();
                blHD.CapNhatHoaDon(this.txtMaHopDong.Text, this.txtMaKhachHang.Text, this.txtMaNhanVien.Text, this.txtNgayLapHD.Text, this.txtNgayNhanHang.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtMaHopDong.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txtMaKhachHang.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.txtMaNhanVien.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txtNgayLapHD.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.txtNgayNhanHang.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                string strHOADON = dataGridView1.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    dbHD.XoaHoaDon(ref err, strHOADON);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dataGridView1_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaHopDong.Enabled = false;
            this.txtMaKhachHang.Focus();
        }
    }
}
