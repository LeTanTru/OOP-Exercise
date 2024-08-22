using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_Matrix {
    class InputMatrix {
        public static void InputNewMatrix(string tenmatran, matran matrix, out int dong, out int cot) {
            Console.Write($"nhap vao dong ma tran {tenmatran}: ");
            dong = int.Parse(Console.ReadLine());
            Console.Write($"nhap so cot cua ma tran {tenmatran}: ");
            cot = int.Parse(Console.ReadLine());
            matrix = new matran(dong, cot);
            matrix.nhap(tenmatran);
            matrix.xuat();
        }
    }
}
