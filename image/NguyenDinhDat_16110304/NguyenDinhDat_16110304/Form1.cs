using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.BS_layer;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu          
        bool Them = false;
        // Phuong thuc dung chung 
        //bool Them;
        string err;
        BLThanhPho dbTP = new BLThanhPho();

        public Form1()
        {
            InitializeComponent();
        }
            void LoadData()
        {            
            try
            {               
               dgvTHANHPHO.DataSource = dbTP.LayThanhPho();
                dgvTHANHPHO.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel  
                txtMaThanhPho.ResetText();
                txtTenThanhPho.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy              
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                panel1.Enabled = false;           
                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát              
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThoat.Enabled = true;
                dgvTHANHPHO_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
           
                
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {             // Kich hoạt biến Them  
            Them = true;
            txtMaThanhPho.Enabled = true;
            // Xóa trống các đối tượng trong Panel              
            txtMaThanhPho.ResetText();
            txtTenThanhPho.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel              
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel1.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát              
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;            
            // Đưa con trỏ đến TextField txtMaKH              
            txtMaThanhPho.Focus();

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa          
            Them = false;
            //dgvTHANHPHO_CellClick(null, null);      
            // Cho phép thao tác trên Panel  
            panel1.Enabled = true;
            txtMaThanhPho.ResetText();
            txtTenThanhPho.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel   
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaThanhPho.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtTenCty       
            txtMaThanhPho.Focus();


        }
        private void bthThoat_Click(object sender, EventArgs e)
        {             // Khai báo biến traloi              
            DialogResult traloi;             // Hiện hộp thoại hỏi đáp              
            traloi = MessageBox.Show("Chắc không?", "Trả lời",             
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);             
            // Kiểm tra có nhắp chọn nút Ok không?              
            if (traloi == DialogResult.OK) this.Close(); 

        }
        private void dgvTHANHPHO_CellClick(object sender, DataGridViewCellEventArgs e)
        {             // Thứ tự dòng hiện hành              
            int r = dgvTHANHPHO.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel              
            txtMaThanhPho.Text =dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();
            txtTenThanhPho.Text =dgvTHANHPHO.Rows[r].Cells[1].Value.ToString();
            

        }





       
        private void btnHuy_Click(object sender, EventArgs e)
        {            
            // Xóa trống các đối tượng trong Panel              
            txtMaThanhPho.ResetText();
            txtTenThanhPho.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát              
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel              
            btnLuu.Enabled = false;
            btnHuy.Enabled = false; 
            panel.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối              
            // Thêm dữ liệu             
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh                      
                    BLThanhPho blTp = new BLThanhPho();
                    blTp.ThemThanhPho(this.txtMaThanhPho.Text, this.txtTenThanhPho.Text, ref err);
                    // Load lại dữ liệu trên DataGridView                      
                    LoadData();
                    // Thông báo                      
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {                     MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh                 
                BLThanhPho blTp = new BLThanhPho();
                blTp.CapNhatThanhPho(this.txtMaThanhPho.Text, this.txtTenThanhPho.Text, ref err);

                // Load lại dữ liệu trên DataGridView                 
                LoadData();
                // Thông báo                  
                MessageBox.Show("Đã sửa xong!");
            }             // Đóng kết nối 

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh                 
                // Lấy thứ tự record hiện hành                 
                int r = dgvTHANHPHO.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành                  
                string strTHANHPHO = dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  

                // Hiện thông báo xác nhận việc xóa mẫu tin                 
                // Khai báo biến traloi                  
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp                  
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",                 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?                  
                if (traloi == DialogResult.Yes) 
                {

                    dbTP.XoaThanhPho(ref err, strTHANHPHO);

                    // Cập nhật lại DataGridView                     
                    LoadData();
                    // Thông báo                      
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo                      
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }   

          }


               
      }
}
