using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_HinhHoc {
    public class TuGiac : HinhHoc {
        private Point _Dinh1;
        private Point _Dinh2;
        private Point _Dinh3;
        private Point _Dinh4;

        public Point Dinh1 {
            get {
                return _Dinh1;
            }
            set {
                _Dinh1 = value;
            }
        }

        public Point Dinh2 {
            get {
                return _Dinh2;
            }
            set {
                _Dinh2 = value;
            }
        }

        public Point Dinh3 {
            get {
                return _Dinh3;
            }
            set {
                _Dinh3 = value;
            }
        }

        public Point Dinh4 {
            get {
                return _Dinh4;
            }
            set {
                _Dinh4 = value;
            }
        }

        public TuGiac(Point dinh1, Point dinh2, Point dinh3, Point dinh4) {
            _Dinh1 = dinh1;
            _Dinh2 = dinh2;
            _Dinh3 = dinh3;
            _Dinh4 = dinh4;
        }

        public double TinhDoDai(Point a, Point b) {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public override double ChuVi() {
            double ab = TinhDoDai(_Dinh1, _Dinh2);
            double bc = TinhDoDai(_Dinh2, _Dinh3);
            double cd = TinhDoDai(_Dinh3, _Dinh4);
            double ad = TinhDoDai(_Dinh4, _Dinh1);
            return ab + bc + cd + ad;
        }

        public override double DienTich() {
            double ab = TinhDoDai(_Dinh1, _Dinh2);
            double bc = TinhDoDai(_Dinh2, _Dinh3);
            double ac = TinhDoDai(_Dinh1, _Dinh3);
            double cd = TinhDoDai(_Dinh3, _Dinh4);
            double ad = TinhDoDai(_Dinh1, _Dinh4);

            double p1 = (ab + bc + ac) / 2;
            double p2 = (ac + cd + ad) / 2;

            double s1 = Math.Sqrt(p1 * (p1 - ab) * (p1 - bc) * (p1 - ac));
            double s2 = Math.Sqrt(p2 * (p2 - ac) * (p2 - cd) * (p2 - ad));

            return s1 + s2;
           
        }

        public override void Ve(Graphics g) {
            Pen pen = new Pen(Color.Red, 5);

            g.DrawLine(pen, _Dinh1, _Dinh2);

            g.DrawLine(pen, _Dinh2, _Dinh3);

            g.DrawLine(pen, _Dinh3, _Dinh4);

            g.DrawLine(pen, _Dinh4, _Dinh1);
        }
    }
}
