using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance {
    public class HourlyWorker : Employee {
        private double hoursWorked;
        private decimal wage;

        public HourlyWorker() {
            
        }

        public HourlyWorker(string firstNameValue, string lastNameValue, int birthDay, int birthMonth, int birthYear,
                int hireDay, int hireMonth, int hireYear, decimal wageValue, double hoursWorkedValue) :
        base(firstNameValue, lastNameValue, birthDay, birthMonth, birthYear, hireDay, hireMonth, hireYear) {
            Wage = wageValue;
            hoursWorked = hoursWorkedValue;
        }

        public decimal Wage {
            get => wage;
            set {
                if(wage > 0)
                    wage = value;
            }
        }

        public double HoursWorked {
            get => hoursWorked;
            set {
                if(hoursWorked > 0)
                    hoursWorked = value;
            }
        }

        public override decimal Earnings() {
            if(HoursWorked <= 40)
                return Wage * Convert.ToDecimal(HoursWorked);
            else {
                decimal basePay = Wage * Convert.ToDecimal(40);
                decimal overtimePay = Wage * 1.5M * 
                        Convert.ToDecimal(HoursWorked - 40);
                return basePay + overtimePay;
            }
        }

        public override string ToString() {
            return $"HourlyWorker: {base.ToString()}";
        }
    }
}