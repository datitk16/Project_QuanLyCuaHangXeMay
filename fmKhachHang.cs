using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using project_QLBanXeMay.BSLayer;
namespace project_QLBanXeMay
{
    public partial class fmKhachHang : Form
    {
        bool Them;
        string err;
        BLKhachHang dbKH = new BLKhachHang();
        public fmKhachHang()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvKHachHang.DataSource = dbKH.LayKhachHang();
            }
            catch
            {

            }
        }
        private void fmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvKHachHang_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnTimKiem.Enabled = false;
            this.txtMaKH.Enabled = false;
            this.txtTenKH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            //xóa trống đối tượng trong paint
            this.txtDiaChiKH.ResetText();
            this.txtMaKH.ResetText();
            this.txtSDTKH.ResetText();
            this.txtSearch.ResetText();
            this.txtTenKH.ResetText();
           
            //cho thao tác trên nút lưu hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //Không cho thao tác trên thêm xóa thoát
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            this.txtMaKH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLKhachHang blKH = new BLKhachHang();
                    blKH.ThemKhachHang(this.txtMaKH.Text, this.txtTenKH.Text, this.txtSDTKH.Text, this.txtDiaChiKH.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLKhachHang blKH = new BLKhachHang();
                blKH.CapNhatKhachHang(this.txtMaKH.Text, this.txtTenKH.Text, this.txtSDTKH.Text, this.txtDiaChiKH.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void dgvKHachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKHachHang.CurrentCell.RowIndex;
            this.txtMaKH.Text = dgvKHachHang.Rows[r].Cells[0].Value.ToString();
            this.txtTenKH.Text = dgvKHachHang.Rows[r].Cells[1].Value.ToString();
            this.txtSDTKH.Text = dgvKHachHang.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChiKH.Text = dgvKHachHang.Rows[r].Cells[3].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvKHachHang.CurrentCell.RowIndex;
                string strKHACHHANG = dgvKHachHang.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;                 // Hiện hộp thoại hỏi đáp   
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",     
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbKH.XoaKhachHang(ref err, strKHACHHANG);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtSDTKH.ResetText();
            this.txtDiaChiKH.ResetText();
           

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }

        private void btnReaload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            IEnumerable<KHACHHANG> khachhang = from kh in qlXeMay.KHACHHANGs
                                             where kh.TenKH.Contains(txtSearch.Text)
                                             select kh;
            //do stuff
            //MessageBox.Show("Bạn phải nhật đúng định dạng chữ cái");


            dgvKHachHang.DataSource = khachhang.ToList();
        }
    }
}
