using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_Polymor {
    public class ListBox : Window {
        private string mlistBoxContents;

        public ListBox() { }
        public ListBox(int top, int left, string theContents) : base(top, left) {
            mlistBoxContents = theContents;
        }

        public override void VeHinh() {
            throw new NotImplementedException();
        }

        public override void DrawWindow() {
            Console.WriteLine($"ListBox write: {mlistBoxContents}/{top}/{left}");
        }
    }
}
