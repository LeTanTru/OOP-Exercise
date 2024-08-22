using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectOOP.Forms {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            frmMain form = new frmMain();
            this.Hide();
            form.ShowDialog();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
