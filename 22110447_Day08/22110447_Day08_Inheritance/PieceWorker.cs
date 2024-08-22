using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day08_Inheritance {
    public class PieceWorker : Employee {
        private int quantity;
        private decimal wagePerPrice;

        public PieceWorker() {

        }

        public PieceWorker(string firstNameValue, string lastNameValue, int birthDay, int birthMonth, int birthYear,
                int hireDay, int hireMonth, int hireYear, decimal wagePerPriceValue, int quantityValue) :
            base(firstNameValue, lastNameValue, birthDay, birthMonth, birthYear, hireDay, hireMonth, hireYear) {
            WagePerPrice = wagePerPriceValue;
            Quantity = quantityValue;
        }

        public int Quantity {
            get => quantity;
            set {
                if(value > 0)
                    quantity = value;
            }
        }

        public decimal WagePerPrice {
            get => wagePerPrice;
            set {
                if(value > 0)
                    wagePerPrice = value;
            }
        }

        public override decimal Earnings() {
            return Quantity * WagePerPrice;
        }

        public override string ToString() {
            return $"PieceWorker: {base.ToString()}";
        }
    }
}
