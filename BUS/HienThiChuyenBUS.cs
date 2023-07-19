using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HienThiChuyenBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();
        public Object GetDataChuyenTheoMaCheck(string idfac)
        {
            var query = from x in db.Lines
                        where x.IDFace == idfac //&& x.Status == true
                        select new
                        {
                            IDLine = x.IDLine,
                            Name = x.Name
                        };
            return query;

        }
        public DoanhThuCustomBUS GetDataDoanhThu(string idline)
        {
            var query = (from ctdt in db.CTDTs
                         join cp in db.ChiPhis on ctdt.IDChiPhi equals cp.IDChiPhi
                         join s in db.Styles on ctdt.IDStype equals s.ID
                         join l in db.Lines on cp.IDLine equals l.IDLine
                         where l.IDLine == idline && ctdt.TinhTrang == "Processing"
                         select new DoanhThuCustomBUS()
                         {
                             ID = ctdt.ID,
                             Ngay = ctdt.Ngay,
                             IDChiPhi = ctdt.IDChiPhi,
                             NameChiPhi = cp.Name,
                             NameLine = l.Name,
                             NameStyle = s.ID,
                             TinhTrang = ctdt.TinhTrang,
                             MucTieu = ctdt.MucTieu
                         }).SingleOrDefault();
            return query;
        }

        public int? SoNgayConLai(int idChiPhi)
        {
            var songayDT = db.CTDTs.GroupBy(x => new
            {
                x.Ngay,
                x.IDChiPhi,
                x.TinhTrang
            }).Where(x => x.Key.IDChiPhi == idChiPhi && x.Key.TinhTrang == "Completed").Count();

            var songaycl = (from c in db.ChiPhis
                            where c.IDChiPhi == idChiPhi
                            select c.NgayCong - songayDT).SingleOrDefault();



            return songaycl;

        }

        public HienThiChuyen LayThongTinHienThi(int idChiPhi, int idCTDT)
        {
            var DoanhThuThang = (from x in db.CTDTs
                                 join s in db.Styles on x.IDStype equals s.ID
                                 where x.IDChiPhi == idChiPhi && x.TinhTrang == "Completed"
                                 select x.SoLuong * s.DonGia).Sum();

            var query = (from x in db.CTDTs
                         join c in db.ChiPhis on x.IDChiPhi equals c.IDChiPhi
                         join s in db.Styles on x.IDStype equals s.ID
                         join l in db.Lines on c.IDLine equals l.IDLine
                         where x.ID == idCTDT && x.TinhTrang == "Processing"
                         select new HienThiChuyen()
                         {
                             ID = x.ID,
                             Ngay = (DateTime)x.Ngay,
                             Style = x.IDStype,
                             DayTarget = (decimal)((decimal)((c.ChiPhi1 - (DoanhThuThang == null ? 0 : DoanhThuThang)) / SoNgayConLai(idChiPhi)) / s.DonGia),
                             MucTieuTrungBinhNgay = (decimal)((decimal)(c.ChiPhi1 / c.NgayCong) / s.DonGia),
                             DTL1 = x.DTL1,
                             DTL2 = x.DTL2,
                             DTL3 = x.DTL3,
                             DTL4 = x.DTL4,
                             DTL5 = x.DTL5,
                             DTL6 = x.DTL6,
                             DTL7 = x.DTL7,
                             DTL8 = x.DTL8,
                             TotalTarget = (decimal)s.SoLuong,
                             TotalFinish = (decimal)((int)(DoanhThuThang == null ? 0 : DoanhThuThang) / s.DonGia),
                             Soluong = (int)x.SoLuong,
                             Dongia = (decimal)s.DonGia,
                             NameLine = l.Name,
                             SoNgayConLai = (int)SoNgayConLai(idChiPhi),
                             GioBD = x.GioBD,
                             MO = c.MO   //Update 2023
                         }).SingleOrDefault();
            return query;
        }

    }
}
