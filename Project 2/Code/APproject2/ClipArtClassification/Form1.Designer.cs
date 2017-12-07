namespace ClipArtClassification
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonLoadClipart = new System.Windows.Forms.Button();
            this.buttonLoadImages = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxOutput);
            this.tabPage1.Controls.Add(this.textBoxFilePath);
            this.tabPage1.Controls.Add(this.pictureBoxOriginal);
            this.tabPage1.Controls.Add(this.buttonLoad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clipart Classefier";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxOutput.Location = new System.Drawing.Point(540, 36);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(281, 381);
            this.textBoxOutput.TabIndex = 3;
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(98, 9);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(435, 20);
            this.textBoxFilePath.TabIndex = 2;
            this.textBoxFilePath.Text = "No Image Loaded!";
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(8, 36);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(525, 382);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 1;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(8, 7);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(83, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load Image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxFileName);
            this.tabPage2.Controls.Add(this.buttonGenerate);
            this.tabPage2.Controls.Add(this.textBoxLog);
            this.tabPage2.Controls.Add(this.buttonLoadClipart);
            this.tabPage2.Controls.Add(this.buttonLoadImages);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Weka Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(514, 8);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(192, 20);
            this.textBoxFileName.TabIndex = 4;
            this.textBoxFileName.Text = "filename.arff";
            this.textBoxFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(712, 6);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(109, 23);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Generate File";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.Location = new System.Drawing.Point(8, 35);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(813, 388);
            this.textBoxLog.TabIndex = 2;
            // 
            // buttonLoadClipart
            // 
            this.buttonLoadClipart.Location = new System.Drawing.Point(123, 6);
            this.buttonLoadClipart.Name = "buttonLoadClipart";
            this.buttonLoadClipart.Size = new System.Drawing.Size(109, 23);
            this.buttonLoadClipart.TabIndex = 1;
            this.buttonLoadClipart.Text = "Load ClipArt";
            this.buttonLoadClipart.UseVisualStyleBackColor = true;
            this.buttonLoadClipart.Click += new System.EventHandler(this.buttonLoadClipart_Click);
            // 
            // buttonLoadImages
            // 
            this.buttonLoadImages.Location = new System.Drawing.Point(8, 6);
            this.buttonLoadImages.Name = "buttonLoadImages";
            this.buttonLoadImages.Size = new System.Drawing.Size(109, 23);
            this.buttonLoadImages.TabIndex = 0;
            this.buttonLoadImages.Text = "Load Images ";
            this.buttonLoadImages.UseVisualStyleBackColor = true;
            this.buttonLoadImages.Click += new System.EventHandler(this.buttonLoadImages_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.TIFF;*.PNG)|*.BMP;*.JPG;*.TIFF;*.PNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "The Image is clipart according to the following trees.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 452);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonLoadImages;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonLoadClipart;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label1;
    }
}

