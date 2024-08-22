using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day10_FuncwithAnonymousMethodLambdaExpression {
    internal class Program {
        static void Main(string[] args) {
            string name = "Le Tan Tru";

            Func<string, string> ConvertToUpperCase = UppercaseString;

            Console.WriteLine("using func....");
            Console.WriteLine(ConvertToUpperCase(name));

            Func<string, string> anonymousMethod = delegate (string _name) {
                return _name.ToUpper();
            };

            Console.WriteLine("using anonymous method...");
            Console.WriteLine(anonymousMethod(name));

            Func<string, string> lambda = _name => _name.ToString();
            Console.WriteLine("using lambda expression...");
            Console.WriteLine(lambda(name));
        }

        public static string UppercaseString(string inputString) {
            return inputString.ToUpper();
        }
    }
}
