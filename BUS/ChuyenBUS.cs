using System;
using System.Linq;
using DAL;

namespace BUS
{
   public class ChuyenBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();

        public Object GetDataChuyen()
        {
            var query = (from l in db.Lines
                join f in db.Facs on l.IDFace equals f.IDFac
                where f.Status == true
                select new
                {
                    IDFac = l.IDFace,
                    IDLine = l.IDLine,
                    NameLine = l.Name,
                    NameFac = f.Name,
                    Status = l.Status
                }).ToList();
            return query;
        }

        public void InsertDataChuyen(string idfac, string idline, string name,bool status)
        {
            Line line = new Line();
            line.IDFace = idfac;
            line.IDLine = idline;
            line.Name = name;
            line.Status = status;

            db.Lines.InsertOnSubmit(line);
            db.SubmitChanges();
        }

        public void DeleteDataChuyen(string idline)
        {
            Line line = db.Lines.Where(x => x.IDLine == idline).SingleOrDefault();
            if (line!=null)
            {
                db.Lines.DeleteOnSubmit(line);
                db.SubmitChanges();
            }
        }

        public void UpdateDataChuyen(string idline, string idfac, string name,bool status)
        {
            Line line = db.Lines.Where(x => x.IDLine == idline).SingleOrDefault();
            if (line!=null)
            {
                line.IDFace = idfac;
                line.Name = name;
                line.Status = status;
                db.SubmitChanges();
            }
        }
    }
}
