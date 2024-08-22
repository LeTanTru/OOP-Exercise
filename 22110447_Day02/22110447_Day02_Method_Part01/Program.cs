using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_Method_Part01 {
    internal class Program {
        static void Main(string[] args) {
            int a, b, c, d;
            int addResult = 0;
            a = 5;
            b = 3;
            addResult = a + b;
            Console.WriteLine($"{a} + {b} = {addResult}");
            DisplayMessage();
            c = 15;
            d = 10;
            addResult = c + d;
            Console.WriteLine($"{c} + {d} = {addResult}");
            DisplayMessage();
        }
        static void DisplayMessage() {
            Console.WriteLine("Process Is Done");
            Console.WriteLine("This Process Is Runned By Le Tan Tru");
            Console.WriteLine($"Finished On Time: {DateTime.Now.ToShortTimeString()}");
        }
    }
}
