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
        private Bitmap OriginalImage;


        public Form1() {
            InitializeComponent();
            this.openFileDialog1.Filter = "All files (*.*)|*.*|Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            this.comboBoxRGB.DataSource = new string[] { "AVG", "R", "G", "B"};
            this.buttonHistogramOrignal.Enabled = false;
        }

        private void buttonLoadImage_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                // Inladen van afbeelding in beide pictureBoxes.
                OriginalImage = new Bitmap(openFileDialog1.FileName);
                pictureBoxOriginal.Image = OriginalImage;
                this.buttonHistogramOrignal.Enabled = true;
            }
        }

        private void buttonHistogramOrignal_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(OriginalImage);

            string mode = this.comboBoxRGB.SelectedItem.ToString();
            histogram.CalculateRGB(mode);

            this.pictureBoxHistogramOriginal.Image = new Bitmap(1600, 1000);
            var bitmap = (Bitmap)this.pictureBoxHistogramOriginal.Image;
            using (var g = Graphics.FromImage(bitmap)) g.Clear(Color.White);
            histogram.Draw(bitmap);
            this.pictureBoxHistogramOriginal.Refresh();
        }

        private void buttonStretch_Click(object sender, EventArgs e)
        {

        }
    }
}
