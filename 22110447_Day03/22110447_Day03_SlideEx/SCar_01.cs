using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_SlideEx {
    internal class SCar_01 {
        private static int SoXe = 6;
        private string TenXe;
        public SCar_01(string T) {
            TenXe = T;
            Console.WriteLine($"Xe {TenXe} day!");
            SoXe++;
        }
        public SCar_01() {
            Console.WriteLine("Su dung xe...");
            SoXe = 0;
        }
        public static void SoLuongXe() {
            Console.WriteLine($"Dang dung {SoXe}");
        }
    }
}
