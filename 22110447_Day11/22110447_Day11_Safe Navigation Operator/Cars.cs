using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day11_Safe_Navigation_Operator {
    class Cars {
        private string carBrand;
        private string carModel;
        private decimal carPrice;

        public string Model {
            get => carModel;
            set => carModel = value;
        }
        public string Brand {
            get => carBrand;
            set => carBrand = value;
        }
        public decimal Price {
            get => carPrice;
            set => carPrice = value;
        }

        public static void DisplayCarDetails(Cars car) {
            //if (car.Brand != null)
            //    Console.WriteLine(car.Brand);
            //if (car.Model != null)
            //    Console.WriteLine(car.Model);
            //if (car.Price != null)
            //    Console.WriteLine(car.Price);

            Console.WriteLine(car?.Brand);
            Console.WriteLine(car?.Model);
            Console.WriteLine(car?.Price);


            Console.WriteLine("--------------");
        }
    }
}
