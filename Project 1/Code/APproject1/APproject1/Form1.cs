using DataLayer;
using Globals.Interfaces;
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
    public partial class Form1 : Form
    {
        private IHistogram histogram;
        private IHistogram histogramStretched;
        private IImageManager imageManager;

        private Bitmap OriginalImage;
        private Boolean isStretched;

        public Form1() {
            InitializeComponent();

            imageManager = new ImageManager("");

            this.comboBoxModeOriginal.DataSource = new String[] { "RGB", "CMYK"};
            this.comboBoxOptionOriginal.DataSource = new string[] { "LUM", "AVG", "R", "G", "B"};

            this.buttonHistogramOrignal.Enabled = false;
            this.buttonStretch.Enabled = false;
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                this.labelLoading.Visible = true;
                this.buttonStretch.Enabled = false;
                this.buttonHistogramOrignal.Enabled = false;
                this.pictureBoxHistogramOriginal.Image = null;
                this.pictureBoxHistogramStretched.Image = null;
                this.pictureBoxOriginal.Image = null;
                this.pictureBoxStretched.Image = null;
                this.Update();

                imageManager.SelectImagePath(openFileDialog1.FileName);
                try
                {
                    OriginalImage = new Bitmap(imageManager.CurrentImagePath);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Not an image" + ex);
                    this.labelLoading.Visible = false;
                    return;
                }
                pictureBoxOriginal.Image = OriginalImage;
                histogram = new Histogram(OriginalImage);

                this.buttonHistogramOrignal.Enabled = true;
                this.buttonStretch.Enabled = true;
                this.labelLoading.Visible = false;
            }
        }

        private void buttonHistogramOrignal_Click(object sender, EventArgs e)
        {
            


            string color = this.comboBoxOptionOriginal.SelectedItem.ToString();
            string colorMode = this.comboBoxModeOriginal.SelectedItem.ToString();
            this.pictureBoxHistogramOriginal.Image = new Bitmap(1920, 1080);
            var bitmap = (Bitmap)this.pictureBoxHistogramOriginal.Image;
            using (var g = Graphics.FromImage(bitmap)) g.Clear(Color.White);

            histogram.Draw(bitmap, colorMode, color);

            this.pictureBoxHistogramOriginal.Refresh();
            bitmap.Dispose();

            if (this.isStretched)
            {
                this.pictureBoxHistogramStretched.Image = new Bitmap(1920, 1080);
                var bitmapStretch = (Bitmap)this.pictureBoxHistogramStretched.Image;
                using (var g = Graphics.FromImage(bitmapStretch)) g.Clear(Color.White);

                histogramStretched.Draw(bitmapStretch, colorMode, color);
                this.pictureBoxHistogramStretched.Refresh();
                bitmapStretch.Dispose();
            }
        }

        private void buttonStretch_Click(object sender, EventArgs e)
        {
            this.labelLoading.Visible = true;
            this.Update();
            int lower = (int)this.numericUpDownLower.Value;
            int upper = (int)this.numericUpDownUpper.Value;
            this.pictureBoxStretched.Image = histogram.Stretch(lower, upper);
            histogramStretched = new Histogram((Bitmap)this.pictureBoxStretched.Image);
            this.isStretched = true;
            if(isStretched) this.labelLoading.Visible = false;
        }

        private void comboBoxModeOriginal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxModeOriginal.SelectedItem.ToString().Equals("RGB"))
            {
                this.comboBoxOptionOriginal.DataSource = new string[] {"LUM", "AVG", "R", "G", "B" };
            }
            else if (this.comboBoxModeOriginal.SelectedItem.ToString().Equals("CMYK"))
            {
                this.comboBoxOptionOriginal.DataSource = new string[] { "AVG", "C", "M", "Y", "K" };
            }
        }
    }
}
