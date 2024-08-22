using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization_1_ {
    public class Settings {
        public static frmMain Instance { get; set; }

        private bool randomize; // random value for the array numbers, valid value or invalid value
        public bool Randomize { get { return randomize; } set { randomize = value; } }

        private int size; // array size when form is ran to create new array
        public int Size { get { return size; } set { size = value; } }

        private int lowerLimit; // lower base of random
        public int LowerLimit { get { return lowerLimit; } set { lowerLimit = value; } }

        private int upperLimit; // ceiling of random
        public int UpperLimit { get { return upperLimit; } set { upperLimit = value; } }

        private int delay; // delay when sorting
        public int Delay { get { return delay; } set { delay = value; } }

        private bool isColor; // bool value to set color
        public bool IsColor { get { return isColor; } set { isColor = value; } }

        private int visualizeStyle; // set style of sorting
        public int VisualizeStyle { get { return visualizeStyle; } set { visualizeStyle = value; } }

        public Settings(bool randomize, int size, int lowerLimit, int upperLimit, int delay, bool isColor, int visualizeStyle) {
            this.randomize = randomize;
            this.size = size;
            this.lowerLimit = lowerLimit;
            this.upperLimit = upperLimit;
            this.delay = delay;
            this.isColor = isColor;
            this.visualizeStyle = visualizeStyle;
        }
    }
}
