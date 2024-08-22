using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_DataTypeAndVariablePart3 {
    internal class Program {
        static void Main(string[] args) {
            int x = 2;
            Console.WriteLine($"Number x is {x}");
            x = 5;
            Console.WriteLine($"Number x is {x}");
            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;
            double_num = 9.8;
            float_num = 5.5f;
            decimal_num = 100.250m;
            Console.WriteLine($"Double is {double_num} float is {float_num} + decimal is {decimal_num}");
            string firstName = "Jon";
            string lastName = "Snow";
            string house = "Stark";
            Console.WriteLine($"Hello, {firstName} {lastName} of house {house}");

            bool isWorking = true;
            Console.WriteLine(isWorking);

            int sum = 0;
            sum = 0;
            int number1, number2;
            number1 = 5;
            number2 = 100;
            sum = number2;
            Console.WriteLine(sum);
        }
    }
}
