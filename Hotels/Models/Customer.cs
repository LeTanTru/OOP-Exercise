using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Models {
    internal class Customer {
        public string CMTND { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public Customer() { }
        public void Input() {
            Console.Write("Nhap CMTND: ");
            CMTND = Console.ReadLine();
            InputWithoutCMTND();
        }

        public void InputWithoutCMTND() {
            Console.Write("Nhap FullName: ");
            FullName = Console.ReadLine();
            Console.Write("Nhap Age: ");
            Age = Console.ReadLine();
            Console.Write("Nhap Gender: ");
            Gender = Console.ReadLine();
            Console.Write("Nhap Address: ");
            Address = Console.ReadLine();
        }

        public void Display() {
            Console.WriteLine($"CMTND: {this.CMTND}, Ten: {this.FullName}, Age: {this.Age}, Gender: {this.Gender}, Address: {this.Address}");
        }
    }
}
