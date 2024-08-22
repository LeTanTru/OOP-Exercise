using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day01_SquareOf10 {
    internal class Program {
        static void Main(string[] args) {
            int intNum = 10;
            funcSqr(intNum);
            Console.ReadLine();
        }
        static void funcSqr(int intNum) {
            int intsqr;
            intsqr = intNum * intNum;
            Console.WriteLine("Square of the number 10 is {0}",
            intsqr);
        }

    }
}
