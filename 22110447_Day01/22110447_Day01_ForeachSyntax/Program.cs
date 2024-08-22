using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_ForeachSyntax {
    internal class Program {
        static void Main(string[] args) {
            int[] A = { 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(var x in A) {
                Console.WriteLine(x);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
