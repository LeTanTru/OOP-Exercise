using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace04 {
    namespace A {
        class Class01 {
            public static void Show1() {
                Console.WriteLine("Trong Class 01");
            }
        }
    }
    namespace B {
        class Program {
            static void Main(string[] args) {
                A.Class01.Show1();
                A.Class02.Show2();
            }
        }
    }
}
