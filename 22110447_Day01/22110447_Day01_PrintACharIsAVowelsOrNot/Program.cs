using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day01_PrintACharIsAVowelsOrNot {
    internal class Program {
        static void Main(string[] args) {
            char strInput;
            Console.WriteLine("Enter a character");
            strInput = Convert.ToChar(Console.ReadLine());
            if(strInput == 'a' || strInput == 'e' || strInput == 'i'
            || strInput == 'o' || strInput == 'u')
                Console.WriteLine("You have entered a Vowel");
            else
                Console.WriteLine("The character entered is not a Vowel");
        }
    }
}
