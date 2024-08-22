using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_CastingAndTypeConversion {
    internal class Program {
        static void Main(string[] args) {
            int serialNo = 100;
            string accountNo = "";
            float anyNo = 3.9f;

            accountNo = serialNo.ToString();
            Console.WriteLine(accountNo);
            serialNo = (int)anyNo;
            Console.WriteLine(serialNo);
        }
    }
}
