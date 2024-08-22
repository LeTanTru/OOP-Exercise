using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day08_Inheritance {
    public class Date {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year) {

            if(month > 0 && month <= 12) {
                this.month = month;
            } else {
                this.month = 1;
                Console.WriteLine($"Thang {month} khong hop le. Tam thoi dua ve 1.");
            }
            this.year = year;
            this.day = CheckDay(day);
        }

        private int CheckDay(int day) {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if(day > 0 && day <= daysPerMonth[this.month]) {
                return day;
            }
            if(this.month == 2 && day == 29 && (this.year % 400 == 0
                || (year % 4 == 0 && year % 100 != 0))) {
                return day;
            }
            Console.WriteLine($"Ngay {this.day} khong hop le. Tam thoi dua ve 1.");
            return 1;
        }

        public string ToDateString() {
            return $"{month}/{day}/{year}";
        }
    }
}
