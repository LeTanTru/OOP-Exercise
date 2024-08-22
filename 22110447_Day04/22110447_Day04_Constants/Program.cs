using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_Constants {
    internal class Program {
        static void Main(string[] args) {
            const double gravityForce = 9.8;
            double PI = 3.14159265359;
            // Error
            //gravityForce = 1;
            Console.WriteLine($"Gravity force is {gravityForce} and PI is {PI}");
        }
    }
}
