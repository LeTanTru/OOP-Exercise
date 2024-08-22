using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_Polymor {
    public class ListBox : Window {
        private string listBoxContents;

        public ListBox(int top, int left, string contents) : base(top, left) {
            this.listBoxContents = contents;
        }

        public override void DrawWindow() {
            base.DrawWindow();
            Console.WriteLine($"---Thuoc ve ListBox {listBoxContents}");
        }
    }
}
