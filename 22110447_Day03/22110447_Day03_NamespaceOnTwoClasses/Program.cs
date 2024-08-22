using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _22110447_Day03_Namespace02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("namespace trong C#");
            System.Console.WriteLine("Vi du minh hoa cach su dung namespace");
            Console.WriteLine("-------------------------------------");
            first_namespace.namespace_cl fc = new first_namespace.namespace_cl();
            second_namespace.namespace_cl sc = new second_namespace.namespace_cl();
            name_3.namespace_cl tc = new name_3.namespace_cl();
            fc.func();
            sc.func();
            tc.func();
        }
    }
}
