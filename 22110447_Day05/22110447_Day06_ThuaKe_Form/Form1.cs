using _22110447_Day06_HinhHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day06_ThuaKe_Form {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Graphics g;

        private void btnTamGiac_Click(object sender, EventArgs e) {
            ptrBDrawing.Refresh();
            Point dinhA = new Point(50, 100);
            Point dinhB = new Point(100, 200);
            Point dinhC = new Point(200, 150);
            TamGiac tamGiac = new TamGiac(dinhA, dinhB, dinhC);
            g = ptrBDrawing.CreateGraphics();

            tamGiac.Ve(g);
        }

        private void btnDoanThang_Click(object sender, EventArgs e) {
            ptrBDrawing.Refresh();
            Point dinhA = new Point(10, 10);
            Point dinhB = new Point(100, 100);

            DoanThang doanThang = new DoanThang(dinhA, dinhB);
            g = ptrBDrawing.CreateGraphics();

            doanThang.Ve(g);
        }

        private void btnTuGiac_Click(object sender, EventArgs e) {
            ptrBDrawing.Refresh();
            Point dinhA = new Point(50, 140);
            Point dinhB = new Point(50, 200);
            Point dinhC = new Point(200, 300);
            Point dinhD = new Point(300, 100);

            TuGiac tuGiac = new TuGiac(dinhA, dinhB, dinhC, dinhD);
            g = ptrBDrawing.CreateGraphics();

            tuGiac.Ve(g);
        }

        private void btnHinhVuong_Click(object sender, EventArgs e) {
            ptrBDrawing.Refresh();
            Point dinhA = new Point(50, 250);
            Point dinhB = new Point(200, 250);
            Point dinhC = new Point(200, 100);
            Point dinhD = new Point(50, 100);

            TuGiac tuGiac = new TuGiac(dinhA, dinhB, dinhC, dinhD);
            g = ptrBDrawing.CreateGraphics();

            tuGiac.Ve(g);
        }

        private void btnHinhTron_Click(object sender, EventArgs e) {
            ptrBDrawing.Refresh();
            Point dinhA = new Point(50, 250);
            Point dinhB = new Point(200, 250);
            Point dinhC = new Point(200, 100);
            Point dinhD = new Point(50, 100);

            HinhTron hinhTron = new HinhTron(100);
            g = ptrBDrawing.CreateGraphics();
            hinhTron.Ve(g);
        }
    }
}
