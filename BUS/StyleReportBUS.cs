using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class StyleReportBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();

        public IQueryable<StyleCustomBUS> GetDataStyle()
        {
            var query = from s in db.Styles
                        join l in db.Lines on s.IDLine equals l.IDLine
                        join f in db.Facs on l.IDFace equals f.IDFac
                        where l.Status == true && f.Status == true
                        select new StyleCustomBUS()
                        {
                            ID = s.ID,
                            SoLuong = s.SoLuong == null ? 0 : s.SoLuong,
                            DonGia = s.DonGia == null ? 0 : s.DonGia,
                            Ngay = s.Ngay,
                            IDLine = s.IDLine,
                            TinhTrang = s.TinhTrang
                        };
            return query;
        }
        public IQueryable<StyleReport> GetDataDoanhThuStyle(string idStyle)
        {
            var query = from ct in db.CTDTs
                        join cp in db.ChiPhis on ct.IDChiPhi equals cp.IDChiPhi
                        join s in db.Styles on ct.IDStype equals s.ID
                        join l in db.Lines on s.IDLine equals l.IDLine
                        join f in db.Facs on l.IDFace equals f.IDFac
                        where ct.IDStype == idStyle && l.Status == true && f.Status == true
                        select new StyleReport()
                        {
                            NameFac = f.Name,
                            NameLine = l.Name,
                            ID = ct.IDStype,
                            SoLuong = ct.SoLuong,
                            DonGia = s.DonGia,
                            Tong = ct.SoLuong * s.DonGia,
                            Ngay = ct.Ngay
                        };
            return query;
        }
    }
}
