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
    public partial class fmSanPham : Form
    {
        bool Them;
        string err;
        BLSanPham dbSP = new BLSanPham();
        public fmSanPham()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dataGridView1.DataSource = dbSP.LaySanPham();


                this.txtGiaSP.ResetText();
                this.txtMaSanPham.ResetText();
                this.txtMauSP.ResetText();
                this.txtNPP.ResetText();
                this.txtSearch.ResetText();
                this.txtTenSP.ResetText();


                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                dataGridView1_CellClick(null, null);

                
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");    
            }
        }
        private void fmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtMaSanPham.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txtNPP.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.txtTenSP.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txtMauSP.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.txtGiaSP.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();

        }

        private void btnReaload_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtGiaSP.ResetText();
            this.txtMaSanPham.ResetText();
            this.txtMauSP.ResetText();
            this.txtNPP.ResetText();
            this.txtSearch.ResetText();
            this.txtTenSP.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaSanPham.Focus();



        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLSanPham blSP = new BLSanPham();
                    blSP.ThemSanPham(this.txtMaSanPham.Text, this.txtNPP.Text, this.txtTenSP.Text, this.txtMauSP.Text, this.txtGiaSP.Text, ref err);
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
                BLSanPham blSP = new BLSanPham();
                blSP.CapNhaSanPham(this.txtMaSanPham.Text, this.txtNPP.Text, this.txtTenSP.Text, this.txtMauSP.Text, this.txtGiaSP.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                string strSANPHAM = dataGridView1.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp              
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",      
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbSP.XoaSanPham(ref err, strSANPHAM);
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

            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaSanPham.Enabled = false;
            this.txtNPP.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtGiaSP.ResetText();
            this.txtMaSanPham.ResetText();
            this.txtMauSP.ResetText();
            this.txtNPP.ResetText();
            this.txtSearch.ResetText();
            this.txtTenSP.ResetText();

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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            IEnumerable<SANPHAM> nhanvien = from nv in qlXeMay.SANPHAMs
                                             where nv.TenSP.Contains(txtSearch.Text)
                                             select nv;
            //do stuff
            //MessageBox.Show("Bạn phải nhật đúng định dạng chữ cái");


            dataGridView1.DataSource = nhanvien.ToList();
        }
    }
}
