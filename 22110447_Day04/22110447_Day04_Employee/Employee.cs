using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_Employee {
    public class Employee {
        private string firstName;
        private string lastName;
        private Date birthDate;
        private Date hireDate;

        public Employee(string first, string last, int birthDay, int birthMonth, int birthYear
            , int hireDay, int hireMonth, int hireYear
            ) {
            this.firstName = first;
            this.lastName = last;
            birthDate = new Date(birthDay, birthMonth, birthYear);
            hireDate = new Date(hireDay, hireMonth, hireYear);
        }

        public override string ToString() {
            return $"{lastName}, {firstName} Hired: {hireDate.ToDateString()} Birthday: {birthDate.ToDateString()}";
        }
    }
}
