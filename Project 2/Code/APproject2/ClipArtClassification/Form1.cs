﻿using DataLayer;
using Globals;
using LogicLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClipArtClassification
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;

        private WekaData wekaData = new WekaData("");
        private Boolean hasNormalImages = false;
        private Boolean hasClipartImages = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadImages_Click(object sender, EventArgs e)
        {
            if (this.textBoxLog.Text.Contains("Finished")) ResetWeka();
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                wekaData.AddFiles(openFileDialog1.FileNames, ImageType.Normal);
                hasNormalImages = true;
                this.textBoxLog.AppendText(openFileDialog1.FileNames.Length + " normal image(s) added to cue. Total: " + wekaData.Files[ImageType.Normal].Count + Environment.NewLine);
            }
        }

        private void buttonLoadClipart_Click(object sender, EventArgs e)
        {
            if (this.textBoxLog.Text.Contains("Finished")) ResetWeka();
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                wekaData.AddFiles(openFileDialog1.FileNames, ImageType.Clipart);
                hasClipartImages = true;

                this.textBoxLog.AppendText(openFileDialog1.FileNames.Length + " clipart image(s) added to cue. Total: " + wekaData.Files[ImageType.Clipart].Count + Environment.NewLine);
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if(this.textBoxLog.Text.Contains("Finished")) ResetWeka();
            if (!hasClipartImages) this.textBoxLog.Text += "No clipart images loaded!" + Environment.NewLine;
            if (!hasNormalImages) this.textBoxLog.Text += "No normal images loaded!" + Environment.NewLine;
            if (hasClipartImages && hasNormalImages)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(folderBrowserDialog1.SelectedPath + @"\" + this.textBoxFileName.Text))
                    {
                        this.textBoxLog.AppendText("File already exist" + Environment.NewLine);
                    }
                    else
                    {
                        this.textBoxLog.AppendText("Generating file..." + Environment.NewLine);
                        GenerateWekaData(folderBrowserDialog1.SelectedPath);
                    }
                }
            }
        }

        /// <summary>
        /// Reset the files used for wekaData
        /// </summary>
        private void ResetWeka()
        {
            this.textBoxLog.ResetText();
            wekaData.ResetFiles();
        }

        /// <summary>
        /// Generate data to use in Weka
        /// </summary>
        /// <param name="path">Path where to store the weka data file</param>
        private void GenerateWekaData(string path)
        {
            Cursor.Current = Cursors.WaitCursor;
            wekaData.PartProcessed += PartProcessed;

            wekaData.Location = path + @"\" + this.textBoxFileName.Text;

            wekaData.Generate();

            Cursor.Current = Cursors.WaitCursor;
        }

        /// <summary>
        /// update data on the form
        /// </summary>
        /// <param name="value">show what changed</param>
        public void PartProcessed(String value)
        {
            this.textBoxLog.AppendText(value + Environment.NewLine);
            this.textBoxLog.Refresh();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBoxOutput.ResetText();
                this.textBoxOutput.Refresh();
                this.textBoxFilePath.ResetText();
                this.textBoxFilePath.Refresh();

                ImageManager image = new ImageManager(openFileDialog1.FileName);

                originalImage = new Bitmap(image.CurrentImagePath);
                this.pictureBoxOriginal.Image = originalImage;
                this.pictureBoxOriginal.Refresh();
                this.textBoxFilePath.Text = image.ImageName;
                this.textBoxFilePath.Refresh();
                Cursor.Current = Cursors.WaitCursor;
                Console.WriteLine(openFileDialog1.FileName);
                IdentifyImage();
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Identify a loaded image
        /// </summary>
        private void IdentifyImage()
        {
            try
            {
                Histogram hist = new Histogram(originalImage);
                Tree tree = new Tree(hist.GetData("LUM"));
                this.textBoxOutput.Text += "J48 tree using small data: " + tree.IsClipart[0] + Environment.NewLine;
                this.textBoxOutput.Text += "J48 tree using big data: " + tree.IsClipart[1] + Environment.NewLine;
                this.textBoxOutput.Text += "Rep tree using big data: " + tree.IsClipart[2] + Environment.NewLine;
                this.textBoxOutput.Refresh();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
