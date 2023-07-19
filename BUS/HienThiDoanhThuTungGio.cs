using System;

namespace BUS
{
   public class HienThiDoanhThuTungGio
    {
        public int ID { get; set; }
        public DateTime Ngay { get; set; }
        public string Style { get; set; }
        public decimal DayTarget { get; set; }
        public decimal MucTieuTrungBinhNgay { get; set; }
        public decimal DayFinish { get; set; }
        public decimal TotalTarget { get; set; }
        public decimal TotalFinish { get; set; }
        public string NameLine { get; set; }
        public int Soluong { get; set; }
        public decimal Dongia { get; set; }
        public int? DTL1 { get; set; }
        public int? DTL2 { get; set; }
        public int? DTL3 { get; set; }
        public int? DTL4 { get; set; }
        public int? DTL5 { get; set; }
        public int? DTL6 { get; set; }
        public int? DTL7 { get; set; }
        public int? DTL8 { get; set; }
        public int? DTOverTime { get; set; }
        public int SoNgayConLai { get; set; }
        public TimeSpan? GioBD { get; set; }
        public decimal? MO { get; set; }
        public int? MucTieu { get; set; }
    }
}
