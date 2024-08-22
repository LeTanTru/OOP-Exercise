using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_ExerciseIII {
    internal class Program {
        static void Main(string[] args) {
            var day = DateTime.Now.DayOfWeek.ToString();
            switch(day) {
                case "Saturday":
                    Console.WriteLine("Yellow");
                    break;
                case "Sunday":
                    Console.WriteLine("Green");
                    break;
                case "Monday":
                    Console.WriteLine("Blue");
                    break;

                case "Tuesday":
                    Console.WriteLine("Grey");
                    break;

                case "Wednesday":
                    Console.WriteLine("Red");
                    break;

                case "Thursday":
                    Console.WriteLine("Orange");
                    break;
                case "Friday":
                    Console.WriteLine("White");
                    break;
            }
        }
    }
}
