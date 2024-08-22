using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_Enum04 {

    internal class Program {
        static void Main(string[] args) {
            int x = (int)LuongNhanVien.NV1;
            EnumTest enumTest = new EnumTest();
            LuongNhanVien cal;
            cal = LuongNhanVien.NV2;
            enumTest.ThuongNhanVien(cal);
            Console.WriteLine("Hello World\n");
            Console.WriteLine($" luong nhan vien 1 la {x}, luong nhan vien 2: {cal}");

        }
    }
}
