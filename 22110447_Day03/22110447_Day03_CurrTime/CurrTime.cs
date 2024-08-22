using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22110447_Day03_CurrTime {
    public class ThoiGian {
        private static string Name;
        int Nam;
        int Thang;
        int Ngay;
        int Gio;
        int Phut;
        int Giay;
        static ThoiGian() {
            Name = "C#";
        }
        public ThoiGian(DateTime dt) {
            this.Nam = dt.Year;
            this.Thang = dt.Month;
            this.Ngay = dt.Day;
            this.Gio = dt.Hour;
            this.Phut = dt.Minute;
            this.Giay = dt.Second;
        }
        public void PresentTime() {
            Console.WriteLine($"Bieu dien thoi gian bang {Name}");
            Console.WriteLine($"Display Current Time: {Ngay}/{Thang}/{Nam}--{Gio}:{Phut}:{Giay}");
        }
    }
}
