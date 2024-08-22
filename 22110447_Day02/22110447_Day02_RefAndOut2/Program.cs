using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_RefAndOut2 {
    internal class Program {
        static void Main(string[] args) {
            string FstEmp, SecndEmp;
            //SecndEmp = "Nghia Pham";
            //Console.WriteLine($"Inside Main\n----\n{FstEmp}\n {SecndEmp}\n\n");
            changeNames(out FstEmp, out SecndEmp);
            Console.WriteLine($"Inside Main Again\n----\n{FstEmp}\n {SecndEmp}\n\n");
        }
        static void changeNames(out string FstEmp, out string SecndEmp) {
            FstEmp = "Trang Le";
            SecndEmp = "Cuong Bui";
            Console.WriteLine($"Outside Main\n----\n{FstEmp}\n {SecndEmp}\n\n");
        }
    }
}
