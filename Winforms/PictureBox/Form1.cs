using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox {
    public partial class Form1 : Form {
        private SoundPlayer music;
        public Form1() {
            InitializeComponent();
            music = new SoundPlayer("SUIII.wav");
            picSiu.Visible = false;
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e) {
            if(chkMusic.Checked) {
                music.Play();
                picNormal.Visible = false;
                picSiu.Visible = true;
            } else {
                music.Stop();
                picNormal.Visible = true;
                picSiu.Visible = false;
            }
        }
    }
}
