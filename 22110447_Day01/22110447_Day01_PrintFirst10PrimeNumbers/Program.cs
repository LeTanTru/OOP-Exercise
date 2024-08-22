using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day01_PrintFirst10PrimeNumbers {
    internal class Program {
        static void Main(string[] args) {
            int intNum = 1, intCnt, intNumHalf = 0, intI = 0;
            bool IsPrime = true;
            Console.WriteLine("The First 10 Prime Numbers are:");
            while(intI < 10) {
                intNum += 1;
                intNumHalf = (intNum / 2);
                intCnt = 2;
                while(intNumHalf >= intCnt) {
                    if((intNum % intCnt) == 0) {
                        IsPrime = false;
                        break;
                    }
                    intCnt = intCnt + 1;
                }
                if(IsPrime == true) {
                    intI++;
                    Console.WriteLine("{0}", intNum);
                } else
                    IsPrime = true;
            }
            Console.ReadLine();
        }
    }
}
