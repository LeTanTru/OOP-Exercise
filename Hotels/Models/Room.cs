using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Models {
    internal class Room {
        public string RoomName { get; set; }
        public float Price { get; set; }
        public string RoomNo { get; set; }
        public int PeopleMax { get; set; }
        public int Floor {
            get; set;
        }
        public Room() { }
        public void Input() {
            Console.Write("Nhap ma phong: ");
            RoomNo = Console.ReadLine();
            Console.Write("Nhap ten phong: ");
            RoomName = Console.ReadLine();
            Console.Write("Nhap gia: ");
            Price = float.Parse(Console.ReadLine());
            Console.Write("Nhap so nguoi toi da: ");
            PeopleMax = int.Parse(Console.ReadLine());
            Console.Write("Nhap tang: ");
            Floor = int.Parse(Console.ReadLine());
        }
        public void Display() {
            Console.WriteLine($"Ma phong: {this.RoomNo}, Ten phong: {this.RoomName}, Gia: {this.Price}, So nguoi toi da: {PeopleMax}, Tang: {Floor}");
        }
    }
}
