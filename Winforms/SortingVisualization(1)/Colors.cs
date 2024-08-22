using System.Collections.Generic;
using System.Drawing;

namespace SortingVisualization_1_ {
    public class Colors {
        // Dictionary to store colors
        public static Dictionary<int, Color> ColorSchema = new Dictionary<int, Color>();

        // Add some colors to dictionary
        public static void Init() {
            Color Turquoise = Color.FromArgb(26, 188, 156);
            Color Emerald = Color.FromArgb(46, 206, 113);
            Color PeterRiver = Color.FromArgb(52, 152, 219);
            Color Alizarin = Color.FromArgb(231, 76, 60);
            Color Carrot = Color.FromArgb(230, 126, 34);
            Color SunFlower = Color.FromArgb(241, 196, 15);
            Color Amethyst = Color.FromArgb(155, 89, 182);

            ColorSchema.Add(0, PeterRiver);
            ColorSchema.Add(1, Turquoise);
            ColorSchema.Add(2, Emerald);
            ColorSchema.Add(3, Alizarin);
            ColorSchema.Add(4, Carrot);
            ColorSchema.Add(5, SunFlower);
            ColorSchema.Add(6, Amethyst);
        }
    }
}
