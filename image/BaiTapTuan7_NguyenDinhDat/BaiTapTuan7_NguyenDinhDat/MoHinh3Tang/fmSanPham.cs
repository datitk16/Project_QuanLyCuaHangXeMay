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
    public partial class fmSanPham : Form
    {
        public fmSanPham()
        {
            InitializeComponent();
        }
        DataTable dtSanPham = null;
        bool Them;
        string err;
        BLSanPham dbSanPham=new BLSanPham();

        void LoadData()
        {
            try
            {
                //gán dtsanpham vào table
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                DataSet ds = dbSanPham.LaSanPham();
                dtSanPham = ds.Tables[0];
                dataGridView1.DataSource = dtSanPham;
                //xóa trống các đối tượng datagridview
                this.txtMaSanPham.ResetText();
                this.txtTenSanPham.ResetText();
                this.txtDonGia.ResetText();
                this.txtDonViTinh.ResetText();
                this.txtHinh.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                //cho thao tác trên các nut thêm sửa xóa thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
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

        private void btnReaalod_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtDonGia.ResetText();
            this.txtDonViTinh.ResetText();
            this.txtHinh.ResetText();
            this.txtMaSanPham.ResetText();
            this.txtTenSanPham.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaSanPham.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLSanPham blSP = new BLSanPham();
                    blSP.ThemSanPham(this.txtMaSanPham.Text, this.txtTenSanPham.Text, this.txtDonViTinh.Text, this.txtDonGia.Text, this.txtHinh.Text,ref err );
                    MessageBox.Show("Đã thêm xong");

                    
                }
                catch {
                    MessageBox.Show("Không thêm được lỗi rồi");
                }
            }
            else
            {
                BLSanPham blSP = new BLSanPham();
                blSP.CapNhatSanPham(this.txtMaSanPham.Text, this.txtTenSanPham.Text, this.txtDonViTinh.Text, this.txtDonGia.Text, this.txtHinh.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                string strSanPham = dataGridView1.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn xóa mẫu tin?", "Trả lời ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //kiểm tra xem có nhấn nút ok không
                if (traloi == DialogResult.Yes)
                {
                    dbSanPham.XoaSanPham(ref err, strSanPham);
                    LoadData();
                    MessageBox.Show("Đã xóa xong");
                }
                else
                {
                    MessageBox.Show("Không thực hiện được mẫu xóa");
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
            dataGridView1_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtTenSanPham.Focus();
            this.txtMaSanPham.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.txtMaSanPham.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txtTenSanPham.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.txtDonViTinh.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txtDonGia.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.txtHinh.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaSanPham.ResetText();
            this.txtTenSanPham.ResetText();
            this.txtDonViTinh.ResetText();
            this.txtDonGia.ResetText();
            this.txtHinh.ResetText();
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
    }
}
