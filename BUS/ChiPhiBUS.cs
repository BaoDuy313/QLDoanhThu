using System;
using System.Linq;
using DAL;

namespace BUS
{
    public class ChiPhiBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();

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
        

        public IQueryable<ChiPhiCustomBUS> GetDataChiPhiTheoMa(string idline)
        {
           // 
            var query = (from x in db.ChiPhis
                where x.IDLine == idline
                select new ChiPhiCustomBUS()//Update 2023
                {
                    IDChiPhi = x.IDChiPhi,
                    IDLine = x.IDLine,
                    Name = x.Name,
                    ChiPhi = (int) x.ChiPhi1,
                    DVT = x.DVT,
                    TinhTrang = x.TinhTrang,
                    Ngay = (DateTime) x.Ngay,
                    NgayCong =  x.NgayCong ==null?0:x.NgayCong,
                    MO = x.MO==null?0:x.MO//Update 2023
                });
            return query;
        }

        public void InsertChiPhi(string name, DateTime ngay, int chiphi, string dvt,string idline,int ngaycong,decimal mo)
        {
            ChiPhi c = new ChiPhi();
            c.Name = name;
            c.Ngay = ngay;
            c.ChiPhi1 = chiphi;
            c.DVT = dvt;
            c.TinhTrang = "Processing";
            c.IDLine = idline;
            c.NgayCong = ngaycong;
            c.MO = mo;//Update 2023
            db.ChiPhis.InsertOnSubmit(c);
            db.SubmitChanges();

        }

        public void UpdateChiPhi(int id, string name, DateTime ngay, int chiphi, string dvt,int ngaycong, decimal mo)
        {
            ChiPhi c = db.ChiPhis.Where(x => x.IDChiPhi == id).SingleOrDefault();
            c.Name = name;
            c.Ngay = ngay;
            c.ChiPhi1 = chiphi;
            c.DVT = dvt;
            c.NgayCong = ngaycong;
            c.MO = mo;//Update 2023
            db.SubmitChanges();
        }

        public void DeleteChiPhi(int id)
        {
            ChiPhi c = db.ChiPhis.Where(x => x.IDChiPhi == id).SingleOrDefault();
            db.ChiPhis.DeleteOnSubmit(c);
            db.SubmitChanges();
        }

        public void UpdateTinhTrang(int id)
        {
            ChiPhi c = db.ChiPhis.Where(x => x.IDChiPhi == id).SingleOrDefault();
            c.TinhTrang = "Completed";
            db.SubmitChanges();
        }
    }
}
