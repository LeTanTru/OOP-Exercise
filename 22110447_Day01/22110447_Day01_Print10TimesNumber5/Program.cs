using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day01_Print10TimesNumber5 {
    internal class Program {
        static void Main(string[] args) {
            int intRes, intCnt = 1;
            while(intCnt <= 10) {
                intRes = intCnt * 5;
                Console.WriteLine("{0}", intRes);
                intCnt = intCnt + 1;
            }
        }
    }
}
