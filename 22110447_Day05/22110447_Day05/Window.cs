using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06 {
    public class Window {
        private int top;
        private int left;

        public Window(int top, int left) {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow() {
            Console.WriteLine($"Ve Window:---> top {top} left {left}");
        }
    }
}
