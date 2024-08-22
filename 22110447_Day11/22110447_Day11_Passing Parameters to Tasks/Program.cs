using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day11_Passing_Parameters_to_Tasks {
    internal class Program {
        static void Main(string[] args) {
            Task task1 = new Task(new Action<object>(SayHi), "Jennifer");
            task1.Start();

            Task task2 = new Task(delegate (object name) {
                Console.WriteLine("Welcome back " + name);
            }, "Ahmad");
            task2.Start();

            Task task3 = new Task(n => { Console.WriteLine("Welcome back " + n); }, "Jack");
            task3.Start();

            Console.ReadLine();
        }

        public static void SayHi(object name) {
            Console.WriteLine("Welcome back " + name);
        }
    }
}
