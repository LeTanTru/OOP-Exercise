using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolveSecondEquation {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Solve() {
            txtSolution.Text = "";
            double a = 0, b = 0, c = 0;
            try {
                a = double.Parse(txtFirst.Text);
            } catch {
                MessageBox.Show("a must be a number!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                b = double.Parse(txtSec.Text);
            } catch {
                MessageBox.Show("b must be a number!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                c = double.Parse(txtThird.Text);
            } catch {
                MessageBox.Show("c must be a number!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(a == 0) {
                if(b == 0) {
                    if(c == 0) {
                        txtSolution.Text = "Infinity solution.";
                    } else {
                        txtSolution.Text = "No solution.";
                    }
                } else {
                    txtSolution.Text = $"x = {-c / b}";
                }
            } else {
                double delta = b * b - 4 * a * c;
                if(delta < 0) {
                    txtSolution.Text = "No solution.";
                } else if(delta == 0) {
                    txtSolution.Text = $"x1 = x2 = {-b / (2 * a)}";
                } else {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    txtSolution.Text = $"x1 = {Math.Round(x1, 2)}, x2 = {Math.Round(x2, 2)}";
                }
            }

            MessageBox.Show("Solved!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFirst_TextChanged(object sender, EventArgs e) {

        }

        private void txtSec_TextChanged(object sender, EventArgs e) {

        }

        private void txtThird_TextChanged(object sender, EventArgs e) {

        }

        private void btnSolve_Click(object sender, EventArgs e) {
            Solve();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            txtFirst.Clear();
            txtSec.Clear();
            txtThird.Clear();
            txtSolution.Clear();

            MessageBox.Show("Reset!", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e) {
            DialogResult res = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes) {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void txtSolution_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (char)Keys.Enter) {
                Solve();
            }
        }
    }
}
