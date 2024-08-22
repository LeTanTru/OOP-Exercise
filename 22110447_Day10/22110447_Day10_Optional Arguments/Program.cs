using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2211047_Day10_Optional_Arguments {
    internal class Program {
        static void Main(string[] args) {
            DisplayPlayerInformation(7, "Ronaldo", 60, "Portugal", "Real Madrid");
            Console.WriteLine("----------");
            DisplayPlayerInformation(10, "Messi");

        }
        public static void DisplayPlayerInformation(int no, string name, int goals = 0, string country = "", string club = "") {
            Console.WriteLine("Hi from the first method");
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
            Console.WriteLine(club);
        }

    }
}
