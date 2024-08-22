using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance {
    public abstract class Employee {
        private string firstName;
        private string lastName;
        private Date birthDate;
        private Date hireDate;

        public Employee() {
            
        }

        public Employee(string firstName, string lastName, int birthDay, int birthMonth, int birthYear,
                int hireDay, int hireMonth, int hireYear
            ) { 
            FirstName = firstName;
            LastName = lastName;
            BirthDate = new Date(birthDay, birthMonth, birthYear);
            HireDate = new Date(hireDay, hireMonth, hireYear);
        }

        public string FirstName {
            get => firstName;
            set => firstName = value;
        }

        public string LastName {
            get => lastName;
            set => lastName = value;
        }

        public Date BirthDate {
            get => birthDate;
            set => birthDate = value;
        }

        public Date HireDate {
            get => hireDate;
            set => hireDate = value;
        }

        public abstract decimal Earnings();

        public override string ToString() {
            return $"{FirstName} {LastName}\nHired: {hireDate.ToDateString()}\nBirthdate: {birthDate.ToDateString()}\n";
        }
    }
}