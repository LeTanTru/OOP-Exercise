using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06 {
    public class Button : Window {
        public Button(int top, int left) : base(top, left) { }

        public override void DrawWindow() {
            Console.WriteLine("Ve lai button----");
            base.DrawWindow();
            Console.WriteLine("-----Ket thuc ve lai button");
        }

        public void DrawWindow(int a, int b) {
            Console.WriteLine($"Day la cua Draw cua rieng Button voi 2 thong so {a} va {b}");
        }
    }
}
