using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_Overloading02 {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            string sinhVien = "";
            Console.WriteLine("Đây là ví dụ về Overload");
            sinhVien = Console.ReadLine();
            if(sinhVien == string.Empty)
                Vidu();
            else
                Vidu(sinhVien);
        }
        static void Vidu() {
            Console.WriteLine("Sinh Viên Đang Học OOP");
        }

        static void Vidu(string sinhVien) {
            Console.WriteLine($"Sinh viên {sinhVien}, đang học OOP");
        }
    }
}
