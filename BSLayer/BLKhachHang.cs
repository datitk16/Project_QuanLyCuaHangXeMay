using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
namespace project_QLBanXeMay.BSLayer
{
    class BLKhachHang
    {
        public System.Data.Linq.Table<KHACHHANG> LayKhachHang()
        {
            DataSet ds = new DataSet();
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            return qlXeMay.KHACHHANGs;
        }
        public bool ThemKhachHang(string MaKhachHang, string TenKhachHang, string SoDienThoai, string DiaChiKhachHang,  ref string err)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            KHACHHANG kh = new KHACHHANG();
            kh.MaKH =Convert.ToInt32(MaKhachHang);
            kh.TenKH = TenKhachHang;
            kh.SDTKH = SoDienThoai;
            kh.DiaChiKH = DiaChiKhachHang;
           
            qlXeMay.KHACHHANGs.InsertOnSubmit(kh);
            qlXeMay.KHACHHANGs.Context.SubmitChanges();


            return true;
        }
        public bool XoaKhachHang(ref string err, string MaKhachHang)
        {
            QuanLyBanXeMayDataContext qlXEMay = new QuanLyBanXeMayDataContext();
            var tpQuery = from kh in qlXEMay.KHACHHANGs
                          where kh.MaKH == Convert.ToInt32(MaKhachHang)
                          select kh;
            qlXEMay.KHACHHANGs.DeleteAllOnSubmit(tpQuery);
            qlXEMay.SubmitChanges();

            return true;
        }
        public bool CapNhatKhachHang(string MaKhachHang, string TenKhachHang, string SoDienThoai, string DiaChiKhachHang, ref string err)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            var tpQuery = (from kh in qlXeMay.KHACHHANGs
                           where kh.MaKH == Convert.ToInt32(MaKhachHang)
                           select kh).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.TenKH = TenKhachHang;
                tpQuery.SDTKH = SoDienThoai;
                tpQuery.DiaChiKH = DiaChiKhachHang;
               

                qlXeMay.SubmitChanges();

            }
            return true;
        }
    }
}
