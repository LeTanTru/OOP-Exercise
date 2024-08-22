using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClassLibrary {
    public class Calculate {
        const int MaxN = 10;
        public static void AddTwoMatrices(int m, int n, double[,] Matr1, double[,] Matr2,
            ref double[,] Matr3
            ) {
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    Matr3[i, j] = Matr1[i, j] + Matr2[i, j];
                }
            }
        }
        public static void SubstractTwoMatrices(int m, int n, double[,] Matr1, double[,] Matr2,
            ref double[,] Matr3
            ) {
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    Matr3[i, j] = Matr1[i, j] - Matr2[i, j];
                }
            }
        }
        public static void MultiTwoMatrices(int m, int n, double[,] Matr1, double[,] Matr2,
            ref double[,] Matr3
            ) {
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    Matr3[j, i] = 0;
                    for(int k = 0; k < n; k++)
                        Matr3[j, i] = Matr3[j, i] + Matr1[k, i] * Matr2[j, k];
                }
            }
        }
    }
}
