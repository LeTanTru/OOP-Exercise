using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day01_DateTimeExercise {
    class Program {
        static void Main(string[] args) {
            DateTime myDate = DateTime.Now;
            string formattedDate = "";
            formattedDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}", myDate);
            Console.WriteLine(formattedDate);

            formattedDate = string.Format("{0:dddd 'of month' MMMM 'year' yyyy}", myDate);
            Console.WriteLine(formattedDate);

            formattedDate = string.Format("{0:'Day' dddd \n'Month' MMMM \n'Year' yyyy}", myDate);
            Console.WriteLine(formattedDate);
        }
    }
}
