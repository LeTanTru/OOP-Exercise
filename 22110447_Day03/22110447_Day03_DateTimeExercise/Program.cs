using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_DateTimeExercise {
    internal class Program {
        static void Main(string[] args) {
            DateTime myDate = DateTime.Now;
            string formattedDate = "";
            formattedDate = string.Format($"{myDate:dd-MM-yyyy HH:mm:ss}");
            Console.WriteLine(formattedDate);

            formattedDate = string.Format($"{myDate:dddd 'of month' MMMM 'year' yyyy}");
            Console.WriteLine(formattedDate);

            formattedDate = string.Format($"{myDate:'Day' dddd \n'Month' MMMM \n'Year' yyyy}");
            Console.WriteLine(formattedDate);
        }
    }
}
