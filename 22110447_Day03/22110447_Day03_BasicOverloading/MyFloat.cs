using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_BasicOverloading {
    public class MyFloat {
        private float value;
        public MyFloat() {
            this.value = 0;
        }
        public MyFloat(float newVal) {
            this.value = newVal;
        }
        public static MyFloat operator+(MyFloat a, MyFloat b) {
            return new MyFloat(a.value + b.value);
        }
        public static MyFloat operator-(MyFloat a, MyFloat b) {
            return new MyFloat(a.value - b.value);
        }
        public override string ToString() {
            String s = value.ToString();
            return s;
        }
    }
}
