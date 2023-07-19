using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class DoanhThuReportBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();
        public IQueryable<DoanhThuCustomBUS> GetDataDoanhThu(DateTime time)
        {
            var query = from ct in db.CTDTs
                        join cp in db.ChiPhis on ct.IDChiPhi equals cp.IDChiPhi
                        join s in db.Styles on ct.IDStype equals s.ID
                        join l in db.Lines on s.IDLine equals l.IDLine
                        join f in db.Facs on l.IDFace equals f.IDFac
                        where ct.Ngay.Value.Year == time.Year && l.Status == true && f.Status == true
                        select new DoanhThuCustomBUS()
                        {
                            ID = ct.ID,
                            Ngay = ct.Ngay,
                            DoanhThu = ct.SoLuong * s.DonGia,
                            NameChiPhi = cp.Name,
                            NameLine = l.Name,
                            NameStyle = s.ID,
                            SoLuong = ct.SoLuong,
                            DVT = ct.DVT,
                            TinhTrang = ct.TinhTrang,
                            MucTieu = ct.MucTieu
                        };
            return query;
        }
        public IQueryable<HienThiChart> GetDataDoanhThuNgay(DateTime time)
        {
            var query = from ct in db.CTDTs
                        join cp in db.ChiPhis on ct.IDChiPhi equals cp.IDChiPhi
                        join s in db.Styles on ct.IDStype equals s.ID
                        join l in db.Lines on s.IDLine equals l.IDLine
                        join f in db.Facs on l.IDFace equals f.IDFac
                        where ct.Ngay == time && l.Status == true && f.Status == true
                        select new HienThiChart()
                        {
                            ThoiGian = l.Name,
                            Tong = ct.SoLuong * s.DonGia
                        };
            return query;
        }
        public List<HienThiChart> GetDataDoanhThuThang(DateTime time)
        {
            var query = from ct in db.CTDTs
                        join cp in db.ChiPhis on ct.IDChiPhi equals cp.IDChiPhi
                        join s in db.Styles on ct.IDStype equals s.ID
                        join l in db.Lines on s.IDLine equals l.IDLine
                        join f in db.Facs on l.IDFace equals f.IDFac
                        where ct.Ngay.Value.Year == time.Year && l.Status == true && f.Status == true
                        select new DoanhThuCustomBUS()
                        {
                            ID = ct.ID,
                            Ngay = ct.Ngay,
                            DoanhThu = ct.SoLuong * s.DonGia,
                            NameChiPhi = cp.Name,
                            NameLine = l.Name,
                            NameStyle = s.ID,
                            SoLuong = ct.SoLuong,
                            DVT = ct.DVT,
                            TinhTrang = ct.TinhTrang,
                            MucTieu = ct.MucTieu
                        };
            List<HienThiChart> charts = query.GroupBy(ct => ct.Ngay.Value.Month).Select(ct => new HienThiChart
            {
                ThoiGian = "Tháng " + ct.Key.ToString(),
                Tong = Convert.ToDecimal(ct.Sum(d => d.DoanhThu).ToString())
            }).ToList();
            return charts;
        }
        public List<HienThiChart> GetDataDoanhThuNam()
        {
            var query = from ct in db.CTDTs
                        join cp in db.ChiPhis on ct.IDChiPhi equals cp.IDChiPhi
                        join s in db.Styles on ct.IDStype equals s.ID
                        join l in db.Lines on cp.IDLine equals l.IDLine
                        join f in db.Facs on l.IDFace equals f.IDFac
                        where l.Status == true && f.Status == true
                        select new DoanhThuCustomBUS()
                        {
                            ID = ct.ID,
                            Ngay = ct.Ngay,
                            DoanhThu = ct.SoLuong * s.DonGia,
                            NameChiPhi = cp.Name,
                            NameLine = l.Name,
                            NameStyle = s.ID,
                            SoLuong = ct.SoLuong,
                            DVT = ct.DVT,
                            TinhTrang = ct.TinhTrang,
                            MucTieu = ct.MucTieu
                        };
            List<HienThiChart> charts = query.GroupBy(ct => ct.Ngay.Value.Year).Select(ct => new HienThiChart
            {
                ThoiGian = "Năm " + ct.Key.ToString(),
                Tong = Convert.ToDecimal(ct.Sum(d => d.DoanhThu).ToString())
            }).ToList();
            return charts;
        }
    }
}
