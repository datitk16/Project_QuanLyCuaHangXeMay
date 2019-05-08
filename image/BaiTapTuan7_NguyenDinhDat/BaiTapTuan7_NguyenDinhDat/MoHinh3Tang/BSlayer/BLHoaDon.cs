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
    class BLHoaDon
    {
        DBMain db = null;
        public BLHoaDon()
        {
            db = new DBMain();
        }
        public DataSet LayHoaDon()
        {
            return db.ExecuteQueryDataSet("select * from HoaDon", CommandType.Text);
        }
        public bool ThemHoaDon(string MaHopDong, string MaKhachHang, string MaNhanVien, string NgayLapHoaDon, string NgayNhanHang, ref string err)
        {
            string sqlString = "Insert Into HoaDon Values(" + "'" + MaHopDong + "',N'" + MaKhachHang + "',N'" + MaNhanVien + "'" +
                ",N'" + NgayLapHoaDon + "',N'" + NgayNhanHang + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaHoaDon(ref string err,string MaHopDong)
        {
            string sqlString = "Delete From HoaDon Where MaHD='" + MaHopDong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatHoaDon(string MaHopDong, string MaKhachHang, string MaNhanVien, string NgayLapHoaDon, string NgayNhanHang, ref string err)
        {
            string sqlString = "Update HoaDon Set MaKH=N'" + MaKhachHang + "',MaNV=N'" + MaNhanVien + "',NgayLapHD=N'" + NgayLapHoaDon + "',NgayNhanHang=N'" + NgayNhanHang + "' Where MaHD='" + MaHopDong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
