using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06 {
    public class ListBox : Window {
        private string listBoxContents;

        public ListBox(int top, int left, string listBoxContents) : base(top, left) {
            this.listBoxContents = listBoxContents;
        }

        public override void DrawWindow() {
            Console.WriteLine("Bat dau goi ListBox goi Draw cua Windows");
            base.DrawWindow();
            Console.WriteLine($"---Thuoc ve ListBox {listBoxContents}");
        }
    }
}
