using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_HinhHoc {
    public class TamGiac : HinhHoc {
        private Point _A, _B, _C;

        public Point A {
            get { return _A; }
            set { _A = value; }
        }

        public Point B {
            get { return _B; }
            set { _B = value; }
        }

        public Point C {
            get { return _C; }
            set { _C = value; }
        }

        public new Point Tam {
            get {
                return new Point((_A.X + _B.X + _C.X) / 3, (_A.Y + _B.Y + _C.Y) / 3);
            }
        }
        public TamGiac() { }
        public TamGiac(Point a, Point b, Point c) {
            _A = a;
            _B = b;
            _C = c;
        }

        public double TinhDoDai(Point a, Point b) {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public override double ChuVi() {
            double ab = TinhDoDai(_A, _B);
            double bc = TinhDoDai(_B, _C);
            double ac = TinhDoDai(_A, _C);
            return ab + bc + ac;
        }

        public override double DienTich() {
            double ab = TinhDoDai(_A, _B);
            double bc = TinhDoDai(_B, _C);
            double ac = TinhDoDai(_A, _C);
            double p = (ab + bc + ac) / 2;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        public override void Ve(Graphics g) {
            Console.WriteLine("Tam giac:.....");
            g.DrawLine(new Pen(Color.Red, 5), _A, _B);
            g.DrawLine(new Pen(Color.Red, 5), _B, _C);
            g.DrawLine(new Pen(Color.Red, 5), _A, _C);
        }
    }
}
