using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_Vidu {
    public abstract class Window {
        protected int top;
        protected int left;

        public Window() { }
        public Window(int top, int left) { 
            this.top = top;
            this.left = left;
        }

        public int count(int x) {
            x = top;
            return x;
        }

        public abstract void DrawWindow();
    }
}
