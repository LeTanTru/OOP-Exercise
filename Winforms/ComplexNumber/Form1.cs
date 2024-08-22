using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumber {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
        }
        Complex x = new Complex(),
            y = new Complex(),
            z = new Complex();

        private void btnSetNo2_Click(object sender, EventArgs e) {
            try {
                y.Real = int.Parse(txtReal.Text);
            } catch {
                ; MessageBox.Show("Error");
                return;
            }
            try {
                y.Imaginary = int.Parse(txtImaginary.Text);
            } catch {
                ; MessageBox.Show("Input must be an integer !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtReal.Clear();
            txtImaginary.Clear();
            lblResult.Text = $"Second Complex Number Is: {y.Real} + {y.Imaginary}i";
        }

        private string format(Complex x) {
            // check mul case 
            // 21 + 12i
            // 12 + 21i
            string real = x.Real.ToString();
            string imaginary = x.Imaginary <= 0 ? (x.Imaginary.ToString()) : ("+" + x.Imaginary.ToString());
            real = (real == "0" ? "" : real);
            imaginary = (imaginary == "0" ? "" : imaginary);
            if((real == "0" && imaginary == "0") || (real == "" && imaginary == ""))
                return "0";
            return real + imaginary + "i";
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            lblResult.Text = $"({format(x)}) + ({format(y)}) = {format(x + y)}";
        }

        private void btnMul_Click(object sender, EventArgs e) {
            lblResult.Text = $"({format(x)}) * ({format(y)}) = {format(x * y)}";
        }

        private void btnSubstract_Click(object sender, EventArgs e) {
            lblResult.Text = $"({format(x)}) - ({format(y)}) = {format(x - y)}";
        }

        private void btnSetNo1_Click(object sender, EventArgs e) {
            try {
                x.Real = int.Parse(txtReal.Text);
            } catch {
;                MessageBox.Show("Error");
                return;
            }
            try {
                x.Imaginary = int.Parse(txtImaginary.Text);
            } catch {
;                MessageBox.Show("Error");
                return;
            }
            txtReal.Clear();
            txtImaginary.Clear();
            lblResult.Text = $"First Complex Number Is: {x.Real} + {x.Imaginary}i";
        }
    }
}
