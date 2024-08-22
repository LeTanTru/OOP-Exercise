using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_Vidu {
    public class Button : Window {
        public Button() { }
        public Button(int top, int left) : base(top, left) { }

        public override void DrawWindow() {
            Console.WriteLine($"Drawing a button at {top}: {left}");
        }
    }
}
