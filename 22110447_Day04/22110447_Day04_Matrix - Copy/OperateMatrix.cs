using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_Matrix {
    internal class OperateMatrix {
        public static void ShowMatrix(matran matrix) {
            Console.WriteLine("Ma tran: \n");
            matrix.xuat();
        }

        public static void AddTwoMatrixes(matran a, matran b) {
            if(a.Dong == b.Dong && a.Cot == b.Cot) {
                matran c = a + b;
                Console.WriteLine("\n\n\ntong hai ma tran la");
                c.xuat();
            } else {
                Console.WriteLine("\n\n\nhai ma tran nay khong cong duoc");
            }
        }

        public static void SubstractTwoMatrixes(matran a, matran b) {
            if(a.Dong == b.Dong && a.Cot == b.Cot) {
                matran c = a - b;
                Console.WriteLine("\n\nhieu hai ma tran la");
                c.xuat();
            } else {
                Console.WriteLine("\n\nhai ma tran nay khong tru duoc");
            }
        }

        public static void ProductTwoMatrixes(matran a, matran b) {
            if(a.Cot != b.Dong) {
                Console.WriteLine("\n\nkhong the thuc hien phep nhan hai ma tran");
            } else {
                Console.WriteLine("\n\ntich hai ma tran la:");
                matran c = a * b;
                c.xuat();
            }
        }

        public static void FindByIndex(matran a, matran b) {
        laimatrancantim:
            Console.Write("nhap vao ma tran can tim theo chi muc (a hoac b):\t");
            string mtcantim = Console.ReadLine();
            if(mtcantim == "a") {
            laidongcottim:
                Console.Write("nhap vao dong:\t");
                int dd = int.Parse(Console.ReadLine());
                Console.Write("nhap vao cot:\t");
                int cc = int.Parse(Console.ReadLine());
                if(dd > a.Dong || cc > a.Cot) {
                    Console.WriteLine("khong duoc nhap so qua lon");
                    goto laidongcottim;
                } else {
                    if(a[dd, cc] == -100) {
                        Console.WriteLine("he so nay khong ton tai");
                    } else
                        Console.WriteLine("\n\nGia tri tim duoc la:\t" +
                       a[dd, cc]);
                }
            } else if(mtcantim == "b") {
            laidongcottim:
                Console.Write("nhap vao dong:\t");
                int dd = int.Parse(Console.ReadLine());
                Console.Write("nhap vao cot:\t");
                int cc = int.Parse(Console.ReadLine());
                if(dd > b.Dong || cc > b.Cot) {
                    Console.WriteLine("khong duoc nhap so qua lon");
                    goto laidongcottim;
                } else {
                    if(b[dd, cc] == -100) {
                        Console.WriteLine("he so nay khong ton tai");
                    } else
                        Console.WriteLine("\n\nGia tri tim duoc la:\t" +
                       b[dd, cc]);
                }
            } else {
                Console.WriteLine("khong co ma tran nay");
                goto laimatrancantim;
            }
        }
    }
}
