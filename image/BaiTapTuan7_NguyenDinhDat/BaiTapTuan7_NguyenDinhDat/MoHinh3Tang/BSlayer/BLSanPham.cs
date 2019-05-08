using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

using MoHinh3Tang.DBlayer;

namespace MoHinh3Tang.BSlayer
{
    class BLSanPham
    {
        DBMain db = null;
        public BLSanPham()
        {
            db = new DBMain();
        }
        public DataSet LaSanPham()
        {
            return db.ExecuteQueryDataSet("select * from SanPham", CommandType.Text);
        }
        public bool ThemSanPham(string MaSanPham,string TenSanPham,string DonViTinh,string DonGia,string Hinh,ref string err)
        {
            string sqlString = "Insert Into SanPham Values(" + "'" + MaSanPham + "',N'" + TenSanPham + "',N'" + DonViTinh + "'" +
                ",N'" + DonGia + "',N'" + Hinh + "'" +
                ")"; 
             return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSanPham(ref string err,string MaSanPham)
        {
            string sqlString = "Delete From SanPham Where MaSP='" + MaSanPham + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSanPham(string MaSanPham, string TenSanPham, string DonViTinh, string DonGia, string Hinh, ref string err)
        {
            string sqlString =  "Update SanPham Set TenSP=N'" + TenSanPham + "',DonViTinh=N'" + DonViTinh + "'," +
                "DonGia=N'" + DonGia + "',Hinh=N'" + Hinh + "' Where MaSP='" + MaSanPham + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
    }
}
