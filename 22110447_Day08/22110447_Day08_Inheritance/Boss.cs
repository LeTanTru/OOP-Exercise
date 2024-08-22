using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day08_Inheritance {
    public class Boss : Employee {
        private decimal salary;

        public Boss() {

        }

        public Boss(string firstNameValue, string lastNameValue, int birthDay, int birthMonth, int birthYear,
                int hireDay, int hireMonth, int hireYear, decimal salaryValue) :
            base(firstNameValue, lastNameValue, birthDay, birthMonth, birthYear, hireDay, hireMonth, hireYear) {
            WeeklySalary = salaryValue;
        }

        public decimal WeeklySalary {
            get => salary;

            set {
                if(value > 0)
                    salary = value;
            }
        }

        public override decimal Earnings() {
            return WeeklySalary;
        }

        public override string ToString() {
            return $"Boss: {base.ToString()}";
        }
    }
}
