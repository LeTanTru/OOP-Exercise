using _22110447_Day06_HinhHoc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day05_ThuaKe_Console {
    internal class Program {
        static void Main(string[] args) {
            Point dinh1 = new Point(3, 5);
            Point dinh2 = new Point(5, 3);
            Point dinh3 = new Point(7, 9);
            Point dinh4 = new Point(9, 5);

            Point dinh5 = new Point(3, 5);
            Point dinh6 = new Point(7, 5);
            Point dinh7 = new Point(7, 3);
            Point dinh8 = new Point(3, 3);


            TamGiac tamGiac = new TamGiac(dinh1, dinh2, dinh3);
            TuGiac tuGiac = new TuGiac(dinh1, dinh2, dinh3, dinh4);
            HinhChuNhat hinhChuNhat = new HinhChuNhat(dinh5, dinh6, dinh7, dinh8);
            HinhTron hinhTron = new HinhTron(8.5);

            string msg = $"Chu vi tam giác: {Math.Round(tamGiac.ChuVi(), 2)}.\n";
            msg += $"Diện tích tam giác: {Math.Round(tamGiac.DienTich(), 2)}\n";
            msg += $"Chu vi tứ giác: {Math.Round(tuGiac.ChuVi(), 2)}\n";
            msg += $"Diện tích tứ giác: {Math.Round(tuGiac.DienTich(), 2)}\n";
            msg += $"Chu hình chữ nhật: {Math.Round(hinhChuNhat.ChuVi(), 2)}\n";
            msg += $"Diện tích hình chữ nhật: {Math.Round(hinhChuNhat.DienTich(), 2)}\n";
            msg += $"Chu vi hình tròn: {Math.Round(hinhTron.ChuVi(), 2)}\n";
            msg += $"Diện tích hình tròn: {Math.Round(hinhTron.DienTich(), 2)}\n";
            

            MessageBox.Show(msg);
        }
    }
}
