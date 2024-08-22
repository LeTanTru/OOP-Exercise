using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_Matrix {
    internal class InputMatrix {
        public static void InputMatrixes(string tenmatran, ref matran mt) {
            //Console.Write("nhap vao dong ma tran a:\t");
            //int dong = int.Parse(Console.ReadLine());
            //Console.Write("nhap so cot cua ma tran a:\t");
            //int cot = int.Parse(Console.ReadLine());
            //a = new matran(dong, cot);
            //a.nhap("a");
            //a.xuat();
            //Console.Write("\n\nnhap vao dong ma tran b:\t");
            //dong = int.Parse(Console.ReadLine());
            //Console.Write("nhap so cot cua ma tran b:\t");
            //cot = int.Parse(Console.ReadLine());
            //b = new matran(dong, cot);
            //b.nhap("b");
            //b.xuat();
            Console.Write($"nhap vao dong ma tran {tenmatran}:\t");
            int dong = int.Parse(Console.ReadLine());
            Console.Write($"nhap so cot cua ma tran {tenmatran}:\t");
            int cot = int.Parse(Console.ReadLine());
            mt = new matran(dong, cot);
            mt.nhap(tenmatran);
            mt.xuat();
        }
    }
}
