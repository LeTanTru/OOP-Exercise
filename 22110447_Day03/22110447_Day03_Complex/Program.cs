using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_Complex {
    internal class Program {
        static void Main(string[] args) {
            Complex objComOne = new Complex(10, 20);
            objComOne.showXY();
            Complex objComTwo = new Complex();
            objComTwo.showXY();
            objComTwo = -objComOne;
            objComTwo.showXY();

        }
    }
}
