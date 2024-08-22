using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day11_Conditional_Operator_Exercise {
    internal class Program {
        static void Main(string[] args) {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "Even Number" : "Odd Number");
        }
    }
}
