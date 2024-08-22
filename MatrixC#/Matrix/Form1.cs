using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixClassLibrary;

namespace Matrix {
    public partial class Form1 : Form {

        const int MaxN = 10;
        int m, n, k;
        TextBox[,] MatrText = null;
        double[,] Matr1 = new double[MaxN, MaxN];
        double[,] Matr2 = new double[MaxN, MaxN];
        double[,] Matr3 = new double[MaxN, MaxN];
        bool f1;
        bool f2;
        int dx = 40, dy = 20;
        Form2 form2 = null;

        public Form1() {
            InitializeComponent();
        }

        private void Clear_MatrText() {
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    MatrText[i, j].Text = "0";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            m = 0;
            n = 0;
            k = 0;
            txtInputRow.Text = "";
            f1 = f2 = false;
            lblStatusMatr1.Text = "false";
            lblStatusMatr2.Text = "false";
            int i, j;
            form2 = new Form2();
            MatrText = new TextBox[MaxN, MaxN];
            for(i = 0; i < MaxN; i++) {
                for(j = 0; j < MaxN; j++) {
                    MatrText[i, j] = new TextBox();
                    MatrText[i, j].Text = "0";
                    MatrText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);
                    MatrText[i, j].Size = new System.Drawing.Size(dx, dy);
                    MatrText[i, j].Visible = false;
                    form2.Controls.Add(MatrText[i, j]);
                }
            }
        }

        private void btnInputMatr2_Click(object sender, EventArgs e) {
            if(txtInputRow.Text == "") {
                MessageBox.Show("Input a integer !");
                return;
            }
            m = int.Parse(txtInputRow.Text);
            n = int.Parse(txtInputCol.Text);
            Clear_MatrText();
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    MatrText[i, j].Visible = true;
                }
            }
            form2.Width = 10 + m * dx + 20;
            form2.Height = 10 + n * dy + form2.btnOK.Height + 50;
            form2.btnOK.Left = 10;
            form2.btnOK.Top = 10 + n * dy + 10;
            form2.btnOK.Width = form2.Width - 30;
            if(form2.ShowDialog() == DialogResult.OK) {
                for(int i = 0; i < m; i++) {
                    for(int j = 0; j < n; j++)
                        Matr2[i, j] = Double.Parse(MatrText[i, j].Text);
                }
                f2 = true;
                lblStatusMatr2.Text = "true";
            }
        }

        private void btnResult_Click(object sender, EventArgs e) {
            if(!((f1 == true) && (f2 == true)))
                return;
  
            MatrixClassLibrary.Calculate.MultiTwoMatrices(m, n, Matr1, Matr2, ref Matr3);
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }
            }
            form2.ShowDialog();
        }

        int mm, nn;
        private void txtInputRow_Leave(object sender, EventArgs e) {
            mm = Int16.Parse(txtInputRow.Text);
            if(mm != m) {
                f1 = f2 = false;
                lblStatusMatr1.Text = "false";
                lblStatusMatr2.Text = "false";
            }
        }

        private void txtInputCol_Leave(object sender, EventArgs e) {
            nn = Int16.Parse(txtInputCol.Text);
            if(nn != n) {
                f1 = f2 = false;
                lblStatusMatr1.Text = "false";
                lblStatusMatr2.Text = "false";
            }
        }


        private void txtInputRow_TextChanged(object sender, EventArgs e) {
            for(int row = 0; row < MatrText.GetLength(0); row++) {
                for(int col = 0; col < MatrText.GetLength(1); col++) {
                    TextBox textBox = MatrText[row, col];
                    textBox.Visible = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if(!((f1 == true) && (f2 == true))) return;
            MatrixClassLibrary.Calculate.AddTwoMatrices(m, n, Matr1, Matr2, ref Matr3);
            for(int i = 0; i < m; i++)
                for(int j = 0; j < n; j++) {
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }
            form2.ShowDialog();
        }

        private void btnSubstract_Click(object sender, EventArgs e) {
            if(!((f1 == true) && (f2 == true))) return;
            MatrixClassLibrary.Calculate.SubstractTwoMatrices(m, n, Matr1, Matr2, ref Matr3);
            for(int i = 0; i < m; i++)
                for(int j = 0; j < n; j++) {
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }
            form2.ShowDialog();
        }

        private void btnMultiple_Click(object sender, EventArgs e) {
            if(!((f1 == true) && (f2 == true))) return;
            MatrixClassLibrary.Calculate.MultiTwoMatrices(m, n, Matr1, Matr2, ref Matr3);
            for(int i = 0; i < m; i++)
                for(int j = 0; j < n; j++) {
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }
            form2.ShowDialog();
        }

        private void txtInputCol_TextChanged(object sender, EventArgs e) {
            for(int row = 0; row < MatrText.GetLength(0); row++) {
                for(int col = 0; col < MatrText.GetLength(1); col++) {
                    TextBox textBox = MatrText[row, col];
                    textBox.Visible = false;
                }
            }
        }

        private void btnSaveResult_Click(object sender, EventArgs e) {
            FileStream fw = null;
            string msg;
            byte[] msgByte = null;
            fw = new FileStream(@"C:\Users\ADMIN\Documents\CODE\Languages Learning\C#\MatrixC#\Matrix\Res_Matrix.txt", FileMode.Open, FileAccess.Write);
            
            try {
                File.WriteAllText(@"C:\Users\ADMIN\Documents\CODE\Languages Learning\C#\MatrixC#\Matrix\Res_Matrix.txt", string.Empty);
            } catch {
                
            }
            msg = n.ToString() + " " + m.ToString() + "\r\n";
            msgByte = Encoding.Default.GetBytes(msg);
            fw.Write(msgByte, 0, msgByte.Length);
            msg = "";
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < m; j++) {
                    msg = msg + Matr3[j, i].ToString() + " ";
                }
                msg = msg + "\r\n";
            }
            msgByte = Encoding.Default.GetBytes(msg);
            fw.Write(msgByte, 0, msgByte.Length);
            if(fw != null) {
                fw.Close();
                MessageBox.Show("Saved !");
            }
        }

        private void btnInputMatr1_Click(object sender, EventArgs e) {
            if(txtInputRow.Text == "") {
                MessageBox.Show("Input a integer !");
                return;
            };
            m = int.Parse(txtInputRow.Text);
            n = int.Parse(txtInputCol.Text);
            Clear_MatrText();
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    MatrText[i, j].Visible = true;
                }
            }
            form2.Width = 10 + m * dx + 20;
            form2.Height = 10 + n * dy + form2.btnOK.Height + 50;
            form2.btnOK.Left = 10;
            form2.btnOK.Top = 10 + n * dy + 10;
            form2.btnOK.Width = form2.Width - 30;
            if(form2.ShowDialog() == DialogResult.OK) {
                for(int i = 0; i < m; i++) {
                    for(int j = 0; j < n; j++) {
                        if(MatrText[i, j].Text != "")
                            Matr1[i, j] = Double.Parse(MatrText[i, j].Text);
                        else
                            Matr1[i, j] = 0;
                    }
                }
                f1 = true;
                lblStatusMatr1.Text = "true";
            }
        }
    }
}
