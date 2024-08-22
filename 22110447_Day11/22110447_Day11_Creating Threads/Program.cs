using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22110447_Day11_Creating_Threads {
    internal class Program {
        static void Main(string[] args) {
            Thread t1 = new Thread(new ThreadStart(SayHiEnglish));
            t1.Name = "Thread Number 1 (English)";
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(SayHiSpanish));
            t2.Name = "Thread Number 2 (Spanish)";
            t2.Start();
        }
        public static void SayHiEnglish() {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for(int i = 0; i < 50; i++) {
                Console.WriteLine(i + " Hi...");
            }
        }

        public static void SayHiSpanish() {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for(int i = 0; i < 50; i++) {
                Console.WriteLine(i + " Hola...");
            }
        }

    }
}
