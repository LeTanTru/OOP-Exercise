using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_CarExercise {
    class Mercedes : Car {
        public Mercedes() {
            this.Price = 15000;
            this.Color = "blue";
            this.maxSpeed = 280;
        }

        public Mercedes(decimal price, string color, int maxSpeed) : base(price, color, maxSpeed) {

        }

    }
}
