using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day01_BillStruct {
    internal class Program {
        struct Bill {
            public int billNo;
            public int totalItems;
            public string[] itemName;
            public int[] price;
        }
        static void Main(string[] args) {
            Bill trialBill;
            double totalAmt = 0;
            Console.WriteLine("Input information for calculating the bill of items: ");
            Console.WriteLine("Input bill number :");
            trialBill.billNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number of items purchased :");
            trialBill.totalItems = int.Parse(Console.ReadLine());
            trialBill.itemName = new string[trialBill.totalItems];
            trialBill.price = new int[trialBill.totalItems];
            for(int i = 0; i < trialBill.totalItems; i++) {
                Console.WriteLine("Input item name {0}", i + 1);
                trialBill.itemName[i] = Console.ReadLine();
                Console.WriteLine("Input item price for item {0}", i + 1);
                trialBill.price[i] = int.Parse(Console.ReadLine());
                totalAmt += trialBill.price[i];
            }
            Console.WriteLine("Total number of items purchased are {0}", trialBill.totalItems);
            Console.WriteLine("Total bill amount for the items purchased is {0}", totalAmt);
        }
    }
}
