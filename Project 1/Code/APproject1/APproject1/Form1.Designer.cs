namespace APproject1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxHistogramStretched = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.pictureBoxHistogramOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHistogramOrignal = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxRGB = new System.Windows.Forms.ComboBox();
            this.pictureBoxStretched = new System.Windows.Forms.PictureBox();
            this.buttonStretch = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogramStretched)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogramOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretched)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxStretched, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxHistogramStretched, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxHistogramOriginal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxOriginal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxHistogramStretched
            // 
            this.pictureBoxHistogramStretched.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHistogramStretched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHistogramStretched.Location = new System.Drawing.Point(542, 318);
            this.pictureBoxHistogramStretched.Name = "pictureBoxHistogramStretched";
            this.pictureBoxHistogramStretched.Size = new System.Drawing.Size(533, 245);
            this.pictureBoxHistogramStretched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistogramStretched.TabIndex = 3;
            this.pictureBoxHistogramStretched.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonLoadImage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(533, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadImage.TabIndex = 0;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // pictureBoxHistogramOriginal
            // 
            this.pictureBoxHistogramOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHistogramOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHistogramOriginal.Location = new System.Drawing.Point(542, 36);
            this.pictureBoxHistogramOriginal.Name = "pictureBoxHistogramOriginal";
            this.pictureBoxHistogramOriginal.Size = new System.Drawing.Size(533, 243);
            this.pictureBoxHistogramOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistogramOriginal.TabIndex = 2;
            this.pictureBoxHistogramOriginal.TabStop = false;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(3, 36);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(533, 243);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 1;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonHistogramOrignal);
            this.flowLayoutPanel2.Controls.Add(this.comboBoxRGB);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(542, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(533, 27);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // buttonHistogramOrignal
            // 
            this.buttonHistogramOrignal.Location = new System.Drawing.Point(3, 3);
            this.buttonHistogramOrignal.Name = "buttonHistogramOrignal";
            this.buttonHistogramOrignal.Size = new System.Drawing.Size(115, 23);
            this.buttonHistogramOrignal.TabIndex = 0;
            this.buttonHistogramOrignal.Text = "Create Histogram";
            this.buttonHistogramOrignal.UseVisualStyleBackColor = true;
            this.buttonHistogramOrignal.Click += new System.EventHandler(this.buttonHistogramOrignal_Click);
            // 
            // comboBoxRGB
            // 
            this.comboBoxRGB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRGB.FormattingEnabled = true;
            this.comboBoxRGB.Location = new System.Drawing.Point(124, 3);
            this.comboBoxRGB.Name = "comboBoxRGB";
            this.comboBoxRGB.Size = new System.Drawing.Size(52, 21);
            this.comboBoxRGB.TabIndex = 1;
            // 
            // pictureBoxStretched
            // 
            this.pictureBoxStretched.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxStretched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxStretched.Location = new System.Drawing.Point(3, 318);
            this.pictureBoxStretched.Name = "pictureBoxStretched";
            this.pictureBoxStretched.Size = new System.Drawing.Size(533, 245);
            this.pictureBoxStretched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStretched.TabIndex = 5;
            this.pictureBoxStretched.TabStop = false;
            // 
            // buttonStretch
            // 
            this.buttonStretch.Location = new System.Drawing.Point(3, 3);
            this.buttonStretch.Name = "buttonStretch";
            this.buttonStretch.Size = new System.Drawing.Size(118, 23);
            this.buttonStretch.TabIndex = 6;
            this.buttonStretch.Text = "Stretch Histogram";
            this.buttonStretch.UseVisualStyleBackColor = true;
            this.buttonStretch.Click += new System.EventHandler(this.buttonStretch_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.buttonStretch);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 285);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(533, 27);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "HistogramStretcher";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogramStretched)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogramOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretched)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxHistogramStretched;
        private System.Windows.Forms.PictureBox pictureBoxHistogramOriginal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonHistogramOrignal;
        private System.Windows.Forms.ComboBox comboBoxRGB;
        private System.Windows.Forms.PictureBox pictureBoxStretched;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonStretch;
    }
}

