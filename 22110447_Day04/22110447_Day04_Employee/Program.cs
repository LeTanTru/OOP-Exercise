using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_Employee {
    internal class Program {
        static void Main(string[] args) {
            Employee e = new Employee("Bob", "Jones", 2, 2, 1890, 3, 12, 2016);
            Console.WriteLine(e.ToString());
        }
    }
}
