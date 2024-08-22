using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Models {
    internal class Book {
        public string CMTND { get; set; }
        public string HotelCode { get; set; }
        public string RoomNo { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Book() { }
        public void Input(List<Customer> customers, List<Hotel> hotels) {
            if(hotels.Count == 0) {
                Console.WriteLine("Khong co du lieu !");
                return;
            }
            Console.Write("Nhap CMTND: ");
            CMTND = Console.ReadLine();

            bool isFind = false;
            foreach(Customer customer in customers) {
                if(customer.CMTND.Equals(CMTND)) {
                    isFind = true;
                    break;
                }
            }

            if(!isFind) {
                Customer customer = new Customer();
                customer.CMTND = CMTND;
                customer.InputWithoutCMTND();
                customers.Add(customer);
            }

            Console.WriteLine("Nhap ma khach san: ");
            Hotel currentHotel = null;
            for(; ; ) {
                foreach(Hotel hotel in hotels) {
                    Console.WriteLine($"Ma KS: {hotel.HotelCode}, Ten KS: {hotel.HotelName}");
                }
                HotelCode = Console.ReadLine();
                foreach(Hotel hotel in hotels) {
                    if(hotel.HotelCode.Equals(HotelCode)) {
                        currentHotel = hotel;
                        break;
                    }
                }
                if(currentHotel != null) {
                    break;
                }
                Console.WriteLine("Vui long nhap lai: ");
            }

            Console.WriteLine("Nhap ma phong: ");
            if(currentHotel?.RoomList.Count == 0) {
                Console.WriteLine("Khach san khong con phong rong !");
                return;
            }
            for(; ; ) {
                foreach(Room room in currentHotel.RoomList) {
                    Console.WriteLine($"Ma phong: {room.RoomNo}, Ten phong: {room.RoomName}");
                }
                isFind = false;
                RoomNo = Console.ReadLine();
                foreach(Room room in currentHotel.RoomList) {
                    if(room.RoomNo.Equals(RoomNo)) {
                        isFind = true;
                        break;
                    }
                }
                if(isFind)
                    break;
                Console.WriteLine("Vui long nhap lai: ");
            }


            Console.Write("Ngay check in (dd/mm/yyyy): ");
            string dateTime = Console.ReadLine();
            CheckIn = ConvertStringToDate(dateTime);
            Console.Write("Ngay check out (dd/mm/yyyy): ");
            dateTime = Console.ReadLine();
            CheckOut = ConvertStringToDate(dateTime);
        }

        public DateTime ConvertStringToDate(string value) {
            DateTime oDate = DateTime.ParseExact(value, "dd/MM/yyyy", null);
            return oDate;
        }
    }
}
