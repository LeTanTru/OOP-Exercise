using System.Collections.Generic;

namespace SortingVisualization_1_ {
    public class MethodName {
        // Dictionary to store some sort algorithm names
        public static SortedDictionary<int, string> MethodNames = new SortedDictionary<int, string>();

        // Add some sort algorithm names to dictionary
        public static void Init() {
            MethodNames.Add(1, "Selection Sort");
            MethodNames.Add(2, "Bubble Sort");
            MethodNames.Add(3, "Insertion Sort");
            MethodNames.Add(4, "Shell Sort");
            MethodNames.Add(5, "Merge Sort");
            MethodNames.Add(6, "Quick Sort");
            
        }
    }
}
