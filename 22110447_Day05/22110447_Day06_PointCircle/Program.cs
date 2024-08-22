using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day06_PointCircle {
    internal class Program {
        static void Main(string[] args) {
            Point point = new Point(72, 115);
            Circle2 circle = new Circle2(10, 20, 30);

            string output = $"X coordinate is {point.X}\nY coordinate is {point.Y}";

            point.X = 10;
            point.Y = 10;

            output += $"\nThe new location of point is {point}";
            output += $"\nThe new location of point is {circle}";

            MessageBox.Show(output, "Demonstrating Class Point", MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
