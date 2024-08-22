using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day11_Tasks_with_Return_Value {
    internal class Program {
        static void Main(string[] args) {

            Task<int> task = new Task<int>(() => {
                int result = 0;
                for(int i = 1; i <= 4; i++) {
                    result += i;
                    Console.WriteLine(i);
                }
                return result;
            });
            task.Start();
            Console.WriteLine(task.Result);
            Console.ReadLine();
        }
    }
}
