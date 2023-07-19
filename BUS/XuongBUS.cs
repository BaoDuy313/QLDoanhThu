using System;
using System.Linq;
using DAL;

namespace BUS
{
  
    public class XuongBUS
    {
        QLDoanhThuDataContext db = new QLDoanhThuDataContext();

        public Object GetDataXuong()
        {
            var query = (from x in db.Facs
                select new 
                {
                    IDFac = x.IDFac,
                    Name = x.Name,
                    Status = x.Status
                });
            return query;
        }
        public Object GetDataXuongCheck()
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
        public void InsertDataXuong(string id, string name,bool status)
        {
            Fac fac = new Fac();
            fac.IDFac = id;
            fac.Name = name;
            fac.Status = status;
            db.Facs.InsertOnSubmit(fac);
            db.SubmitChanges();

        }

        public void UpdateDataXuong(string id, string name,bool status)
        {
            Fac fac = db.Facs.Where(x => x.IDFac == id).SingleOrDefault();
            fac.Name = name;
            fac.Status = status;
            db.SubmitChanges();
        }

        public void DeleteDataXuong(string id)
        {
            Fac fac = db.Facs.Where(x => x.IDFac == id).SingleOrDefault();
            db.Facs.DeleteOnSubmit(fac);
            db.SubmitChanges();
        }
    }
}
