using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day09_PhoneShop {
    public abstract class Devices : IGSM {
        private string deviceName;
        private string manufactureYear;
        private string color;
        private string serieNo;
        private string producer;
        private double price;
        public Devices() { }

        protected Devices(string deviceName, string manufactureYear, string color, string serieNo, string producer, double price) {
            this.deviceName = deviceName;
            this.manufactureYear = manufactureYear;
            this.color = color;
            this.serieNo = serieNo;
            this.producer = producer;
            this.price = price;
        }

        public string DeviceName {
            get => deviceName;
            set => deviceName = value;
        }

        public string ManufactureYear {
            get => manufactureYear;
            set => manufactureYear = value;
        }

        public string Color {
            get => color;
            set => color = value;
        }

        public string SerieNo {
            get => serieNo; 
            set => serieNo = value;
        }

        public string Producer {
            get => producer;
            set => producer = value;
        }

        public double Price {
            get => price;
            set => price = value;
        }

        public abstract void HoatDong();
        public virtual void UsingGSM() {

        }
    }
}
