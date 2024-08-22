using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day01_PrintNumberIsOddOrEven {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a number");
            int intNum;
            intNum = Convert.ToInt32(Console.ReadLine());
            if((intNum % 2) == 0)
                Console.WriteLine("{0} is Even", intNum);
            else
                Console.WriteLine("{0} is Odd", intNum);
        }
    }
}
