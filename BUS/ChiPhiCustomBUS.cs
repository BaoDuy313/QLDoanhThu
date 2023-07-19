using System;

namespace BUS
{
    public class ChiPhiCustomBUS
    {
        public int IDChiPhi { get; set; }
        public string Name { get; set; }
        public DateTime Ngay { get; set; }
        public int ChiPhi { get; set; }
        public string DVT { get; set; }
        public string TinhTrang { get; set; }
        public string IDLine { get; set; }
        public int? NgayCong { get; set; }
        public decimal? MO { get; set; }//Update 2023

    }
}
