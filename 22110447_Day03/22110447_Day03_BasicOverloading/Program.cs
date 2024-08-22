using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_BasicOverloading {
    internal class Program {
        static void Main(string[] args) {
            
            MyFloat a = new MyFloat(5);
            MyFloat b = new MyFloat(2);
            MyFloat c = a + b;
            MyFloat d = a - b;
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
