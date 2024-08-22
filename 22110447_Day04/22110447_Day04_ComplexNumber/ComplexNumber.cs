using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day04_ComplexNumberNumber {
    public class ComplexNumber {
        private int real;
        private int imaginary;
        public ComplexNumber() { }

        public ComplexNumber(int a, int b) {
            Real = a;
            Imaginary = b;
        }

        public int Real {
            get {
                return real;
            }
            set {
                real = value;
            }
        }
        public int Imaginary {
            get {
                return imaginary;
            }
            set {
                imaginary = value;
            }
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) {
            return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static ComplexNumber Add(ComplexNumber a, ComplexNumber b) {
            return a + b;
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b) {
            return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        public static ComplexNumber Substract(ComplexNumber a, ComplexNumber b) {
            return a - b;
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b) {
            return new ComplexNumber(a.Real * b.Real - a.Imaginary * b.Imaginary,
                a.Real * b.Imaginary + b.Real * a.Imaginary);
        }
        public static ComplexNumber Multiple(ComplexNumber a, ComplexNumber b) {
            return a * b;
        }
    }
}
