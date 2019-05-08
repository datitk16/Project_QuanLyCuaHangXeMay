using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace project_QLBanXeMay.BSLayer
{
    class BLHoaDon
    {
        public System.Data.Linq.Table<HOADON> LayHoaDon()
        {
            DataSet ds = new DataSet();
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            return qlXeMay.HOADONs;
        }
        public bool ThemHoaDon(string MaHopDong,string MaKhachHang,string MaNhanVien,string MaSanPham,string MaNhaPhanPhoi,string SoLuongSP,string MauSac,string NgayXuatHD,string Tong,ref string err)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            HOADON hd = new HOADON();
            hd.MaHD = Convert.ToInt32(MaHopDong);
            hd.MaKH = Convert.ToInt32(MaKhachHang);
            hd.MaNV = Convert.ToInt32(MaNhanVien);
            hd.MaSP = Convert.ToInt32(MaSanPham);
            hd.MaNPP = Convert.ToInt32(MaNhaPhanPhoi);
            hd.SoLuongSP = Convert.ToInt32(SoLuongSP);
            hd.MauSP = MauSac;
            hd.NgayXuatHD = NgayXuatHD;
            hd.Tong = Convert.ToInt32(Tong);

            qlXeMay.HOADONs.InsertOnSubmit(hd);
            qlXeMay.HOADONs.Context.SubmitChanges();
            return true;
        }
        public bool XoaHoaDon(ref string err,string MaHopDong)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            var tpQuery = from tp in qlXeMay.HOADONs
                          where tp.MaHD == Convert.ToInt32(MaHopDong)
                          select tp;
            qlXeMay.HOADONs.DeleteAllOnSubmit(tpQuery);
            qlXeMay.SubmitChanges();
            return true;
        }
        public bool CapNhatHoaDon(string MaHopDong, string MaKhachHang, string MaNhanVien,
            string MaSanPham, string MaNhaPhanPhoi, string SoLuongSP, string MauSac,
            string NgayXuatHD, string Tong, ref string err)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            var tpQuery = (from hd in qlXeMay.HOADONs
                           where hd.MaHD == Convert.ToInt32(MaHopDong)
                           select hd).SingleOrDefault();
            if (tpQuery != null)
            {

                tpQuery.MaKH = Convert.ToInt32(MaKhachHang);
                tpQuery.MaNV = Convert.ToInt32(MaNhanVien);
                tpQuery.MaSP = Convert.ToInt32(MaSanPham);
                tpQuery.MaNPP = Convert.ToInt32(MaNhaPhanPhoi);
                tpQuery.SoLuongSP = Convert.ToInt32(SoLuongSP);
                tpQuery.MauSP = MauSac;
                tpQuery.NgayXuatHD = NgayXuatHD;
                tpQuery.Tong = Convert.ToInt32(Tong);
                qlXeMay.SubmitChanges();
            }
            return true;
        }
    }
}
