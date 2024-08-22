using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_Vidu {
    public class ListBox : Window {
        private string mListBoxContents;
        public ListBox(int top, int left, string theContent) : base(top, left) {
            mListBoxContents = theContent;
        }
        public override void DrawWindow() {
            Console.WriteLine($"List box write: {mListBoxContents}");
        }
    }
}
