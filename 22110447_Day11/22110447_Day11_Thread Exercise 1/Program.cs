using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22110447_Day11_Thread_Exercise_1 {
    internal class Program {
        static void Main(string[] args) {
            Thread t1 = new Thread(new ThreadStart(() => Console.WriteLine("Hello from lambda expression")));
            t1.Start();
        }
    }
}
