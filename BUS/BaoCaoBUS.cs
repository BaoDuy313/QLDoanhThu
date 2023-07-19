using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoCaoBUS
    {
        private readonly TimeSpan _dl5 = TimeSpan.Parse("12:30:00");
        private readonly TimeSpan _cl8 = TimeSpan.Parse("16:30:00");
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();
        public Object GetDataXuong()
        {
            var query = (from x in db.Facs
                         where x.Status == true
                         select new
                         {
                             IDFac = x.IDFac,
                             Name = x.Name,
                             Status = x.Status
                         });
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
        
        public int MucTieuNgay(TimeSpan GioBD,int mucTieu)
        {
            int soGioLamViec = 0;
            if (GioBD < _dl5)
            {
                soGioLamViec = (_cl8 - GioBD).Hours - 1;
            }
            else
            {
                soGioLamViec = (_cl8 - GioBD).Hours;
            }
            int t;
            if (soGioLamViec > 0)
            {
                if (mucTieu % soGioLamViec == 0)
                {
                    t = mucTieu / soGioLamViec;
                }
                else
                {
                    t = (mucTieu / soGioLamViec) + 1;
                }
            }
            else
            {
                t = mucTieu;
            }
           
            
            return t;
        }
        public IQueryable<BaoCao> LayThongTinHienThi(string idfac,DateTime time)
        {

            var query = (from x in db.CTDTs
                         join c in db.ChiPhis on x.IDChiPhi equals c.IDChiPhi
                         join s in db.Styles on x.IDStype equals s.ID
                         join l in db.Lines on c.IDLine equals l.IDLine
                         join f in db.Facs on l.IDFace equals f.IDFac
                         where f.IDFac == idfac && x.Ngay == time && l.Status == true && f.Status == true //&& x.TinhTrang == "Processing"
                         select new BaoCao()
                         {
                             ID = x.ID,
                             Ngay = (DateTime)x.Ngay,
                             Style = x.IDStype,
                             MucTieuTrungBinhNgay = (decimal)((decimal)(c.ChiPhi1 / c.NgayCong) / s.DonGia),
                             DTL1 = x.DTL1 == null ? 0 : x.DTL1,
                             DTL2 = x.DTL2 == null ? 0 : x.DTL2,
                             DTL3 = x.DTL3 == null ? 0 : x.DTL3,
                             DTL4 = x.DTL4 == null ? 0 : x.DTL4,
                             DTL5 = x.DTL5 == null ? 0 : x.DTL5,
                             DTL6 = x.DTL6 == null ? 0 : x.DTL6,
                             DTL7 = x.DTL7 == null ? 0 : x.DTL7,
                             DTL8 = x.DTL8 == null ? 0 : x.DTL8,
                             DTOverTime = x.DTOverTime == null ? 0 : x.DTOverTime,
                             TotalTarget = (decimal)s.SoLuong,
                             Soluong = (int)x.SoLuong,
                             Dongia = (decimal)s.DonGia,
                             NameLine = l.Name,
                             SoNgayConLai = (int)SoNgayConLai(c.IDChiPhi),
                             GioBD = x.GioBD,
                             MO = c.MO,
                             MucTieuNgay = MucTieuNgay((TimeSpan)x.GioBD, (int)x.MucTieu),
                             MucTieu = x.MucTieu
                             //Update 2023
                         });
            return query;
        }
    }
}
