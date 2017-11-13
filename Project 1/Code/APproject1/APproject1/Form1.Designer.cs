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
            this.pictureBoxStretched = new System.Windows.Forms.PictureBox();
            this.pictureBoxHistogramStretched = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.labelLoading = new System.Windows.Forms.Label();
            this.pictureBoxHistogramOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHistogramOrignal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModeOriginal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOptionOriginal = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStretch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownLower = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownUpper = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogramStretched)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogramOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpper)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxStretched
            // 
            this.pictureBoxStretched.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxStretched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxStretched.Location = new System.Drawing.Point(3, 315);
            this.pictureBoxStretched.Name = "pictureBoxStretched";
            this.pictureBoxStretched.Size = new System.Drawing.Size(536, 243);
            this.pictureBoxStretched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStretched.TabIndex = 5;
            this.pictureBoxStretched.TabStop = false;
            // 
            // pictureBoxHistogramStretched
            // 
            this.pictureBoxHistogramStretched.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHistogramStretched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHistogramStretched.Location = new System.Drawing.Point(545, 315);
            this.pictureBoxHistogramStretched.Name = "pictureBoxHistogramStretched";
            this.pictureBoxHistogramStretched.Size = new System.Drawing.Size(536, 243);
            this.pictureBoxHistogramStretched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistogramStretched.TabIndex = 3;
            this.pictureBoxHistogramStretched.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonLoadImage);
            this.flowLayoutPanel1.Controls.Add(this.labelLoading);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(536, 27);
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
            // labelLoading
            // 
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLoading.Location = new System.Drawing.Point(84, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(153, 27);
            this.labelLoading.TabIndex = 1;
            this.labelLoading.Text = "Loading please wait";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLoading.Visible = false;
            // 
            // pictureBoxHistogramOriginal
            // 
            this.pictureBoxHistogramOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHistogramOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHistogramOriginal.Location = new System.Drawing.Point(545, 36);
            this.pictureBoxHistogramOriginal.Name = "pictureBoxHistogramOriginal";
            this.pictureBoxHistogramOriginal.Size = new System.Drawing.Size(536, 240);
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
            this.pictureBoxOriginal.Size = new System.Drawing.Size(536, 240);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 1;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonHistogramOrignal);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.comboBoxModeOriginal);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.comboBoxOptionOriginal);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(545, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(536, 27);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // buttonHistogramOrignal
            // 
            this.buttonHistogramOrignal.Location = new System.Drawing.Point(3, 3);
            this.buttonHistogramOrignal.Name = "buttonHistogramOrignal";
            this.buttonHistogramOrignal.Size = new System.Drawing.Size(115, 23);
            this.buttonHistogramOrignal.TabIndex = 0;
            this.buttonHistogramOrignal.Text = "Create Histogram(s)";
            this.buttonHistogramOrignal.UseVisualStyleBackColor = true;
            this.buttonHistogramOrignal.Click += new System.EventHandler(this.buttonHistogramOrignal_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "ColorModel:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxModeOriginal
            // 
            this.comboBoxModeOriginal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModeOriginal.FormattingEnabled = true;
            this.comboBoxModeOriginal.Location = new System.Drawing.Point(193, 3);
            this.comboBoxModeOriginal.Name = "comboBoxModeOriginal";
            this.comboBoxModeOriginal.Size = new System.Drawing.Size(60, 21);
            this.comboBoxModeOriginal.TabIndex = 2;
            this.comboBoxModeOriginal.SelectedIndexChanged += new System.EventHandler(this.comboBoxModeOriginal_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Component:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxOptionOriginal
            // 
            this.comboBoxOptionOriginal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionOriginal.FormattingEnabled = true;
            this.comboBoxOptionOriginal.Location = new System.Drawing.Point(329, 3);
            this.comboBoxOptionOriginal.Name = "comboBoxOptionOriginal";
            this.comboBoxOptionOriginal.Size = new System.Drawing.Size(49, 21);
            this.comboBoxOptionOriginal.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.buttonStretch);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.numericUpDownLower);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.numericUpDownUpper);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 282);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(536, 27);
            this.flowLayoutPanel3.TabIndex = 7;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lower Percentage:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownLower
            // 
            this.numericUpDownLower.Location = new System.Drawing.Point(230, 3);
            this.numericUpDownLower.Name = "numericUpDownLower";
            this.numericUpDownLower.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownLower.TabIndex = 3;
            this.numericUpDownLower.Tag = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Upper Percentage:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownUpper
            // 
            this.numericUpDownUpper.Location = new System.Drawing.Point(383, 3);
            this.numericUpDownUpper.Name = "numericUpDownUpper";
            this.numericUpDownUpper.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownUpper.TabIndex = 4;
            this.numericUpDownUpper.Tag = "";
            this.numericUpDownUpper.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(545, 282);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(536, 27);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files (*.*)|*.*|Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Form1";
            this.Text = "HistogramStretcher";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogramStretched)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogramOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpper)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxOptionOriginal;
        private System.Windows.Forms.PictureBox pictureBoxStretched;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonStretch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBoxModeOriginal;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.NumericUpDown numericUpDownLower;
        private System.Windows.Forms.NumericUpDown numericUpDownUpper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

