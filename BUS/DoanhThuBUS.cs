using DAL;
using System;
using System.Linq;

namespace BUS
{
    public class DoanhThuBUS
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
                where l.IDLine == idline && s.TinhTrang == "Processing"
                select new DoanhThuCustomBUS()
                {
                    ID = ctdt.ID,
                    Ngay = ctdt.Ngay,
                    DoanhThu =  ctdt.SoLuong * s.DonGia,
                    NameChiPhi = cp.Name,
                    NameLine = l.Name,
                    NameStyle = s.ID,
                    SoLuong = ctdt.SoLuong,
                    DVT = ctdt.DVT,
                    TinhTrang = ctdt.TinhTrang,
                    MucTieu = ctdt.MucTieu
                };
            return query;
        }

        public DoanhThuGioEdit GetDataDoanhThuTungGio(int id)
        {
            var query = (from x in db.CTDTs
                join cp in db.ChiPhis on x.IDChiPhi equals cp.IDChiPhi 
                where x.ID == id
                select new DoanhThuGioEdit()
                {
                    ID = x.ID,
                    Style = x.IDStype,
                    Line = cp.IDLine,
                    DTL1 = x.DTL1,
                    DTL2 = x.DTL2,
                    DTL3 = x.DTL3,
                    DTL4 = x.DTL4,
                    DTL5 = x.DTL5,
                    DTL6 = x.DTL6,
                    DTL7 = x.DTL7,
                    DTL8 = x.DTL8,
                    DTOverTime = x.DTOverTime
                }).SingleOrDefault();
            return query;
        }

        public int CheckCoCTDTChua(DateTime ngay, int idchiphi, string idstyle)
        {
            var query = (from c in db.CTDTs
                where c.Ngay == ngay && c.IDChiPhi == idchiphi && c.IDStype == idstyle
                select c).Count();
            return query;
        }
        public void InsertDataDoanhThu(DateTime ngay, int idchiphi, string idstyle,int muctieu,TimeSpan GioBD)
        {
            CTDT c = new CTDT();
            c.Ngay = ngay;
            c.IDChiPhi = idchiphi;
            c.IDStype = idstyle;
            c.SoLuong = 0;
            c.MucTieu = muctieu;
            c.DVT = "PCS";
            c.TinhTrang = "Processing";
            c.GioBD = GioBD;
            db.CTDTs.InsertOnSubmit(c);
            db.SubmitChanges();
        }

        public void UpdateDoanhThu(int id, int soluong)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.SoLuong = soluong;
            db.SubmitChanges();
        }
        public void UpdateDoanhThuAndMucTieu(int id, int soluong,int muctieu)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.SoLuong = soluong;
            c.MucTieu = muctieu;
            db.SubmitChanges();
        }

        public void UpdateTinhTrangDoanhThu(int id)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            c.TinhTrang = "Completed";
            db.SubmitChanges();
        }

        public void DeleteDoanhThu(int id)
        {
            CTDT c = db.CTDTs.Where(x => x.ID == id).SingleOrDefault();
            db.CTDTs.DeleteOnSubmit(c);
            db.SubmitChanges();
        }


        public Object GetDataStyleTheoLine(string idline)
        {
            var query = from x in db.Styles
                where x.IDLine == idline && x.TinhTrang =="Processing"
                select new 
                {
                    ID = x.ID
                };
            return query;
        }

        public Object GetDataChiPhiTheoLine(string idline)
        {
            var query = from x in db.ChiPhis
                where x.IDLine == idline && x.TinhTrang =="Processing"
                select new
                {
                    ID = x.IDChiPhi,
                    Name = x.Name
                };
            return query;
        }

        public int? SoNgayConLai(int idChiPhi)
        {
    
            var songayDT = (from x in db.CTDTs
                where x.IDChiPhi == idChiPhi && x.TinhTrang == "Completed"
                select x).Count();
            var songaycl = (from c in db.ChiPhis
                where c.IDChiPhi == idChiPhi
                select c.NgayCong - songayDT).SingleOrDefault();
                
                  
              
            return songaycl;

        }

        public HienThiDoanhThuBUS LayDanhSachHienThi(int idChiPhi)
        {
            var DoanhThuThang = (from x in db.CTDTs
                join s in db.Styles on x.IDStype equals s.ID 
                where x.IDChiPhi == idChiPhi && x.TinhTrang == "Completed"
                select x.SoLuong*s.DonGia).Sum();
            
            var query = (from x in db.CTDTs
                join c in db.ChiPhis on x.IDChiPhi equals c.IDChiPhi
                join s in db.Styles on x.IDStype equals s.ID
                join l in db.Lines on c.IDLine equals l.IDLine 
                where x.IDChiPhi == idChiPhi && x.TinhTrang == "Processing"
                select new HienThiDoanhThuBUS()
                {
                    ID = x.ID,
                    Ngay = (DateTime)x.Ngay,
                    Style = x.IDStype,
                    ChiPhiNgay = (decimal)((c.ChiPhi1-(DoanhThuThang==null?0:DoanhThuThang))/SoNgayConLai(idChiPhi)),
                    DoanhThuNgay = (decimal)(x.SoLuong * s.DonGia),
                    ChiPhiThang = (int)c.ChiPhi1,
                    DoanhThuThang = (decimal)(DoanhThuThang ?? 0),
                    SoNgayConLai = (int)SoNgayConLai(idChiPhi),
                    SoLuong = (int)x.SoLuong,
                    DonGia = (decimal)s.DonGia,
                    NameLine = l.Name
                }).SingleOrDefault();
            return query;
        }
        
       
    }
}
