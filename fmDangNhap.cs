using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project_QLBanXeMay
{
    public partial class fmDangNhap : Form
    {
        QuanLyBanXeMayDataContext qlxm = new QuanLyBanXeMayDataContext();

        public fmDangNhap()
        {
            InitializeComponent();
        }

        private void fmDangNhap_Load(object sender, EventArgs e)
        {

        }




        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
              

                DANGNHAP usr = qlxm.DANGNHAPs.Where(c => c.TK == txtTaiKhoan.Text && c.MK == txtMatKhau.Text).Single();
                if (usr!=null)
                {
                    fmHome fmhome = new fmHome();
                    fmhome.Show();
                    this.Hide();
                    
                    
                }
             
            }
            catch(Exception)
            {
              
                  
                MessageBox.Show("Sai tài khoản hoặc mật khẩu vui lòng đăng nhập lại!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

       
    
}
