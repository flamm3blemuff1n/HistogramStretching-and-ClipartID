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
        private Histogram histogram;


        public Form1() {
            InitializeComponent();
            this.openFileDialog1.Filter = "All files (*.*)|*.*|Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";

            this.comboBoxModeOriginal.DataSource = new String[] { "RGB", "HSV"};
            this.comboBoxModeStretch.DataSource = new String[] { "RGB", "HSV" };
            this.comboBoxOptionOriginal.DataSource = new string[] { "AVG", "R", "G", "B"};
            this.comboBoxOptionStretch.DataSource = new string[] { "AVG", "R", "G", "B" };

            this.buttonHistogramOrignal.Enabled = false;

            this.buttonStretch.Enabled = false;
            this.buttonHistogramStretch.Enabled = false;
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                OriginalImage = new Bitmap(openFileDialog1.FileName);
                pictureBoxOriginal.Image = OriginalImage;
                histogram = new Histogram(OriginalImage);
                this.buttonHistogramOrignal.Enabled = true;
                this.buttonStretch.Enabled = true;
            }
        }

        private void buttonHistogramOrignal_Click(object sender, EventArgs e)
        {
            string mode = this.comboBoxOptionOriginal.SelectedItem.ToString();
            this.pictureBoxHistogramOriginal.Image = new Bitmap(1920, 1080);
            var bitmap = (Bitmap)this.pictureBoxHistogramOriginal.Image;
            using (var g = Graphics.FromImage(bitmap)) g.Clear(Color.White);

            histogram.DrawRGB(bitmap, mode);
            this.pictureBoxHistogramOriginal.Refresh();
        }

        private void buttonStretch_Click(object sender, EventArgs e)
        {
            this.pictureBoxStretched.Image = histogram.StretchRGB();
            this.buttonHistogramStretch.Enabled = true;
        }

        private void buttonHistogramStretch_Click(object sender, EventArgs e)
        {
            string mode = this.comboBoxOptionStretch.SelectedItem.ToString();
            this.pictureBoxHistogramStretched.Image = new Bitmap(1920, 1080);
            var bitmap = (Bitmap)this.pictureBoxHistogramStretched.Image;
            using (var g = Graphics.FromImage(bitmap)) g.Clear(Color.White);

            Histogram histogramStretched = new Histogram((Bitmap)this.pictureBoxStretched.Image);
            histogramStretched.DrawRGB(bitmap, mode);
            this.pictureBoxHistogramStretched.Refresh();
        }

        private void comboBoxModeOriginal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxModeOriginal.SelectedItem.ToString().Equals("RGB"))
            {
                this.comboBoxOptionOriginal.DataSource = new string[] { "AVG", "R", "G", "B" };
            }
            else if (this.comboBoxModeOriginal.SelectedItem.ToString().Equals("HSV"))
            {
                this.comboBoxOptionOriginal.DataSource = new string[] { "AVG", "H", "S", "V" };
            }
        }

        private void comboBoxModeStretch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxModeStretch.SelectedItem.ToString().Equals("RGB"))
            {
                this.comboBoxOptionStretch.DataSource = new string[] { "AVG", "R", "G", "B" };
            }
            else if (this.comboBoxModeStretch.SelectedItem.ToString().Equals("HSV"))
            {
                this.comboBoxOptionStretch.DataSource = new string[] { "AVG", "H", "S", "V" };
            }
        }
    }
}
