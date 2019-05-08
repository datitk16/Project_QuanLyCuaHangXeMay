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
    class BLChiTietHoaDon
    {
        DBMain db = null;
        public BLChiTietHoaDon()
        {
            db = new DBMain();
        }
        public DataSet LayChiTietHoaDon()
        {
            return db.ExecuteQueryDataSet("select * from ChiTietHoaDon", CommandType.Text);
        }
        public bool ThemChiTietHoaDon(string MaHopDong,string MaSanPham,string SoLuong,ref string err)
        {
            string sqlString = "Insert Into ChiTietHoaDon Values(" + "'" + MaHopDong + "',N'" + MaSanPham + "',N'" + SoLuong + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaChiTietHoaDon(ref string err,string MaHopDong)
        {
            string sqlString = "Delete From ChiTietHoaDon Where MaHD='" + MaHopDong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatChiTietHoaDon(string MaHopDong, string MaSanPham, string SoLuong, ref string err)
        {
            string sqlString = "Update ChiTietHoaDon Set MaSP=N'" + MaSanPham + "',Soluong=N'" + SoLuong + "' Where MaHD='" + MaHopDong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
       
    }
}
