using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day01_EvenOrOldExercise {
    internal class Program {
        static void Main(string[] args) {
            int x = int.Parse(Console.ReadLine());
            if(x % 2 == 0)
                Console.WriteLine($"{x} is an even number.");
            else
                Console.WriteLine($"{x} is an odd number.");
        }
    }
}
