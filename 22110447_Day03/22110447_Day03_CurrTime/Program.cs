using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_CurrTime {
    internal class Program {
        static void Main(string[] args) {
            DateTime currentTime = DateTime.Now;
            ThoiGian t = new ThoiGian(currentTime);
            t.PresentTime();
        }
    }
}
