using System.Collections.Generic;

namespace SortingVisualization {
    public class VisualStyle {
        // Dictionary to store some visual style names
        public static Dictionary<int, string> VisualStyleNames { get; } = new Dictionary<int, string>();


        // Add some visual style names to dictionary
        public static void Init() {
            VisualStyleNames.Add(1, "Lines");
            VisualStyleNames.Add(2, "Dots");
        }
    }
}
