using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_TestTime {
    public class Time1 : Object {
        private int hour;
        private int minute;
        private int second;
        public Time1() {
            SetTime(0, 0, 0);
        }
        public void SetTime(int hour, int minute, int second) {
            this.hour = (hour >= 0 && hour < 24) ? hour : 0;
            this.minute = (minute >= 0 && minute < 60) ? minute : 0;
            this.second = (second >= 0 && second < 60) ? second : 0;
        }
        public string ToUniversalString() {
            return String.Format($"{this.hour:D2}:{this.minute:D2}:{this.second:D2}");
        }
        public string ToStandardString() {
            return String.Format($"{((this.hour == 12 || this.hour == 0) ? 12 : this.hour % 12)}:{this.minute:D2}:{this.second:D2} {((this.hour < 12) ? "AM" : "PM")}");
        }
    }
}
