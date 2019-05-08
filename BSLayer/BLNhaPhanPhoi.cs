using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
namespace project_QLBanXeMay.BSLayer
{
    class BLNhaPhanPhoi
    {
        public System.Data.Linq.Table<NHAPHANPHOI> LayNhaPhanPhoi()
        {
            DataSet ds = new DataSet();
            QuanLyBanXeMayDataContext qlxemay = new QuanLyBanXeMayDataContext();
            return qlxemay.NHAPHANPHOIs;
        }
        public bool ThemNhaPhanPhoi(string MaNhaPhanPhoi, string TenNhaPhanPhoi, string SoDTNhaPhanPhoi, string DiaChiNhaPhanPhoi, ref string err)
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            NHAPHANPHOI npp = new NHAPHANPHOI();
            npp.MaNPP =Convert.ToInt32(MaNhaPhanPhoi);
            npp.TenNPP = TenNhaPhanPhoi;
            npp.SDTNPP = SoDTNhaPhanPhoi;
            npp.DiaChiNPP = DiaChiNhaPhanPhoi;
           

            qlXeMay.NHAPHANPHOIs.InsertOnSubmit(npp);
            qlXeMay.NHAPHANPHOIs.Context.SubmitChanges();


            return true;
        }
        public bool XoaNhaPhanPhoi(ref string err, string MaNhaPhanPhoi)
        {
            QuanLyBanXeMayDataContext qlXEMay = new QuanLyBanXeMayDataContext();
            var tpQuery = from npp in qlXEMay.NHAPHANPHOIs
                          where npp.MaNPP == Convert.ToInt32(MaNhaPhanPhoi)
                          select npp;
            qlXEMay.NHAPHANPHOIs.DeleteAllOnSubmit(tpQuery);
            qlXEMay.SubmitChanges();

            return true;
        }
        public bool CapNhatNhaPhanPhoi(string MaNhaPhanPhoi, string TenNhaPhanPhoi, string SoDTNhaPhanPhoi, string DiaChiNhaPhanPhoi, ref string err    )
        {
            QuanLyBanXeMayDataContext qlXeMay = new QuanLyBanXeMayDataContext();
            var tpQuery = (from kh in qlXeMay.NHAPHANPHOIs
                           where kh.MaNPP   == Convert.ToInt32(MaNhaPhanPhoi)
                           select kh).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.TenNPP = TenNhaPhanPhoi;
                tpQuery.SDTNPP = SoDTNhaPhanPhoi;
                tpQuery.DiaChiNPP = DiaChiNhaPhanPhoi;


                qlXeMay.SubmitChanges();

            }
            return true;
        }

    }
}
