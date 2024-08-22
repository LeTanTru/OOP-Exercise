using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance {
    public class CommissionWorker : Employee {
        private decimal commission;
        private int quantity;
        private decimal salary;

        public CommissionWorker() {

        }

        public CommissionWorker(string firstNameValue, string lastNameValue, int birthDay, int birthMonth, int birthYear,
                int hireDay, int hireMonth, int hireYear, decimal salaryValue, decimal commissionValue, int quantityValue)
            : base(firstNameValue, lastNameValue, birthDay, birthMonth, birthYear, hireDay, hireMonth, hireYear) {
            WeeklySalary = salaryValue;
            Commission = commissionValue;
            Quantity = quantityValue;
        }

        public decimal Commission {
            get => commission;
            set => commission = value;
        }

        public int Quantity {
            get => quantity;
            set => quantity = value;
        }

        public decimal WeeklySalary {
            get => salary;
            set => salary = value;
        }

        public override decimal Earnings() {
            return WeeklySalary + Commission * Quantity;
        }

        public override string ToString() {
            return $"CommissionWorker: {base.ToString()}";
        }
    }
}