using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber {
   public class Complex {
        private int real;
        private int imaginary;
        public Complex() { }

        public Complex(int a, int b) {
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

        public static Complex operator +(Complex a, Complex b) {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static Complex Add(Complex a, Complex b) {
            return a + b;
        }
        public static Complex operator-(Complex a, Complex b) { 
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        public static Complex Substract(Complex a, Complex b) {
            return a - b;
        }
        public static Complex operator *(Complex a, Complex b) {
            return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary,
                a.Real * b.Imaginary + b.Real * a.Imaginary);
        }
        public static Complex Multiple(Complex a, Complex b) {
            return a * b;
        }
    }
}
