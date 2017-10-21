using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APproject1 {
    public partial class Form1 : Form {
        private Bitmap original;


        public Form1() {
            InitializeComponent();
            openFileDialog1.Filter = "All files (*.*)|*.* | PNG Files(*.png) | *.png | BMP Files(*.bmp) | *.bmp | JPEG Files(*.jpg)| *.jpg";
            
        }

        private void buttonLoadImage_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                // Inladen van afbeelding in beide pictureBoxes.
                original = new Bitmap(openFileDialog1.FileName);
                pictureBoxOriginal.Image = original;

            }
        }
    }
}
