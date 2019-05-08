using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace project_QLBanXeMay.BSLayer
{
    class BLSanPham
    {
        public System.Data.Linq.Table<SANPHAM> LaySanPham()
        {
            DataSet ds = new DataSet();
            QuanLyBanXeMayDataContext qlxemay = new QuanLyBanXeMayDataContext();
            return qlxemay.SANPHAMs;
        }
        public bool ThemSanPham(string MaSanPham,string MaNhaPP,string TenSanPham,string MauSanPham,string GiaSanPham,ref string err)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            SANPHAM sp = new SANPHAM();
            sp.MaSP =Convert.ToInt32( MaSanPham);
            sp.MaNPP =Convert.ToInt32( MaNhaPP);
            sp.TenSP = TenSanPham;
            sp.MauSP = MauSanPham;
            sp.TenSP = TenSanPham;
            sp.MauSP = MauSanPham;
            sp.GiaSP =Convert.ToInt32(GiaSanPham);

            qlXeMay.SANPHAMs.InsertOnSubmit(sp);
            qlXeMay.SANPHAMs.Context.SubmitChanges();
            return true;
        }
        public bool XoaSanPham(ref string err,string MaSanPham)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            var tpQuery = from sp in qlXeMay.SANPHAMs where sp.MaSP ==Convert.ToInt32(MaSanPham) select sp;
            qlXeMay.SANPHAMs.DeleteAllOnSubmit(tpQuery);
            qlXeMay.SubmitChanges();
            return true;
        }
        public bool CapNhaSanPham(string MaSanPham, string MaNhaPP, string TenSanPham, string MauSanPham, string GiaSanPham, ref string err)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            var tpQuery = (from tp in qlXeMay.SANPHAMs where tp.MaSP ==Convert.ToInt32(MaSanPham) select tp).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.MaNPP =Convert.ToInt32(MaNhaPP);
                tpQuery.TenSP = TenSanPham;
                tpQuery.MauSP = MauSanPham;
                tpQuery.GiaSP =Convert.ToInt32(GiaSanPham);
                qlXeMay.SubmitChanges();
            }
            return true;


        }
    }
}
