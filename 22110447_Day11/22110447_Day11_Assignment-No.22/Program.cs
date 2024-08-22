
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22110447_Day11_Assignment_No._22 {
    internal class Program {
        static void Main(string[] args) {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            int threadThreeAccessCounter = 0;
            int threadFourAccessCounter = 0;

            Thread t1 = new Thread(() => {
                for(int i = 1; i <= 10; i++) {
                    stack.Push(i);
                }
            });
            t1.Start();

            Thread t2 = new Thread(() => {
                for(int i = 11; i <= 20; i++) {
                    stack.Push(i);
                }
            });
            t2.Start();

            Thread t3 = new Thread(() => {
                int stackValue = 0;
                foreach(int item in stack) {
                    stack.TryPop(out stackValue);
                    if(stackValue != 0) {
                        Console.WriteLine("Now Thread (3) is accessing " + stackValue);
                        threadThreeAccessCounter++;
                    }

                }
            });
            t3.Start();

            Thread t4 = new Thread(() => {
                int stackValue = 0;
                foreach(int item in stack) {
                    stack.TryPop(out stackValue);
                    if(stackValue != 0) {
                        Console.WriteLine("Now Thread (4) is accessing " + stackValue);
                        threadFourAccessCounter++;
                    }
                }
            });
            t4.Start();

            Thread.Sleep(10);
            Console.WriteLine("\nThread (3) accessed " + threadThreeAccessCounter);
            Console.WriteLine("Thread (4) accessed " + threadFourAccessCounter);
        }
    }
}
