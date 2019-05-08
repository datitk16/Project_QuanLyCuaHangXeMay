using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using MoHinh3Tang.DBlayer;

namespace MoHinh3Tang.BSlayer
{
    class BLNhanVien
    {
        DBMain db = null;
        public BLNhanVien()
        {
            db = new DBMain();
        }
        public DataSet LayDanhSachNhanVien()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text);
        }
        public bool ThemNhanVien(string MaNV,string ho,string ten,string phai,string ngaynhanviec,string diachi,string dienthoai,string hinh, ref string err)
        {
            string sqlString = "Insert Into NhanVien Values(" + "'" + MaNV + "',N'" + ho + "',N'" + ten + "'" +
                ",N'" + phai + "',N'" + ngaynhanviec + "',N'" + diachi + "',N'" + dienthoai + "',N'" + hinh + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhanVien(ref string err,string MaNhanVien)
        {
            string sqlString = "Delete From NhanVien Where MaNV='" + MaNhanVien + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhanVien(string MaNV, string ho, string ten, string phai, string ngaynhanviec, string diachi, string dienthoai, string hinh, ref string err)
        {
            string sqlString = "Update NhanVien Set Ho=N'" + ho + "',Ten=N'" + ten + "',Nu=N'" + phai + "',NgayNV=N'" + ngaynhanviec + "'" +
                ",DiaChi=N'" + diachi + "',DienThoai=N'" + dienthoai + "',Hinh=N'" + hinh + "' Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
