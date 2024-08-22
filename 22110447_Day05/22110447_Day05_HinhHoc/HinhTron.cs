using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_HinhHoc {
    public class HinhTron : HinhHoc {
        private double _BanKinh;

        public double BanKinh {
            get {
                return _BanKinh;
            }
            set {
                _BanKinh = value;
            }
        }

        public HinhTron(double r) {
            _BanKinh = r;
        }

        public override double ChuVi() {
            return 2 * Math.PI * _BanKinh;
        }

        public override double DienTich() {
            return Math.PI * _BanKinh * _BanKinh;
        }

        public override void Ve(Graphics g) {
            g.DrawEllipse(new Pen(Color.Red, 5), (int)_BanKinh, (int)_BanKinh, (int)_BanKinh, (int)_BanKinh);
        }
    }

}
