using LogicLayer;
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

            this.comboBoxModeOriginal.DataSource = new String[] { "RGB", "CMYK"};
            this.comboBoxModeStretch.DataSource = new String[] { "RGB", "CMYK" };
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
            string color = this.comboBoxOptionOriginal.SelectedItem.ToString();
            string colorMode = this.comboBoxModeOriginal.SelectedItem.ToString();
            this.pictureBoxHistogramOriginal.Image = new Bitmap(1920, 1080);
            var bitmap = (Bitmap)this.pictureBoxHistogramOriginal.Image;
            using (var g = Graphics.FromImage(bitmap)) g.Clear(Color.White);

            histogram.DrawRGB(bitmap, colorMode, color);
            this.pictureBoxHistogramOriginal.Refresh();
        }

        private void buttonStretch_Click(object sender, EventArgs e)
        {
            this.pictureBoxStretched.Image = histogram.Stretch();
            this.buttonHistogramStretch.Enabled = true;
        }

        private void buttonHistogramStretch_Click(object sender, EventArgs e)
        {
            string color = this.comboBoxOptionStretch.SelectedItem.ToString();
            string colorMode = this.comboBoxModeStretch.SelectedItem.ToString();
            this.pictureBoxHistogramStretched.Image = new Bitmap(1920, 1080);
            var bitmap = (Bitmap)this.pictureBoxHistogramStretched.Image;
            using (var g = Graphics.FromImage(bitmap)) g.Clear(Color.White);

            Histogram histogramStretched = new Histogram((Bitmap)this.pictureBoxStretched.Image);
            histogramStretched.DrawRGB(bitmap, colorMode, color);
            this.pictureBoxHistogramStretched.Refresh();
        }

        private void comboBoxModeOriginal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxModeOriginal.SelectedItem.ToString().Equals("RGB"))
            {
                this.comboBoxOptionOriginal.DataSource = new string[] { "AVG", "R", "G", "B" };
            }
            else if (this.comboBoxModeOriginal.SelectedItem.ToString().Equals("CMYK"))
            {
                this.comboBoxOptionOriginal.DataSource = new string[] { "AVG", "C", "M", "Y", "K" };
            }
        }

        private void comboBoxModeStretch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxModeStretch.SelectedItem.ToString().Equals("RGB"))
            {
                this.comboBoxOptionStretch.DataSource = new string[] { "AVG", "R", "G", "B" };
            }
            else if (this.comboBoxModeStretch.SelectedItem.ToString().Equals("CMYK"))
            {
                this.comboBoxOptionStretch.DataSource = new string[] { "AVG", "C", "M", "Y", "K" };
            }
        }
    }
}
