using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_ValueVsReference {
    internal class Program {
        static void Main(string[] args) {
            string firstEmp, secEmp;
            firstEmp = "David Smith";
            secEmp = "Sophia Watson";
            Console.WriteLine($"Inside Main Method\n-------\n{firstEmp} \n{secEmp}\n\n");
            ChangeNames(ref firstEmp, ref secEmp);
            Console.WriteLine($"Inside Main Method Again\n-------\n{firstEmp} \n{secEmp}\n\n");
        }
        static void ChangeNames(ref string firstEmp, ref string secEmp) {
            firstEmp = "Olivia Aaronn";
            secEmp = "Alvaro Salazar";
            Console.WriteLine($"Outside Main Method\n--------\n{firstEmp} \n{secEmp}\n\n");
        }
    }
}
