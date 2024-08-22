using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day02_Enum04 {
    enum LuongNhanVien {
        NV1 = 100,
        NV2 = 150,
        NV3 = 200
    }
    class EnumTest {
        public void ThuongNhanVien(LuongNhanVien lnv) {
            switch(lnv) {
                case LuongNhanVien.NV1:
                    Console.WriteLine("thuong cho nhan vien 1 ...");
                    break;
                case LuongNhanVien.NV2:
                    Console.WriteLine("thuong cho nhan vien 2 ...");
                    break;
                case LuongNhanVien.NV3:
                    Console.WriteLine("thuong cho nhan vien 3 ...");
                    break;
            }
        }
    }
}
