using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_Overloading01 {
    internal class Program {
        static void Main(string[] args) {
            MyFloat a = new MyFloat(3.1f);
            MyFloat b = new MyFloat(5.1f);
            MyFloat c = new MyFloat();
            c = a + b;
            c = a - b;
            Console.WriteLine(c.ToString());
        }
    }
}
