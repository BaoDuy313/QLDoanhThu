using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class ChiPhiReportBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();
        public IQueryable<ChiPhiCustomBUS> GetDataChiPhi(DateTime time)
        {
            var query = from cp in db.ChiPhis
                        join l in db.Lines on cp.IDLine equals l.IDLine
                        join f in db.Facs on l.IDFace equals f.IDFac
                        where cp.Ngay.Value.Year == time.Year && l.Status == true && f.Status == true
                        select new ChiPhiCustomBUS()
                        {
                            IDChiPhi = cp.IDChiPhi,
                            IDLine = cp.IDLine,
                            Name = cp.Name,
                            ChiPhi = (int)cp.ChiPhi1,
                            DVT = cp.DVT,
                            TinhTrang = cp.TinhTrang,
                            Ngay = (DateTime)cp.Ngay,
                            NgayCong = cp.NgayCong == null ? 0 : cp.NgayCong,
                            MO = cp.MO == null ? 0 : cp.MO
                        };
            return query;
        }
        public List<HienThiChart> GetDataChiPhiNam()
        {
            var query = from cp in db.ChiPhis
                        join l in db.Lines on cp.IDLine equals l.IDLine
                        join f in db.Facs on l.IDFace equals f.IDFac
                        where l.Status == true && f.Status == true
                        select new ChiPhiCustomBUS()
                        {
                            IDChiPhi = cp.IDChiPhi,
                            IDLine = cp.IDLine,
                            Name = cp.Name,
                            ChiPhi = (int)cp.ChiPhi1,
                            DVT = cp.DVT,
                            TinhTrang = cp.TinhTrang,
                            Ngay = (DateTime)cp.Ngay,
                            NgayCong = cp.NgayCong == null ? 0 : cp.NgayCong,
                            MO = cp.MO == null ? 0 : cp.MO
                        };
            List<HienThiChart> charts = query.GroupBy(cp => cp.Ngay.Year).Select(cp => new HienThiChart
            {
                ThoiGian = "Năm " + cp.Key.ToString(),
                Tong = Convert.ToInt32(cp.Sum(c => c.ChiPhi).ToString())
            }).ToList();
            return charts;
        }
        public List<HienThiChart> GetDataChiPhiThang(DateTime time)
        {
            var query = from cp in db.ChiPhis
                        join l in db.Lines on cp.IDLine equals l.IDLine
                        join f in db.Facs on l.IDFace equals f.IDFac
                        where cp.Ngay.Value.Year == time.Year && l.Status == true && f.Status == true
                        select new ChiPhiCustomBUS()
                        {
                            IDChiPhi = cp.IDChiPhi,
                            IDLine = cp.IDLine,
                            Name = cp.Name,
                            ChiPhi = (int)cp.ChiPhi1,
                            DVT = cp.DVT,
                            TinhTrang = cp.TinhTrang,
                            Ngay = (DateTime)cp.Ngay,
                            NgayCong = cp.NgayCong == null ? 0 : cp.NgayCong,
                            MO = cp.MO == null ? 0 : cp.MO
                        };
            List<HienThiChart> charts = query.GroupBy(cp => cp.Ngay.Month).Select(cp => new HienThiChart
            {
                ThoiGian = "Tháng " + cp.Key.ToString(),
                Tong = Convert.ToInt32(cp.Sum(c => c.ChiPhi).ToString())
            }).ToList();
            return charts;
        }
    }
}
