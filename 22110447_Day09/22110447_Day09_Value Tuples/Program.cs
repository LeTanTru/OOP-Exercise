using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day09_Value_Tuples {
    internal class Program {
        static void Main(string[] args) {
            // Install-Package "System.ValueTuple"

            int x = 0;

            (int playerNo, string playerName, int playerGoals) ronaldo = (7, "Ronaldo", 55);
            Console.WriteLine(ronaldo.playerNo);
            Console.WriteLine(ronaldo.playerName);
            Console.WriteLine(ronaldo.playerGoals);
            Console.WriteLine();

            var messi = (playerNo: 10, playerName: "Messi", playerGoals: 60);
            Console.WriteLine(messi.playerNo);
            Console.WriteLine(messi.playerName);
            Console.WriteLine(messi.playerGoals);
            Console.WriteLine();
        }
    }
}
