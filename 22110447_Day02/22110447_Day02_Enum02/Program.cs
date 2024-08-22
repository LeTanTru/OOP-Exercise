using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_Enum02 {
    internal class Program {
        enum NhietDoNuoc {
            DoDong = 0,
            DoNguoi = 30,
            DoAm = 40,
            DoNong = 70,
            DoSoi = 100
        }
        static void Main(string[] args) {
            Console.WriteLine($"Nhiet do dong: {(int)NhietDoNuoc.DoDong}");
            Console.WriteLine($"Nhiet do nguoi: {(int)NhietDoNuoc.DoNguoi}");
            Console.WriteLine($"Nhiet do am: {(int)NhietDoNuoc.DoAm}");
            Console.WriteLine($"Nhiet do nong: {(int)NhietDoNuoc.DoNong}");
            Console.WriteLine($"Nhiet do soi: {(int)NhietDoNuoc.DoSoi}");
        }
    }
}
