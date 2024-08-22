using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22110447_Day11_Thread_Exercise_2 {
    internal class Program {
        static void Main(string[] args) {
            Thread t1 = new Thread(new ThreadStart(delegate () {
                for(int i = 0; i < 10; i++) {
                    Console.WriteLine("Hello from the anonymous method assigned to the t1 thread");
                }
            }));
            t1.Start();
        }
    }
}
