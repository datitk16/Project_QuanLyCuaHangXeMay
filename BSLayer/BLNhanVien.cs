using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;

namespace project_QLBanXeMay.BSLayer
{
    class BLNhanVien
    {
        public System.Data.Linq.Table<NHANVIEN> LayNhanVien()
        {
            DataSet ds = new DataSet();
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            return qlXeMay.NHANVIENs;
        }
        public bool ThemNhanVien(string MaNhanVien,string TenNhanVien,string GioiTinh,string SoDT,string DiaChi,string XepLoaiNV,string MatKhau,string quyen,ref string err)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            NHANVIEN nv = new NHANVIEN();
            nv.MaNV = Convert.ToInt32(MaNhanVien);
            nv.TenNV = TenNhanVien;
            nv.GioiTinhNV = GioiTinh;
            nv.SDTNV = SoDT;
            nv.DiaChiNV = DiaChi;
            nv.XepLoaiNV = XepLoaiNV;
            nv.MatKhau = MatKhau;
            nv.Quyen = quyen;
            qlXeMay.NHANVIENs.InsertOnSubmit(nv);
            qlXeMay.NHANVIENs.Context.SubmitChanges();


            return true;
        }
        public bool XoaNhanVien(ref string err,string MaNhanVien)
        {
            QuanLyBanXeMayDataContext qlXEMay = new QuanLyBanXeMayDataContext();
            var tpQuery = from nv in qlXEMay.NHANVIENs
                          where nv.MaNV == Convert.ToInt32(MaNhanVien)
                          select nv;
            qlXEMay.NHANVIENs.DeleteAllOnSubmit(tpQuery);
            qlXEMay.SubmitChanges();

            return true;
        }
        public bool CapNhatNhanVien(string MaNhanVien, string TenNhanVien, string GioiTinh, string SoDT, string DiaChi, string XepLoaiNV, string MatKhau, string quyen, ref string err)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            var tpQuery = (from nv in qlXeMay.NHANVIENs
                           where nv.MaNV == Convert.ToInt32(MaNhanVien)
                           select nv).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.TenNV =TenNhanVien;
                tpQuery.GioiTinhNV = GioiTinh;
                tpQuery.SDTNV = SoDT;
                tpQuery.DiaChiNV = DiaChi;
                tpQuery.XepLoaiNV = XepLoaiNV;
                tpQuery.MatKhau = MatKhau;
                tpQuery.Quyen = quyen;
                qlXeMay.SubmitChanges();

            }
            return true;
        }
      
    }
}
