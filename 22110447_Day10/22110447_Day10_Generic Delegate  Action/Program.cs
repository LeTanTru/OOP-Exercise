﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day10_Generic_Delegate__Action {
    internal class Program {
        static void Main(string[] args) {
            Action<int> actionOne = DisplayInformation;
            actionOne(16);

            Action actionTwo = DisplayInformation;
            actionTwo();

        }
        public static void DisplayInformation(int number) {
            Console.WriteLine("Daniele De Rossi number is " + number);
        }

        public static void DisplayInformation() {
            Console.WriteLine("Gabriel Batistuta");
        }

    }
}
