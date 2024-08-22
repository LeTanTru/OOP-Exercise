using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotels.Models;

namespace Hotels {
    internal class Program {
        static void Main(string[] args) {
            List<Customer> customers = new List<Customer>();
            List<Hotel> hotels = new List<Hotel>();
            List<Book> books = new List<Book>();
            int choose;

            do {
                ShowMenu();
                choose = int.Parse(Console.ReadLine());
                switch(choose) {
                    case 1:
                        InputHotel(hotels);
                        break;
                    case 2:
                        DisplayHotels(hotels);
                        break;
                    case 3:
                        Booking(customers, hotels, books);
                        break;
                    case 4:
                        FindBookingAvailable(hotels, books);
                        break;
                    case 5:
                        TotalIncome(hotels);
                        break;
                    case 6:
                        ListBookedHotels(hotels, books);
                        break;
                    case 7:
                        Console.WriteLine("Thoat thanh cong.");
                        break;
                    default:
                        Console.WriteLine("Nhap sai.");
                        break;
                }
            } while(choose != 7);
        }

        static void ShowMenu() {
            Console.WriteLine("1. Nhap thong tin khach san.");
            Console.WriteLine("2. Hien thi thong tin khach san.");
            Console.WriteLine("3. Dat phong.");
            Console.WriteLine("4. Tim phong con trong.");
            Console.WriteLine("5. Thong ke doanh thu khach san.");
            Console.WriteLine("6. Tim kiem thong tin khach hang.");
            Console.WriteLine("7. Thoat chuong trinh.");
            Console.Write("Lua chon cua ban: ");
        }
        static void InputHotel(List<Hotel> hotels) {
            do {
                Hotel hotel = new Hotel();
                hotel.Input();
                hotels.Add(hotel);
                Console.Write("Ban co muon them khach san khong (Y / N): ");
                string op = Console.ReadLine();
                if(op.ToUpper().Equals("N"))
                    break;
            } while(true);
        }

        static void DisplayHotels(List<Hotel> hotels) {
            if(hotels.Count == 0) {
                Console.WriteLine("Khong co du lieu !");
                return;
            }
            foreach(Hotel hotel in hotels) {
                hotel.Display();
            }
        }

        static void Booking(List<Customer> customers, List<Hotel> hotels, List<Book> books) {
            Book book = new Book();
            book.Input(customers, hotels);
            books.Add(book);
        }

        static void FindBookingAvailable(List<Hotel> hotels, List<Book> books) {
            if(hotels.Count == 0) {
                Console.WriteLine("Khong co du lieu !");
                return;
            }

            Hotel currentHotel = null;
            for(; ; ) {
                foreach(Hotel hotel in hotels) {
                    Console.WriteLine($"Ma KS: {hotel.HotelCode}, Ten KS: {hotel.HotelName}");
                }
                Console.Write("Nhap ma khach san: ");
                string HotelCode = Console.ReadLine();
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

            if(currentHotel.RoomList.Count == 0) {
                Console.WriteLine("Khong co du lieu !");
                return;
            }

            Console.Write("Ngay check in (dd/mm/yyyy): ");
            string dateTime = Console.ReadLine();
            DateTime CheckIn = DateTime.ParseExact(dateTime, "dd/MM/yyyy", null);
            Console.Write("Ngay check out (dd/mm/yyyy): ");
            dateTime = Console.ReadLine();
            DateTime CheckOut = DateTime.ParseExact(dateTime, "dd/MM/yyyy", null);

            foreach(Room room in currentHotel.RoomList) {
                List<Book> currentBooking = new List<Book>();
                foreach(Book book in books) {
                    if(book.HotelCode.Equals(currentHotel.HotelCode) && book.RoomNo.Equals(room.RoomNo)) {
                        currentBooking.Add(book);
                    }
                }
                bool isFind = false;
                foreach(Book book in currentBooking) {
                    if(DateTime.Compare(book.CheckIn, CheckOut) > 0 || DateTime.Compare(book.CheckOut, CheckIn) < 0) {
                    } else {
                        isFind = true;
                        break;
                    }
                }
                if(!isFind) {
                    Console.WriteLine($"Room No: {room.RoomNo}, Room Name: {room.RoomName}");
                }
            }
        }
        static void TotalIncome(List<Hotel> hotels) {
            if(hotels.Count == 0) {
                Console.WriteLine("Khong co du lieu !");
                return;
            }
            float income;
            foreach(Hotel hotel in hotels) {
                income = 0;
                foreach(Room room in hotel.RoomList) {
                    income += room.Price;
                }
                Console.WriteLine($"Tong thu nhap mot dem cua khach san {hotel.HotelName}: {income} ");
            }
        }

        static void ListBookedHotels(List<Hotel> hotels, List<Book> books) {
            if(hotels.Count == 0) {
                Console.WriteLine("Khong co du lieu !");
                return;
            }
            Console.Write("Nhap CMTND: ");
            string CMTND = Console.ReadLine();
            List<Hotel> booked = new List<Hotel>();
            foreach(Book book in books) {
                string HotelCode = book.HotelCode;
                foreach(Hotel hotel in hotels) {
                    if(hotel.HotelCode == HotelCode) {
                        booked.Add(hotel);
                    }
                }
            }
            if(booked.Count == 0) {
                Console.WriteLine("Khong co du lieu !");
            } else {
                foreach(Hotel hotel in booked) {
                    hotel.Display();
                }
            }
        }
    }
}
