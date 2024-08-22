using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day10_ActionwithAnonymousMethodLambdaExpression {
    internal class Program {
        static void Main(string[] args) {
            string name = "Le Tan Tru";

            // Action
            Action<string> Message = ShowMessage;
            Message(name);

            // Anonymous method
            name = "John";
            Action<string> anonymousMethod = delegate (string myName) { Console.WriteLine($"Hi, how are you today, {myName}?"); };
            anonymousMethod(name);

            // Lambda expression
            name = "Sandra";
            Action<string> lambdaExpression = x => Console.WriteLine($"Hi, how are you today, {x}?");
            lambdaExpression(name);

        }

        public static void ShowMessage(string name) {
            Console.WriteLine($"Hi, how are you today, {name}?");
        }

    }
}
