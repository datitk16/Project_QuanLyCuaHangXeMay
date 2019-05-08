using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using MoHinh3Tang.DBlayer;


namespace MoHinh3Tang.BSlayer
{
    class BLKhachHang
    {
        DBMain db = null;
        public BLKhachHang()
        {
            db = new DBMain();
        }
        public DataSet LayDanhSachKhachHang()
        {
            return db.ExecuteQueryDataSet("select * from KhachHang", CommandType.Text);
        }
        public bool ThemKhachHang(string MaKHachHang,string TenCongTy,string DiaChi,string ThanhPho,string DienThoai,ref string err)
        {
            string sqlString = "Insert Into KhachHang Values(" + "'" + MaKHachHang + "',N'" + TenCongTy + "',N'" + DiaChi + "'" +
                ",N'" + ThanhPho + "',N'" + DienThoai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhachHang(ref string err,string MaKhachHang)
        {
            string sqlString = "Delete From KhachHang Where MaKH='" + MaKhachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatKhachHang(string MaKHachHang, string TenCongTy, string DiaChi, string ThanhPho, string DienThoai, ref string err)
        {
            string sqlString = "Update KhachHang Set TenCty=N'" + TenCongTy + "',DiaChi=N'" + DiaChi + "'," +
                 "ThanhPho=N'" + ThanhPho + "',DienThoai=N'" + DienThoai + "' Where MaKH='" + MaKHachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
