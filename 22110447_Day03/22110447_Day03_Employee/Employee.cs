using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_Employee {
    class Employee {
        private string name;
        private int age;

        public Employee() {
            this.name = "Mark";
            this.age = 25;
        }

        public Employee(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public void ShowData() {
            Console.WriteLine($"Name = {this.name}");
            Console.WriteLine($"Age = {this.age}");
        }
    }
}
