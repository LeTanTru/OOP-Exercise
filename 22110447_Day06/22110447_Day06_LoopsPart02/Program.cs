﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_LoopsPart02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("While loop");

            int x = 8;
            while(x >= 1) {
                if(x == 3)
                    break;
                Console.WriteLine($"Game of thrones season 0{x}");
                x--;
            }

            Console.WriteLine("--------");
            Console.WriteLine("Do While Loop");

            int i = 1;
            do {
                Console.WriteLine($"This is line no. {i}");
                i++;
            } while(i <= 10);

        }
    }
}
