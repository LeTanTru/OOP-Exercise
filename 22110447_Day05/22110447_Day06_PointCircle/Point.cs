using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_PointCircle {
    public class Point {
        protected int x, y;
        public Point() {
        }

        public Point(int xValue, int yValue) {
            x = xValue;
            y = yValue;
        }

        public int X {
            get {
                return x;
            }

            set {
                x = value;
            }
        }

        public int Y {
            get {
                return y;
            }

            set {
                y = value;
            }
        }
        public override string ToString() {
            base.ToString();

            return $"[{x}, {y}]";
        }

    }
}
