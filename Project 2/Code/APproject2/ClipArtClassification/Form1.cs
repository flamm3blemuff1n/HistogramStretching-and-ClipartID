﻿using Globals;
using LogicLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClipArtClassification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Bitmap originalImage;

        private WekaData wekaData = new WekaData("");
        private Boolean hasNormalImages = false;
        private Boolean hasClipartImages = false;

        private void buttonLoadImages_Click(object sender, EventArgs e)
        {
            if (this.textBoxLog.Text.Contains("Finished")) this.textBoxLog.ResetText();
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
            if (this.textBoxLog.Text.Contains("Finished")) this.textBoxLog.ResetText();
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
            if(this.textBoxLog.Text.Contains("Finished")) this.textBoxLog.ResetText();
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

        private void GenerateWekaData(string path)
        {
            Cursor.Current = Cursors.WaitCursor;
            wekaData.PartProcessed += PartProcessed;

            wekaData.Location = path + @"\" + this.textBoxFileName.Text;

            wekaData.Generate();

            Cursor.Current = Cursors.WaitCursor;
        }

        public void PartProcessed(String value)
        {
            this.textBoxLog.AppendText(value + Environment.NewLine);
            this.textBoxLog.Refresh();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog1.FileName);
                this.pictureBoxOriginal.Image = originalImage;
                this.pictureBoxOriginal.Refresh();
                this.textBoxFilePath.Text = openFileDialog1.FileName;
                IdentifyImage();
                originalImage.Dispose();
            }
        }

        private void IdentifyImage()
        {
            try
            {
                Histogram hist = new Histogram(new Bitmap(originalImage));
                Tree tree = new Tree(hist.GetData("LUM"));
                Console.WriteLine(tree.IsClipart);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
