using System;

namespace BUS
{
   public class Target
    {
        public int ID { get; set; }
        public DateTime Ngay { get; set; }
        public string Style { get; set; }
        public decimal DayTarget { get; set; }
        public decimal DayFinish { get; set; }
        public decimal TotalTarget { get; set; }
        public decimal TotalFinish { get; set; }
        public string NameLine { get; set; }
        public int Soluong { get; set; }
        public decimal Dongia { get; set; }
        public int Percent { get; set; }


    }
}
