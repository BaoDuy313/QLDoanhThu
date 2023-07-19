using System;
using System.Linq;
using DAL;

namespace BUS
{
    public class StyleBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();

        public IQueryable<StyleCustomBUS> GetDataStyle(string idline)
        {
            var query = from s in db.Styles
                where s.IDLine == idline
                select new StyleCustomBUS()
                {
                    ID = s.ID,
                    SoLuong = s.SoLuong==null?0:s.SoLuong,
                    DonGia = s.DonGia==null?0:s.DonGia,
                    Ngay = s.Ngay,
                    IDLine = s.IDLine,
                    TinhTrang = s.TinhTrang
                };
            return query;
        }

        public void InsertDataStyle(string id, int soluong, decimal donggia, DateTime ngay,string idline)
        {
            Style s = new Style();
            s.ID = id;
            s.SoLuong = soluong;
            s.DonGia = donggia;
            s.Ngay = ngay;
            s.TinhTrang = "Processing";
            s.IDLine = idline;
            db.Styles.InsertOnSubmit(s);
            db.SubmitChanges();
        }

        public void UpdateDataStyle(string id, int soluong, decimal donggia, DateTime ngay)
        {
            Style s = db.Styles.Where(x => x.ID == id).SingleOrDefault();
            s.SoLuong = soluong;
            s.DonGia = donggia;
            s.Ngay = ngay;
            db.SubmitChanges();
        }

        public int CheckCompleteCTDT(string idStyle)
        {
            var query = (from c in db.CTDTs
                where c.IDStype == idStyle && c.TinhTrang == "Processing"
                select c).Count();
            return query;
        }
        public void UpDateStatus(string id)
        {
            Style s = db.Styles.Where(x => x.ID == id).SingleOrDefault();
            s.TinhTrang = "Completed";
            db.SubmitChanges();
        }

        public void DeleteDataStyle(string id)
        {
             Style s = db.Styles.Where(x => x.ID == id).SingleOrDefault();
             if (s!=null)
             {
                 db.Styles.DeleteOnSubmit(s);
                 db.SubmitChanges();
             }
        }
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
    }
}
