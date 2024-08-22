using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_StaticMethods {
    internal class Program {
        static void Main(string[] args) {
            Person person = new Person();
            person.SayHi();
            SayHi();
        }
        static void SayHi() {
            Console.WriteLine("Hi!, from the static method");
        }
    }
}
