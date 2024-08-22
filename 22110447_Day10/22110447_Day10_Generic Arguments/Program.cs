using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day10_Generic_Arguments {
    internal class Program {
        static void Main(string[] args) {
            DisplayInfo("John");
            DisplayInfo(2);
            DisplayInfo(2.5);
            DisplayInfo(DateTime.Now);

            var playerInfo = (7, "Ronaldo", 55);
            DisplayInfo(playerInfo);

        }

        public static void DisplayInfo<T>(T info) {
            Console.WriteLine(info);
        }
    }
}
