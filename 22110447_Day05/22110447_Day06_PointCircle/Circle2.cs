using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_PointCircle {
    public class Circle2 : Point {
        private double radius;

        public Circle2(int xValue, int yValue, double radiusValue): base(xValue, yValue) {
            Radius = radiusValue;
        }

        public double Radius {
            get {
                return radius;
            }

            set {
                if(value >= 0)
                    radius = value;
            }
        }

        public double Diameter() {
            return radius * 2;
        }

        public double Circuference() {
            return Math.PI * Diameter();
        }

        public virtual double area() {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString() {
            base.ToString();
            return $"Center = [{x}, {y}];\nRadius = {radius}";
        }
    }
}
