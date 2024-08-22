using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_Employee {
    internal class Program {
        static void Main(string[] args) {
            Employee objEmpOne = new Employee();
            Employee objEmpTwo = new Employee("Allen", 30);
            objEmpOne.ShowData();
            Console.WriteLine();
            objEmpTwo.ShowData();
        }
    }
}
