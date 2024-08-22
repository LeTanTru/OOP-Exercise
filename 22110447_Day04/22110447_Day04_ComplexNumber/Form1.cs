using _22110447_Day04_ComplexNumberNumber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day04_ComplexNumber {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        ComplexNumber x = new ComplexNumber(),
            y = new ComplexNumber(),
            z = new ComplexNumber();

        private void Form1_Load(object sender, EventArgs e) {

        }

        private string format(ComplexNumber x) {
            string real = x.Real == 0 ? "" : (x.Real.ToString());
            string imaginary = "";
            if(x.Real == 0 && x.Imaginary == 0) {
                return "0";
            }
            if(real == "") {
                if(x.Imaginary == 1) {
                    imaginary = "i";
                } else if(x.Imaginary == -1) {
                    imaginary = "-i";
                } else if(x.Imaginary > 0) {
                    imaginary = x.Imaginary.ToString() + "i";
                } else if(x.Imaginary < 0) {
                    imaginary = "-" + Math.Abs(x.Imaginary).ToString() + "i";
                }
            } else if(x.Imaginary == 0) {
                imaginary = "";
            } else if(x.Imaginary == 1) {
                imaginary = " + i";
            } else if(x.Imaginary == -1) {
                imaginary = " - i";
            } else if(x.Imaginary < 0) {
                imaginary = " - " + Math.Abs(x.Imaginary).ToString() + "i";
            } else if(x.Imaginary > 0) {
                imaginary = " + " + x.Imaginary.ToString() + "i";
            }
            return real + imaginary;

        }

        private void btnSetNo1_Click(object sender, EventArgs e) {
            try {
                x.Real = int.Parse(txtReal.Text);
            } catch {
                 MessageBox.Show("Error");
                return;
            }
            try {
                x.Imaginary = int.Parse(txtImaginary.Text);
            } catch {
                ; MessageBox.Show("Error");
                return;
            }
            txtReal.Clear();
            txtImaginary.Clear();
            lblResult.Text = $"First Complex Number Is: {format(x)}";
        }

        private void btnSetNo2_Click(object sender, EventArgs e) {
            try {
                y.Real = int.Parse(txtReal.Text);
            } catch {
                MessageBox.Show("Error");
                return;
            }
            try {
                y.Imaginary = int.Parse(txtImaginary.Text);
            } catch {
                 MessageBox.Show("Input must be an integer !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtReal.Clear();
            txtImaginary.Clear();
            lblResult.Text = $"Second Complex Number Is: {format(y)}";
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            lblResult.Text = $"({format(x)}) + ({format(y)}) = ({format(ComplexNumber.Add(x, y))})";
        }

        private void btnSubstract_Click(object sender, EventArgs e) {
            lblResult.Text = $"({format(x)}) - ({format(y)}) = ({format(ComplexNumber.Substract(x, y))})";
        }

        private void btnMul_Click(object sender, EventArgs e) {
            lblResult.Text = $"({format(x)}) * ({format(y)}) = ({format(ComplexNumber.Multiple(x, y))})";
        }
    }
}
