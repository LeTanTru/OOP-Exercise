using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_namespace;
using first_namespace.second_namespace;

namespace _22110447_Day03_Namespace02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("namespace trong C#");
            System.Console.WriteLine("Vi du minh hoa cach su dung namespace");
            Console.WriteLine("-------------------------------------");
            abc fc = new abc();
            def sc = new def();
            fc.func();
            sc.func();
        }
    }
}
