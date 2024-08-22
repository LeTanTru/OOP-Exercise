using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_CarExercise {
    internal class Car {
        private decimal price;
        public string color;
        protected int maxSpeed;
        public Car() {
            this.price = 10000;
            this.color = "black";
            this.maxSpeed = 300;
        }

        public Car(decimal price, string color, int maxSpeed) {
            this.price = price;
            this.color = color;
            this.maxSpeed = maxSpeed;
        }

        public decimal Price {
            get {
                return price;
            }
            set {
                price = value;
            }
        }
        public string Color {
            get {
                return color;
            }
            set {
                color = value;
            }
        }
        public int MaxSpeed {
            get {
                return maxSpeed;
            }
            set {
                maxSpeed = value;
            }
        }
        public void DisplayInfo() {
            Console.WriteLine($"Price: {Price}\nColor: {Color}\nMax Speed: {MaxSpeed}");
        }
    }
}
