using System;
using System.Linq;
using DAL;

namespace BUS
{
   public class TargetBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();
        public Target HienThiTarget(int idChiPhi,decimal chiphingay,string IDStyle)
        {
            var DoanhThuThang = (from x in db.CTDTs
                                 join s in db.Styles on x.IDStype equals s.ID
                                 where x.IDChiPhi == idChiPhi && x.TinhTrang == "Completed" && s.ID == IDStyle
                                 select x.SoLuong).Sum();
            
            var query = (from x in db.CTDTs
                         join c in db.ChiPhis on x.IDChiPhi equals c.IDChiPhi
                         join s in db.Styles on x.IDStype equals s.ID
                         join l in db.Lines on c.IDLine equals l.IDLine
                         where x.IDChiPhi == idChiPhi && x.TinhTrang == "Processing"
                         select new Target()
                         {
                             ID = x.ID,
                             Ngay = (DateTime)x.Ngay,
                             Style = x.IDStype,
                             DayTarget = (decimal)(chiphingay /s.DonGia),
                             DayFinish = (decimal)(x.SoLuong),
                             TotalTarget =(decimal) s.SoLuong,
                             TotalFinish = (int)(DoanhThuThang==null?0:DoanhThuThang),
                             Soluong = (int)x.SoLuong,
                             Dongia = (decimal)s.DonGia,
                             NameLine = l.Name,
                             Percent = (int)(((x.SoLuong)*100)/(chiphingay/s.DonGia))
                         }).SingleOrDefault();
            return query;
        }
    }
}
