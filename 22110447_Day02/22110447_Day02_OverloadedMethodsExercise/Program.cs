using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_OverloadedMethodsExercise {
    internal class Program {
        static void Main(string[] args) {
            int a, b, c, intResult;
            double x, y, z, douResult;
            intResult = 0;
            a = 1;
            b = 2;
            c = 3;

            douResult = 0;
            x = 0.50;
            y = 1.50;
            z = 2.0;
            Console.WriteLine(PerformAdd(a, b));
            Console.WriteLine(PerformAdd(a, b, c));
            Console.WriteLine(PerformAdd(x, y));
            Console.WriteLine(PerformAdd(x, y, z));
        }
        static int PerformAdd(int num1, int num2) {
            return num1 + num2;
        }
        static int PerformAdd(int num1, int num2, int num3) {
            return num1 + num2 + num3;
        }
        static double PerformAdd(double num1, double num2) {
            return num1 + num2;
        }
        static double PerformAdd(double num1, double num2, double num3) {
            return num1 + num2 + num3;
        }
    }
}
