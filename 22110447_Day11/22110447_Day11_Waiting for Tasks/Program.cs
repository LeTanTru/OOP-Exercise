using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22110447_Day11_Waiting_for_Tasks {
    internal class Program {
        static void Main(string[] args) {
            Task t1 = new Task(() => {
                Console.WriteLine("Task 1 started");
                Console.WriteLine("Task 1 running...\n");
                Thread.Sleep(3000);
                Console.WriteLine("Task 1 finished!");
            });
            t1.Start();
            t1.Wait();

            Task t2 = new Task(() => {
                Console.WriteLine("Task 2 started");
                Console.WriteLine("Task 2 running...\n");
                Thread.Sleep(2000);
                Console.WriteLine("Task 2 finished!");
            });
            t2.Start();
            t2.Wait();

            Task t3 = new Task(() => {
                Console.WriteLine("Task 3 started");
                Console.WriteLine("Task 3 running...\n");
                Thread.Sleep(1000);
                Console.WriteLine("Task 3 finished!");
            });
            t3.Start();

            Task.WaitAll(t3);
        }
    }
}
