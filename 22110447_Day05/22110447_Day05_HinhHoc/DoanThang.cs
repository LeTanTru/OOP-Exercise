using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_HinhHoc {
    public class DoanThang : HinhHoc {
        private Point _A, _B;
        public Point A {
            get {
                return _A;
            }
            set {
                _A = value;
            }
        }
        public Point B {
            get {
                return _B;
            }
            set {
                _B = value;
            }
        }

        public DoanThang(Point a, Point b)  {
            _A = a;
            _B = b;
        }

        public override double ChuVi() {
            throw new NotImplementedException(); 
        }

        public override double DienTich() {
            throw new NotImplementedException();
        }

        public override void Ve(Graphics g) {
            g.DrawLine(new Pen(Color.Red, 5), _A, _B);
        }
    }
}
