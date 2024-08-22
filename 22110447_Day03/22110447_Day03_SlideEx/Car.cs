using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_SlideEx {
    class Car {
        private int SoXe = 6;
        private string TenXe;
        public Car(string T) {
            TenXe = T;
            Console.WriteLine($"Xe {TenXe} day!");
            SoXe++;
        }
        public Car() {
            Console.WriteLine("Su dung xe...");
            SoXe = 0;
        }
        public void SoLuongXe() {
            Console.WriteLine($"Dang dung {SoXe}");
        }
    }
}
