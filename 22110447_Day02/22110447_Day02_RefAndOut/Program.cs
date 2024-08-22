using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_RefAndOut {
    internal class Program {
        static void Main(string[] args) {
            string FstEmp, SecndEmp;
            FstEmp = "Tuan Tran";
            SecndEmp = "Nghia Pham";
            Console.WriteLine($"Inside Main\n----\n{FstEmp}\n {SecndEmp}\n\n");
            changeNames(ref FstEmp, ref SecndEmp);
            Console.WriteLine($"Inside Main Again\n----\n{FstEmp}\n {SecndEmp}\n\n");
        }
        static void changeNames(ref string FstEmp, ref string SecndEmp) {
            FstEmp = "Trang Le";
            SecndEmp = "Cuong Bui";
            Console.WriteLine($"Outside Main\n----\n{FstEmp}\n {SecndEmp}\n\n");
        }
    }
}
