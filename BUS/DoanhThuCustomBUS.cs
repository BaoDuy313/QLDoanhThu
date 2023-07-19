using System;

namespace BUS
{
    public class DoanhThuCustomBUS
    {
        public int ID { get; set; }
        public DateTime? Ngay { get; set; }
        public Decimal? DoanhThu { get; set; }
        public String NameChiPhi { get; set; }
        public String NameLine { get; set; }
        public String NameStyle { get; set; }
        public int? SoLuong { get; set; }

        public string DVT { get; set; }
        public string TinhTrang { get; set; }
        public int? IDChiPhi { get; set; }
        public int? MucTieu { get; set; }
    }
}
