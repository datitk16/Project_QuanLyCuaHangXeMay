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
    public partial class fmNhaPhanPhoi : Form
    {
        bool Them;
        string err;
        BLNhaPhanPhoi dbNPP = new BLNhaPhanPhoi();
        public fmNhaPhanPhoi()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dataGridView1.DataSource = dbNPP.LayNhaPhanPhoi();
                dataGridView1_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }

        private void fmNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtMaNhaPP.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txtTenNPP.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.txtSoDT.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChi.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            //xóa trống đối tượng trong paint
            this.txtDiaChi.ResetText();
            this.txtMaNhaPP.ResetText();
            this.txtSearch.ResetText();
            this.txtSoDT.ResetText();
            this.txtTenNPP.ResetText();

 ;
            //cho thao tác trên nút lưu hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //Không cho thao tác trên thêm xóa thoát
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            this.txtMaNhaPP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLNhaPhanPhoi blNPP = new BLNhaPhanPhoi();
                    blNPP.ThemNhaPhanPhoi(this.txtMaNhaPP.Text, this.txtTenNPP.Text, this.txtSoDT.Text, this.txtDiaChi.Text, ref err);
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
                BLNhaPhanPhoi blKH = new BLNhaPhanPhoi();
                blKH.CapNhatNhaPhanPhoi(this.txtMaNhaPP.Text, this.txtTenNPP.Text, this.txtSoDT.Text, this.txtDiaChi.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                string strNhaPhanPhoi = dataGridView1.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;                 // Hiện hộp thoại hỏi đáp           
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",    
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbNPP.XoaNhaPhanPhoi(ref err, strNhaPhanPhoi);
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
            dataGridView1_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnTimKiem.Enabled = false;
            this.txtMaNhaPP.Enabled = false;
            this.txtTenNPP.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaNhaPP.ResetText();
            this.txtTenNPP.ResetText();
            this.txtSoDT.ResetText();
            this.txtDiaChi.ResetText();


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
            IEnumerable<NHAPHANPHOI> khachhang = from kh in qlXeMay.NHAPHANPHOIs
                                               where kh.TenNPP.Contains(txtSearch.Text)
                                               select kh;
            //do stuff
            //MessageBox.Show("Bạn phải nhật đúng định dạng chữ cái");


            dataGridView1.DataSource = khachhang.ToList();
        }
    }
}
