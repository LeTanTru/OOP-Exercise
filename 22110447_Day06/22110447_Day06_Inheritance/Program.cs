using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day06_Inheritance {
    internal class Program {
        static void Main(string[] args) {
            Animal animal = new Animal();
            Dogs dogs = new Dogs();
            Birds birds = new Birds();
            birds.FeedAnimal();
        }
    }
}
