using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipArtClassification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private WekaData wekaData = new WekaData("");
        private Boolean hasNormalImages = false;
        private Boolean hasClipartImages = false;

        private void buttonLoadImages_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                wekaData.addFiles(openFileDialog1.FileNames, "normal");
                hasNormalImages = true;
                this.textBoxLog.Text += "Normal Images added to cue." + Environment.NewLine;
            }
        }

        private void buttonLoadClipart_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                wekaData.addFiles(openFileDialog1.FileNames, "clipart");
                hasClipartImages = true;
                this.textBoxLog.Text += "Clipart Images added to cue." + Environment.NewLine;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (!hasClipartImages) this.textBoxLog.Text += "No clipart images loaded!" + Environment.NewLine;
            if (!hasNormalImages) this.textBoxLog.Text += "No normal images loaded!" + Environment.NewLine;
            if (hasClipartImages && hasNormalImages)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(folderBrowserDialog1.SelectedPath + @"\" + this.textBoxFileName.Text))
                    {
                        this.textBoxLog.Text += "File already exist" + Environment.NewLine;
                    }
                    else
                    {
                        this.textBoxLog.Text += "generating file" + Environment.NewLine;
                        GenerateWekaData(folderBrowserDialog1.SelectedPath);
                    }
                }
            }
        }

        private void GenerateWekaData(string path)
        {
            Cursor.Current = Cursors.WaitCursor;
            wekaData.PartProcessed += PartProcessed;

            wekaData.location = path + @"\" + this.textBoxFileName.Text;

            wekaData.Generate();

            Cursor.Current = Cursors.WaitCursor;
        }

        public void PartProcessed(String value)
        {
            this.textBoxLog.Text += value + Environment.NewLine;
            this.textBoxLog.Refresh();
        }
    }
}
