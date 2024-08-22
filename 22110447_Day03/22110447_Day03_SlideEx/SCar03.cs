using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_SlideEx {
    class SCar03 {
        private static int SoXe = 6;
        public string TenXe;
        public SCar03(string T) {
            TenXe = T;
            Console.WriteLine($"Xe {TenXe} day!");
            SoXe++;
        }
        static SCar03() {
            Console.WriteLine("Su dung xe...");
            SoXe = 0;
        }
        public static void SoLuongXe() {
            Console.WriteLine($"Dang dung {SoXe}");
        }
    }

}
