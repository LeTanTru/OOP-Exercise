using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day11_Conditional_Operator__Ternary_Operator_ {
    internal class Program {
        static void Main(string[] args) {
            //if (IsAdmin())
            //{
            //    Console.WriteLine("yes he is an admin");
            //}
            //else
            //{
            //    Console.WriteLine("Not an admin");
            //}

            Console.WriteLine(IsAdmin() ? "Yes an admin" : "No not an admin");  
        }
        public static bool IsAdmin() {
            return false;
        }
    }
}
