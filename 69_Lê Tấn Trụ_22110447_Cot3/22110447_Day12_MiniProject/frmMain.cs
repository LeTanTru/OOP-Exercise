using _22110447_Day12_Mini_Project;
using _22110447_Day12_MiniProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day12_MiniProject {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void calculateSalaryToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void CenterPanel(Form childForm) {
            // Calculate center position
            int formWidth = new frmMain().Width;
            int formHeight = new frmMain().Height;

            int panelWidth = childForm.Width; // Assuming you have a panel named panel1
            int panelHeight = childForm.Height; // Assuming you have a panel named panel1

            int x = (formWidth - panelWidth) / 2;
            int y = (formHeight - panelHeight) / 2;
            // Set panel position
            panelDesktopPane.Location = new System.Drawing.Point(x, y + 3);
        }

        private void OpenChildForm(Form childForm) {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e) {
            CenterPanel(new Form1());
            OpenChildForm(new Form1());
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void firstShopToolStripMenuItem_Click(object sender, EventArgs e) {
            CenterPanel(new frmPhoneShop());
            OpenChildForm(new frmPhoneShop());
        }

        private void secondShopToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void staffSalaryToolStripMenuItem_Click(object sender, EventArgs e) {
            CenterPanel(new frmLuongNhanVien());
            OpenChildForm(new frmLuongNhanVien());
        }

        private void tínhLươngBánHàngToolStripMenuItem_Click(object sender, EventArgs e) {
            CenterPanel(new frmBanDienThoai());
            OpenChildForm(new frmBanDienThoai());
        }

        private void getProfitToolStripMenuItem_Click(object sender, EventArgs e) {
            CenterPanel(new frmTinhLoiNhuan());
            OpenChildForm(new frmTinhLoiNhuan());
        }
    }
}
