using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_Classes {
    internal class Program {
        static void Main(string[] args) {
            Person perOne = new Person();
            perOne.firstName = "Admad";
            perOne.LastName = "Mohey";
            perOne.Country = "Egypt";
            Person personTwo = new Person();
            personTwo.FirstName = "Tim";
            personTwo.LastName = "David";
            personTwo.Country = "Australia";
            Console.WriteLine(perOne.FirstName);
            Console.WriteLine(personTwo.LastName);
        }
    }
}
