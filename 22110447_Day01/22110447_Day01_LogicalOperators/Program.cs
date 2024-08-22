using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators {
    class Program {
        static void Main(string[] args) {
            bool WentForSwim = true;
            bool TookAShower = true;

            if(!WentForSwim || !TookAShower) {
                Console.WriteLine("Pal you are so wet");
            } else {
                Console.WriteLine("You are not wet");
            }

        }
    }
}
