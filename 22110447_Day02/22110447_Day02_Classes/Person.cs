using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_Classes {
    class Person {
        public string firstName;
        private string lastName;
        DateTime birthDate;
        private string country;
        public Person() { }
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate {
            get; set;
        }
        public string Country { get; set; }
    }
}
