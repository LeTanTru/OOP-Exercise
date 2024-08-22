using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day10_Lambda_Expressions {
    internal class Program {
        delegate void DisplayMessage();
        delegate int Multiply(int n);
        static void Main(string[] args) {
            //Multiply MultiplyNumber = delegate (int n) { { return n * 3; } };
            Multiply MultiplyNumber = n => n * 3;
            Console.WriteLine(MultiplyNumber(30));


            //DisplayMessage Message = delegate { Console.WriteLine("Hi from the anonymous method"); };
            DisplayMessage Message = () => Console.WriteLine("Hi from the lambda expression");
            Message();

        }
    }
}
