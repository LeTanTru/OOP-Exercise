using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_Constructors {
    public class Person {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; } 
        public Person() {
            this.firstName = "Unknown";
        }
    }
}
