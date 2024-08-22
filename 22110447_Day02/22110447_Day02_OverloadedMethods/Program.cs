using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_OverloadedMethods {
    internal class Program {
        static void Main(string[] args) {
            string guestName = "";
            Console.WriteLine("Hello, Dear Guest, what is your name?");
            guestName = Console.ReadLine();
            if(guestName == string.Empty)
                WelcomeGuest();
            else
                WelcomeGuest(guestName);
        }

        static void WelcomeGuest() {
            Console.WriteLine("Ok, we hope you enjoy staying at our hotel.");
        }

        static void WelcomeGuest(string guestName) {
            Console.WriteLine($"Thank you {guestName}, we hope you enjoy staying at our hotel.");
        }

    }
}
