using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_HinhHoc {
    public class HinhChuNhat : TuGiac {
        private Point _Dinh1;
        private Point _Dinh2;
        private Point _Dinh3;
        private Point _Dinh4;

        public HinhChuNhat(Point dinh1, Point dinh2, Point dinh3, Point dinh4) 
            : base(
            dinh1, dinh2, dinh3, dinh4)
            {
            
        }
        public override double DienTich() {
           return base.DienTich();
        }
    }
}
