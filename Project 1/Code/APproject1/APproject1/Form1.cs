﻿using DataLayer;
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
            this.comboBoxOptionOriginal.DataSource = new string[] { "LUM", "AVG", "R", "G", "B"};
        }

        /// <summary>
        /// Reset Form to inital layout
        /// </summary>
        private void ResetForm()
        {
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
            this.labelLoading.Visible = true;
            this.Update();
            int lower = (int)this.numericUpDownLower.Value;
            int upper = (int)this.numericUpDownUpper.Value;
            this.pictureBoxStretched.Image = Histogram.Stretch(lower, upper);
            HistogramStretched = new Histogram((Bitmap)this.pictureBoxStretched.Image);
            this.isStretched = true;
            if (isStretched) this.labelLoading.Visible = false;
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
                this.labelLoading.Visible = true;
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
                    this.labelLoading.Visible = false;
                    return;
                }
                pictureBoxOriginal.Image = OriginalImage;
                Histogram = new Histogram(OriginalImage);

                this.buttonHistogramOrignal.Enabled = true;
                this.buttonStretch.Enabled = true;
                this.labelLoading.Visible = false;
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

        private void numericUpDownLower_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void numericUpDownUpper_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
