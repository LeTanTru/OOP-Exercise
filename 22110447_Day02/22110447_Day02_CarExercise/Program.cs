using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_CarExercise {
    internal class Program {
        static void Main(string[] args) {
            Car car = new Car();
            car.DisplayInfo();
            Mercedes mercedes = new Mercedes();
            mercedes.DisplayInfo();
        }
    }
}
