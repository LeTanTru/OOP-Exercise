using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the day...");
            var day = Console.ReadLine();

            Console.WriteLine("Enter the month...");
            var month = Console.ReadLine();

            Console.WriteLine("Enter the year...");
            var year = Console.ReadLine();

            DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            Console.WriteLine("\n" + date.DayOfWeek);

        }
    }
}