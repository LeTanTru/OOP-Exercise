using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_Constructors {
    internal class Program {
        static void Main(string[] args) {
            Person perOne = new Person();
            DateTime date = new DateTime();
            perOne.FirstName = "Admad";
            perOne.LastName = "Mohey";
            perOne.Country = "Egypt";
            
            Person perTwo = new Person();
            perTwo.FirstName = "Tim";
            perTwo.LastName = "David";
            perTwo.Country = "Australia";

            Person perThree = new Person();
            perThree.FirstName = "Daniel";
            Console.WriteLine(perOne.FirstName);
            Console.WriteLine(perTwo.FirstName);
            Console.WriteLine(perThree.FirstName);
        }
    }
}
