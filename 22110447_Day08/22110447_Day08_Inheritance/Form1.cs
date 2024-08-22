using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day08_Inheritance {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Boss boss;
        CommissionWorker commissionWorker;
        PieceWorker pieceWorker;
        HourlyWorker hourlyWorker;

        

        private void Form1_Load(object sender, EventArgs e) {
            lblCoefficientsSalary.Visible = false;
            txtCoefficientsSalary.Visible = false;

            lblBaseSalary.Visible = false;
            txtBaseSalary.Visible = false;

            lblCommission.Visible = false;
            txtCommission.Visible = false;

            lblBonus.Visible = false;
            txtBonus.Visible = false;

        }

        private void SaveData() {
            try {
                int idx = cbxRoleInput.SelectedIndex;
                string role = cbxRoleInput.Items[idx].ToString().Trim();

                decimal receivedSalary = Convert.ToDecimal(Convert.ToDecimal(txtBaseSalary.Text) * Convert.ToDecimal(txtCoefficientsSalary.Text) + Convert.ToDecimal(txtBonus.Text));

                switch(role) {
                    case "Boss":
                        receivedSalary = Convert.ToDecimal(txtBaseSalary.Text) * Convert.ToDecimal(txtCoefficientsSalary.Text) + Convert.ToDecimal(txtBonus.Text);
                        break;
                    case "Commission Worker":
                        receivedSalary = Convert.ToDecimal(txtBaseSalary.Text) + Convert.ToDecimal(txtCoefficientsSalary.Text) * Convert.ToDecimal(txtCommission.Text) + Convert.ToDecimal(txtBonus.Text);
                        break;
                    case "Piece Worker":
                        receivedSalary = Convert.ToDecimal(txtCoefficientsSalary.Text) * Convert.ToDecimal(txtBaseSalary.Text) +  Convert.ToDecimal(txtBonus.Text);
                        break;
                    case "Hours Worker":
                        receivedSalary = Convert.ToDecimal(txtCoefficientsSalary.Text) * Convert.ToDecimal(txtBaseSalary.Text) + Convert.ToDecimal(txtBonus.Text);
                        break;

                }
                string gentle = cbxGentle.Items[cbxGentle.SelectedIndex].ToString();
                Date BirthDate = new Date(dtpkBirthDate.Value.Day, dtpkBirthDate.Value.Month, dtpkBirthDate.Value.Year);
                Date HireDate = new Date(dtpkHireDate.Value.Day, dtpkHireDate.Value.Month, dtpkHireDate.Value.Year);

                string s = $"First Name: {txtFirstName.Text}\nLast Name: {txtLastName.Text}\nGentle: {gentle}\nBirth date: {BirthDate.ToDateString()}\nHire date: {HireDate.ToDateString()}\nEarn: {receivedSalary}";

                MessageBox.Show(s);
            } catch {
                MessageBox.Show("Error");
            }
        }

        private void cbxRoleInput_DropDownClosed(object sender, EventArgs e) {
            try {
                int idx = cbxRoleInput.SelectedIndex;
                string choice = cbxRoleInput.Items[idx].ToString().Trim();
                switch(choice) {

                    case "Boss":
                        lblCoefficientsSalary.Visible = true;
                        txtCoefficientsSalary.Visible = true;

                        lblBaseSalary.Visible = true;
                        txtBaseSalary.Visible = true;

                        lblCommission.Visible = true;
                        txtCommission.Visible = true;
                        lblCoefficientsSalary.Text = "Coefficients Salary";
                        lblBaseSalary.Text = "Base Salary";
                        lblCommission.Text = "Bonus";
                        break;

                    case "Commission Worker":
                        lblBaseSalary.Visible = true;
                        txtBaseSalary.Visible = true;
                        lblCoefficientsSalary.Visible = true;
                        txtCoefficientsSalary.Visible = true;
                        lblCommission.Visible = true;
                        txtCommission.Visible = true;
                        txtCommission.Text = "";


                        lblBaseSalary.Text = "Salary";
                        lblCoefficientsSalary.Text = "Quantity";
                        lblCommission.Text = "Commission";
                        lblBonus.Visible = true;
                        txtBonus.Visible = true;
                        break;
                    case "Piece Worker":
                        lblCoefficientsSalary.Text = "Wage";
                        lblBaseSalary.Text = " Quantity";
                        lblBonus.Visible = false;
                        txtBonus.Visible = false;
                        lblCommission.Visible = true;
                        txtCommission.Visible = true;
                        lblCommission.Text = "Bonus";
                        break;

                    case "Hourly Worker":
                        lblCoefficientsSalary.Text = "Hours Worked";
                        lblBaseSalary.Text = "Wage";
                        lblBonus.Visible = false;
                        txtBonus.Visible = false;
                        lblCommission.Visible = true;
                        txtCommission.Visible = true;
                        lblCommission.Text = "Bonus";
                        break;
                }
            } catch {

            }
        }

        private void btnSaveData_Click(object sender, EventArgs e) {
            SaveData();
        }
    }
}
