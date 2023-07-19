using System;
using System.Linq;
using DAL;

namespace BUS
{
    public class HienThiDoanhThuControlBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();
        public Object GetDataXuong()
        {
            var query = (from x in db.Facs
                         where x.Status == true
                         select new
                         {
                             IDFac = x.IDFac,
                             Name = x.Name
                         });
            return query;
        }
        public Object GetDataChuyenTheoMa(string idfac)
        {
            var query = from x in db.Lines
                        where x.IDFace == idfac && x.Status == true
                        select new
                        {
                            IDLine = x.IDLine,
                            Name = x.Name
                        };
            return query;

        }

        public IQueryable<DoanhThuCustomBUS> GetDataDoanhThu(string idline)
        {
            var query = from ctdt in db.CTDTs
                        join cp in db.ChiPhis on ctdt.IDChiPhi equals cp.IDChiPhi
                        join s in db.Styles on ctdt.IDStype equals s.ID
                        join l in db.Lines on cp.IDLine equals l.IDLine
                        where l.IDLine == idline && ctdt.TinhTrang == "Processing"
                        select new DoanhThuCustomBUS()
                        {
                            ID = ctdt.ID,
                            Ngay = ctdt.Ngay,
                            IDChiPhi= ctdt.IDChiPhi,
                            NameChiPhi = cp.Name,
                            NameLine = l.Name,
                            NameStyle = s.ID,
                            TinhTrang = ctdt.TinhTrang,
                            MucTieu = ctdt.MucTieu
                        };
            return query;
        }
    }
}
