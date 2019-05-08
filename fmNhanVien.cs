using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Linq;



using project_QLBanXeMay.BSLayer;
namespace project_QLBanXeMay
{
    public partial class fmNhanVien : Form
    {
        //Khai báo biến thêm ,sửa dữ liệu
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();
        public fmNhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                QuanLyBanXeMayDataContext qlxemay = new QuanLyBanXeMayDataContext();
                dgvNhanVien.DataSource = qlxemay.NHANVIENs;
            }
            catch
            {
                MessageBox.Show("Không thêm được lỗi rồi");
            }
        }

        private void fmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            //xóa trống đối tượng trong paint
            this.txtDiaChi.ResetText();
            this.txtGioiTinh.ResetText();
            this.txtHoTen.ResetText();
            this.txtMaNV.ResetText();
            this.txtSoDT.ResetText();
            this.txtXepLoai.ResetText();
            this.txtMaNV.ResetText();
            this.txtQuyen.ResetText();
            this.txtMatKhau.ResetText();
            //cho thao tác trên nút lưu hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //Không cho thao tác trên thêm xóa thoát
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

                    blNV.ThemNhanVien(this.txtMaNV.Text, this.txtHoTen.Text, this.txtGioiTinh.Text, this.txtSoDT.Text, this.txtDiaChi.Text, this.txtXepLoai.Text, this.txtMatKhau.Text, this.txtQuyen.Text, ref err);
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
                BLNhanVien blNV = new BLNhanVien();
                blNV.CapNhatNhanVien(this.txtMaNV.Text, this.txtHoTen.Text, this.txtGioiTinh.Text, this.txtSoDT.Text, this.txtDiaChi.Text, this.txtXepLoai.Text, this.txtMatKhau.Text, this.txtQuyen.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnReaload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNhanVien.CurrentCell.RowIndex;
                string strNhanVien = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                DialogResult TraLoi;
                TraLoi = MessageBox.Show("Bạn có chắc chắn xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (TraLoi == DialogResult.OK)
                {
                    dbNV.XoaNhanVien(ref err, strNhanVien);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvNhanVien_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnTimKiem.Enabled = false;
            this.txtMaNV.Enabled = false;
            this.txtHoTen.Focus();
            
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            this.txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtHoTen.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtGioiTinh.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            this.txtSoDT.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            this.txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtXepLoai.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            this.txtMatKhau.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            this.txtQuyen.Text = dgvNhanVien.Rows[r].Cells[7].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtDiaChi.ResetText();
            this.txtGioiTinh.ResetText();
            this.txtHoTen.ResetText();
            this.txtMaNV.ResetText();
            this.txtSoDT.ResetText();
            this.txtXepLoai.ResetText();
            this.txtMaNV.ResetText();
            this.txtQuyen.ResetText();
            this.txtMatKhau.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            //dgvNhanVien_CellClick(null, null);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            IEnumerable<NHANVIEN> nhanvien = from nv in qlXeMay.NHANVIENs
                                             where nv.TenNV.Contains(txtSearch.Text)
                                             select nv;
            //do stuff
                //MessageBox.Show("Bạn phải nhật đúng định dạng chữ cái");

          
                    dgvNhanVien.DataSource = nhanvien.ToList();
                
            }



            
            
              
            
            
           
            
        
            
        
    }
}
