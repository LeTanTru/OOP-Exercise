using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_DateTime {
    internal class Program {
        static void Main(string[] args) {
            DateTime myDate = DateTime.Now;
            string formattedDate = string.Format($"Date is {myDate:yyyy MMMM dddd HH mm ss tt}");
            Console.WriteLine(formattedDate);
        }
    }
}
