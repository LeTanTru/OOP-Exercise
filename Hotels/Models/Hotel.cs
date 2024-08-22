using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Models {
    internal class Hotel {
        public string HotelCode { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public List<Room> RoomList { get; set; }
        public Hotel() {
            RoomList = new List<Room>();
        }

        public void Input() {
            Console.Write("Nhap ma khach san: ");
            HotelCode = Console.ReadLine();
            Console.Write("Nhap ten khach san: ");
            HotelName = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            Address = Console.ReadLine();
            Console.Write("Nhap loai(VIP/Binh Dan): ");
            Type = Console.ReadLine();

            for(; ; ) {
                Room room = new Room();
                room.Input();
                RoomList.Add(room);
                Console.Write("Ban co muon nhap them phong khong (Y / N): ");
                string ch;
                ch = Console.ReadLine();
                if(ch.ToUpper().Equals("N"))
                    break;
            }
        }

        public void Display() {
            Console.WriteLine($"Ma khach san: {HotelCode}, Ten khach san: {HotelName}, Dia chi: {Address}, Loai: {Type}");
            foreach(Room room in RoomList) {
                room.Display();
            }
        }

    }
}
