using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_TestTime {
    internal class Program {
        static void Main(string[] args) {
            Time1 timer = new Time1();
            Console.WriteLine($"Initial universal time is: {timer.ToUniversalString()}");
            Console.WriteLine($"Initial standard time is: {timer.ToStandardString()}");

            DateTime dateTime = DateTime.Now;
            timer.SetTime(dateTime.Hour, dateTime.Minute, dateTime.Second);
            Console.WriteLine($"Universal time after SetTime is: {timer.ToUniversalString()}");
            Console.WriteLine($"Standard time after SetTime is: {timer.ToStandardString()}");

            timer.SetTime(0, 0, 0);
            Console.WriteLine("After attempting invalid settings:");
            Console.WriteLine($"Universal time: {timer.ToUniversalString()}");
            Console.WriteLine($"Standard time: {timer.ToStandardString()}");
        }
    }
}
