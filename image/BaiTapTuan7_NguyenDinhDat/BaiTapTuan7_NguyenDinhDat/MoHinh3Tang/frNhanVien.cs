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
    public partial class frNhanVien : Form
    {
        DataTable dtNhanVien = null;
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();

        public frNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            try
            {
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();

                DataSet ds = dbNV.LayDanhSachNhanVien();
                dtNhanVien = ds.Tables[0];
                dgvNhanVien.DataSource = dtNhanVien;
                this.txtDiaChi.ResetText();
                this.txtDienThoai.ResetText();
                this.txtHinh.ResetText();
                this.txtHo.ResetText();
                this.txtMaNV.ResetText();
                this.txtNgaySinh.ResetText();
                this.txtPhai.ResetText();
                this.txtTen.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
                dgvNhanVien_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtHinh.ResetText();
            this.txtHo.ResetText();
            this.txtMaNV.ResetText();
            this.txtNgaySinh.ResetText();
            this.txtPhai.ResetText();
            this.txtTen.ResetText();
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            dgvNhanVien_CellClick(null, null);
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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void frNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            this.txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtHo.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtTen.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            
            this.txtPhai.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            this.txtNgaySinh.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            this.txtDienThoai.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            this.txtHinh.Text = dgvNhanVien.Rows[r].Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtHinh.ResetText();
            this.txtHo.ResetText();
            this.txtMaNV.ResetText();
            this.txtNgaySinh.ResetText();
            this.txtPhai.ResetText();
            this.txtTen.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
        
            this.btnThoat.Enabled = false;
            this.txtMaNV.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLNhanVien blNV = new BLNhanVien();
                    blNV.ThemNhanVien(this.txtMaNV.Text, this.txtHo.Text, this.txtTen.Text, this.txtPhai.Text, this.txtNgaySinh.Text, this.txtDiaChi.Text, txtDienThoai.Text,
                        this.txtHinh.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLNhanVien bLNV = new BLNhanVien();
                bLNV.CapNhatNhanVien(this.txtMaNV.Text, this.txtHo.Text, this.txtTen.Text, this.txtPhai.Text, this.txtNgaySinh.Text, 
                    this.txtDiaChi.Text, txtDienThoai.Text,
                        this.txtHinh.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNhanVien.CurrentCell.RowIndex;
                string strNHANVIEN = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbNV.XoaNhanVien(ref err, strNHANVIEN);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvNhanVien_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaNV.Enabled = false;
            this.txtHo.Focus();
        }
    }
}
