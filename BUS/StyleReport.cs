using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StyleReport
    {
        public string NameFac { get; set; }
        public string NameLine { get; set; }
        public string ID { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? Tong { get; set; }
        public DateTime? Ngay { get; set; }
    }
}
