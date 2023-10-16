using System;
using System.Linq;
using DAL;

namespace BUS
{
  public  class HienThiDoanhThuTungGioBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();
        public int? SoNgayConLai(int idChiPhi)
        {
            /*var TotalDTComplete = (from x in db.CTDTs
                            where x.IDChiPhi == idChiPhi && x.TinhTrang == "Completed"

                            select x);
            var songayDT = TotalDTComplete.GroupBy(
                p => p.Ngay
            ).Count();*/
            /*var songayDT = (from x in db.CTDTs
               where x.IDChiPhi == idChiPhi && x.TinhTrang == "Completed"

                           select x).Count();*/

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

        public HienThiDoanhThuTungGio LayThongTinHienThi(int idChiPhi,int idCTDT)
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
                         select new HienThiDoanhThuTungGio()
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
                             MucTieu = x.MucTieu,
                             MO = c.MO,   //Update 2023
                             SoluongStyle = s.SoLuong  //Update 2023
                         }).SingleOrDefault();
            return query;
        }

        public void UpdateDT1(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.DTL1 = soluong;
            db.SubmitChanges();
        }
        public void UpdateDT2(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.DTL2 = soluong;
            db.SubmitChanges();
        }
        public void UpdateDT3(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.DTL3 = soluong;
            db.SubmitChanges();
        }
        public void UpdateDT4(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.DTL4 = soluong;
            db.SubmitChanges();
        }
        public void UpdateDT5(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.DTL5 = soluong;
            db.SubmitChanges();
        }
        public void UpdateDT6(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.DTL6 = soluong;
            db.SubmitChanges();
        }
        public void UpdateDT7(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.DTL7 = soluong;
            db.SubmitChanges();
        }
        public void UpdateDT8(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.DTL8 = soluong;
            db.SubmitChanges();
        }
        public void UpdateDT9(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.DTOverTime = soluong;
            db.SubmitChanges();
        }
        public void UpdateDoanhThu(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.SoLuong = soluong;
            db.SubmitChanges();
        }

        public void UpdateMultiDoanhThu(int id, int DT1, int DT2, int DT3, int DT4, int DT5, int DT6, int DT7, int DT8,
                                        int DTOverTime)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            if (DT1!=-1)
            {
                c.DTL1 = DT1;
            }

            if (DT2!=-1)
            {
                c.DTL2 = DT2;
            }
            if (DT3 != -1)
            {
                c.DTL3 = DT3;
            }
            if (DT4 != -1)
            {
                c.DTL4 = DT4;
            }
            if (DT5 != -1)
            {
                c.DTL5 = DT5;
            }
            if (DT6 != -1)
            {
                c.DTL6 = DT6;
            }
            if (DT7 != -1)
            {
                c.DTL7 = DT7;
            }
            if (DT8 != -1)
            {
                c.DTL8 = DT8;
            }
            if (DTOverTime != -1)
            {
                c.DTOverTime = DTOverTime;
            }
            db.SubmitChanges();
        }
        public void UpdateMultiDoanhThuAndSoLuong(int id, int DT1, int DT2, int DT3, int DT4, int DT5, int DT6, int DT7, int DT8,
                                        int DTOverTime)
        {
            int soluong = 0 ;
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            if (DT1 != -1)
            {
                c.DTL1 = DT1;
                soluong += DT1;
            }

            if (DT2 != -1)
            {
                c.DTL2 = DT2;
                soluong += DT2;
            }
            if (DT3 != -1)
            {
                c.DTL3 = DT3;
                soluong += DT3;
            }
            if (DT4 != -1)
            {
                c.DTL4 = DT4;
                soluong += DT4;
            }
            if (DT5 != -1)
            {
                c.DTL5 = DT5;
                soluong += DT5;
            }
            if (DT6 != -1)
            {
                c.DTL6 = DT6;
                soluong += DT6;
            }
            if (DT7 != -1)
            {
                c.DTL7 = DT7;
                soluong += DT7;
            }
            if (DT8 != -1)
            {
                c.DTL8 = DT8;
                soluong += DT8;
            }
            if (DTOverTime != -1)
            {
                c.DTOverTime = DTOverTime;
                soluong += DTOverTime;
            }

            c.SoLuong = soluong;
            db.SubmitChanges();

        }
    }
}
