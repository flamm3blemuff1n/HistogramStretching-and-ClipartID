using DataLayer;
using Globals.Interfaces;
using LogicLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace APproject1 {
    public partial class Form1 : Form
    {
        private IHistogram Histogram;
        private IHistogram HistogramStretched;
        private IImageManager ImageManager;

        private Boolean isStretched;

        private Bitmap OriginalImage;
        private Bitmap BitmapTemp;
        private Bitmap BitmapStretchTemp;

        public Form1() {
            InitializeComponent();

            ImageManager = new ImageManager("");

            this.comboBoxModeOriginal.DataSource = new String[] { "RGB", "CMYK"};
            this.comboBoxOptionOriginal.DataSource = new string[] { "LUM", "RGB", "R", "G", "B"};
            ResetForm();
        }

        /// <summary>
        /// Reset Form to inital layout
        /// </summary>
        private void ResetForm()
        {
            this.labelLoading.Text = "";
            this.textBoxImageName.Text = "No image loaded! Use the \"Load Image\" button first.";
            this.buttonStretch.Enabled = false;
            this.buttonHistogramOrignal.Enabled = false;
            this.pictureBoxHistogramOriginal.Image = null;
            this.pictureBoxHistogramStretched.Image = null;
            this.pictureBoxOriginal.Image = null;
            this.pictureBoxStretched.Image = null;
            this.isStretched = false;
        }

        /// <summary>
        /// Stretch Image Histogram
        /// </summary>
        private void Stretch()
        {
            this.labelLoading.Text = "Stretching Histogram from image...";
            this.Update();

            int lower = (int)this.numericUpDownLower.Value;
            int upper = (int)this.numericUpDownUpper.Value;
            this.pictureBoxStretched.Image = Histogram.Stretch(lower, upper);

            HistogramStretched = new Histogram((Bitmap)this.pictureBoxStretched.Image);

            this.isStretched = true;
            this.labelLoading.Text = "";
        }

        /// <summary>
        /// Create Histograms
        /// </summary>
        private void CreateHistogram()
        {
            if (BitmapTemp != null) BitmapTemp.Dispose();
            if (BitmapStretchTemp != null) BitmapStretchTemp.Dispose();

            string color = this.comboBoxOptionOriginal.SelectedItem.ToString();
            string colorMode = this.comboBoxModeOriginal.SelectedItem.ToString();

            this.pictureBoxHistogramOriginal.Image = new Bitmap(1920, 1080);
            BitmapTemp = (Bitmap)this.pictureBoxHistogramOriginal.Image;
            using (var g = Graphics.FromImage(BitmapTemp)) g.Clear(Color.White);

            Histogram.Draw(BitmapTemp, colorMode, color);

            this.pictureBoxHistogramOriginal.Refresh();

            if (this.isStretched)
            {
                this.pictureBoxHistogramStretched.Image = new Bitmap(1920, 1080);
                BitmapStretchTemp = (Bitmap)this.pictureBoxHistogramStretched.Image;
                using (var g = Graphics.FromImage(BitmapStretchTemp)) g.Clear(Color.White);

                HistogramStretched.Draw(BitmapStretchTemp, colorMode, color);

                this.pictureBoxHistogramStretched.Refresh();
            }
        }

        /// <summary>
        /// Update the form when values are changed
        /// </summary>
        private void UpdateForm()
        {
            if (this.isStretched == true)
            {
                Cursor.Current = Cursors.WaitCursor;
                Stretch();
                CreateHistogram();
                Cursor.Current = Cursors.Default;
            }
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                ResetForm();
                this.labelLoading.Text = "Loading image...";
                Cursor.Current = Cursors.WaitCursor;
                this.Update();

                ImageManager.SelectImagePath(openFileDialog1.FileName);
                try
                {
                    OriginalImage = new Bitmap(ImageManager.CurrentImagePath);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Not an image" + ex);
                    this.labelLoading.Text = "";
                    return;
                }
                pictureBoxOriginal.Image = OriginalImage;
                Histogram = new Histogram(OriginalImage);

                this.textBoxImageName.Text = ImageManager.ImageName;
                this.buttonHistogramOrignal.Enabled = true;
                this.buttonStretch.Enabled = true;
                this.labelLoading.Text = "";
                Cursor.Current = Cursors.Default;
            }
        }

        private void buttonHistogramOrignal_Click(object sender, EventArgs e)
        {
            CreateHistogram();
        }

        private void buttonStretch_Click(object sender, EventArgs e)
        {
            Stretch();
        }

        private void numericUpDownLower_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numericUpDownUpper_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void comboBoxModeOriginal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxModeOriginal.SelectedItem.ToString().Equals("RGB"))
            {
                this.comboBoxOptionOriginal.DataSource = new string[] { "LUM", "RGB", "R", "G", "B" };
            }
            else if (this.comboBoxModeOriginal.SelectedItem.ToString().Equals("CMYK"))
            {
                this.comboBoxOptionOriginal.DataSource = new string[] { "CMYK", "C", "M", "Y", "K" };
            }
        }
    }
}
