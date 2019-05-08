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


namespace MoHinh3Tang
{
    public partial class DangNhap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SNDP6RA;Initial Catalog=QL_BanXeMay;Integrated Security=True");

        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE TK ='" + username + "' and MK='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id_user"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return id;
        }
        public DangNhap()
        {
            InitializeComponent();
           
        }
        public static string ID_USER = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ID_USER = getID(textBox1.Text, textBox2.Text);
            if (ID_USER != "")
            {
                MessageBox.Show("Đăng nhập thành công !");
                Form1 fmain = new Form1();
                fmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoảng và mật khẩu không đúng !");
            }

        }
     

        private void DangNhap_Load(object sender, EventArgs e)
        {
           
        }
    }
}
