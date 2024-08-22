using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsTest {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        Random rand = new Random();

        Thread thread;
        
        private void FrmMain_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Brushes.Black);
            pen.Width = 15;
            int padding = 20;
            for(int i = 0; i < 50; i++) {
                
            }

        }
    }
}
