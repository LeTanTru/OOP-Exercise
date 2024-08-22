using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day09_PhoneShop {
    public class StorePhones : Devices {
        public string address;
        private int contactNumber;

        public StorePhones() : base() { }
        public StorePhones(string deviceName, string manufactureYear, string color, string serieNo, string producer, double price, string address, int contactNumber) 
            : base(deviceName, manufactureYear, color, serieNo, producer, price) {
            this.address = address;
            this.contactNumber = contactNumber;
        }

        public string Address {
            get => address;
            set => address = value;
        }

        public int ContactNumber {
            get => contactNumber;
            set => contactNumber = value;
        }

        public override void HoatDong() { }
    }
}
