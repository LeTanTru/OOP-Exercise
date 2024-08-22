using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day09_Value_Tuples_Exercise {
    internal class Program {
        static void Main(string[] args) {
            var listOfPlayers = new List<(int playerNo, string playerName, int playerGoal)>();
            listOfPlayers.Add((7, "Ronaldo", 55));
            listOfPlayers.Add((10, "Rooney", 45));
            listOfPlayers.Add((20, "Neymar", 47));
            listOfPlayers.Add((10, "Messi", 55));

            foreach(var player in listOfPlayers) {
                Console.WriteLine($"{player.playerNo} {player.playerName} {player.playerGoal}");
                Console.WriteLine("-----------------------------");
            }
            listOfPlayers.Sort();
            Console.WriteLine("After the sorting: ");
            foreach(var player in listOfPlayers) {
                Console.WriteLine($"{player.playerNo} {player.playerName} {player.playerGoal}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
