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
    public partial class fmHoaDon : Form
    {
       
        bool Them;
        string err;
        BLHoaDon dbHD = new BLHoaDon();

        public fmHoaDon()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dgvHoaDon.DataSource = dbHD.LayHoaDon();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void fmHoaDon_Load(object sender, EventArgs e)
        {
            
            LoadData();
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

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaHD.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            this.txtMaKH.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
            this.txtMaNV.Text = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            this.txtMaSP.Text = dgvHoaDon.Rows[r].Cells[3].Value.ToString();
            this.txtNhaPhanPhoi.Text = dgvHoaDon.Rows[r].Cells[4].Value.ToString();
            this.txtSoLuong.Text = dgvHoaDon.Rows[r].Cells[5].Value.ToString();
            this.txtMauSP.Text = dgvHoaDon.Rows[r].Cells[6].Value.ToString();
            this.dateTimePicker1.Text = dgvHoaDon.Rows[r].Cells[7].Value.ToString();
            this.txtTong.Text = dgvHoaDon.Rows[r].Cells[8].Value.ToString();



        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.dateTimePicker1.ResetText();
            this.txtMaHD.ResetText();
            this.txtMaKH.ResetText();
            this.txtMaNV.ResetText();
            this.txtMaSP.ResetText();
            this.txtMauSP.ResetText();
            this.txtNhaPhanPhoi.ResetText();
            this.txtSoLuong.ResetText();
            this.txtTong.ResetText();
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvHoaDon_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnTimKiem.Enabled = false;
            this.txtMaHD.Enabled = false;
            this.txtMaKH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaHD.ResetText();
            this.txtMaKH.ResetText();
            this.txtMaNV.ResetText();
            this.txtMaSP.ResetText();
            this.txtMauSP.ResetText();
            this.txtNhaPhanPhoi.ResetText();
            this.txtSoLuong.ResetText();
            this.txtTong.ResetText();

            //cho thao tác trên nút lưu hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //Không cho thao tác trên thêm xóa thoát
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaHD.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLHoaDon blHD = new BLHoaDon();
                    blHD.ThemHoaDon(this.txtMaHD.Text, this.txtMaKH.Text, this.txtMaNV.Text, this.txtMaSP.Text, this.txtNhaPhanPhoi.Text, this.txtSoLuong.Text, this.txtMaSP.Text, this.dateTimePicker1.Text, this.txtTong.Text, ref err);


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
                BLHoaDon blHD = new BLHoaDon();
                blHD.CapNhatHoaDon(this.txtMaHD.Text, this.txtMaKH.Text, this.txtMaNV.Text, this.txtMaSP.Text, this.txtNhaPhanPhoi.Text, this.txtSoLuong.Text, this.txtMaSP.Text, this.dateTimePicker1.Text, this.txtTong.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvHoaDon.CurrentCell.RowIndex;
                string strHopDong = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                DialogResult TraLoi;
                TraLoi = MessageBox.Show("Bạn có chắc chắn xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (TraLoi == DialogResult.OK)
                {
                    dbHD.XoaHoaDon(ref err, strHopDong);
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

        private void btnReaload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            IEnumerable<HOADON>hoadon = from hd in qlXeMay.HOADONs
                                         where hd.NgayXuatHD.Contains(dateTimePicker2.Text)
                                         select hd;
            
            


            dgvHoaDon.DataSource = hoadon.ToList();
        }
    }
}
