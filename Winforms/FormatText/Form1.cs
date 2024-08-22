using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatText {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void ResetGrbColor() {
            foreach(Control control in grbColor.Controls) {
                if(control is RadioButton) {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
            }
        }

        private void ResetGrbFontStyle() {
            foreach(Control control in grbFontStyle.Controls) {
                if(control is CheckBox) {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e) {
            lblOutput.Text = txtInput.Text;
            if(txtInput.Text.Length == 0) {
                ResetGrbColor();
                ResetGrbFontStyle();
                lblOutput.ForeColor = Color.Black;
            }
        }

        private void ShowError(RadioButton radioButton) {
            if(radioButton.Checked) {
                if(txtInput.Text.Length == 0) {
                    radioButton.Checked = false;
                    MessageBox.Show("Please Input Something !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void ShowError(CheckBox checkBox) {
            if(checkBox.Checked) {
                if(txtInput.Text.Length == 0) {
                    checkBox.Checked = false;
                    MessageBox.Show("Please Input Something !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void SetColor(RadioButton radioButton, Color color) {
            if(radioButton.Checked) {
                lblOutput.ForeColor = radioButton.ForeColor;
            }
        }

        private void radRed_CheckedChanged(object sender, EventArgs e) {
            ShowError(radRed);
            SetColor(radRed, Color.Red);
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e) {
            ShowError(radGreen);
            SetColor(radGreen, Color.Green);
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e) {
            ShowError(radBlue);
            SetColor(radBlue, Color.Blue);
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e) {
            ShowError(radBlack);
            SetColor(radBlack, Color.Black);
        }

        private void SetFontStyle(FontStyle fontStyle) {
            lblOutput.Font = new Font(lblOutput.Font.FontFamily, lblOutput.Font.Size, lblOutput.Font.Style ^ fontStyle);
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e) {
            ShowError(chkBold);
            SetFontStyle(FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e) {
            ShowError(chkItalic);
            SetFontStyle(FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e) {
            ShowError(chkUnderline);
            SetFontStyle(FontStyle.Underline);
        }

        private void btnExit_Click(object sender, EventArgs e) {
            DialogResult res = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes) {
                Close();
            }
        }
    }
}
