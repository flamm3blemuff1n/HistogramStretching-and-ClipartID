﻿namespace APproject1 {
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
            this.pictureBoxHistogramOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHistogramOrignal = new System.Windows.Forms.Button();
            this.comboBoxOptionOriginal = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStretch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHistogramStretch = new System.Windows.Forms.Button();
            this.comboBoxOptionStretch = new System.Windows.Forms.ComboBox();
            this.comboBoxModeOriginal = new System.Windows.Forms.ComboBox();
            this.comboBoxModeStretch = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogramStretched)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogramOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
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
            this.flowLayoutPanel2.Controls.Add(this.comboBoxModeOriginal);
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
            this.buttonHistogramOrignal.Text = "Create Histogram";
            this.buttonHistogramOrignal.UseVisualStyleBackColor = true;
            this.buttonHistogramOrignal.Click += new System.EventHandler(this.buttonHistogramOrignal_Click);
            // 
            // comboBoxOptionOriginal
            // 
            this.comboBoxOptionOriginal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionOriginal.FormattingEnabled = true;
            this.comboBoxOptionOriginal.Location = new System.Drawing.Point(182, 3);
            this.comboBoxOptionOriginal.Name = "comboBoxOptionOriginal";
            this.comboBoxOptionOriginal.Size = new System.Drawing.Size(52, 21);
            this.comboBoxOptionOriginal.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.buttonStretch);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.buttonHistogramStretch);
            this.flowLayoutPanel4.Controls.Add(this.comboBoxModeStretch);
            this.flowLayoutPanel4.Controls.Add(this.comboBoxOptionStretch);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(545, 282);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(536, 27);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // buttonHistogramStretch
            // 
            this.buttonHistogramStretch.Location = new System.Drawing.Point(3, 3);
            this.buttonHistogramStretch.Name = "buttonHistogramStretch";
            this.buttonHistogramStretch.Size = new System.Drawing.Size(115, 23);
            this.buttonHistogramStretch.TabIndex = 2;
            this.buttonHistogramStretch.Text = "Create Histogram";
            this.buttonHistogramStretch.UseVisualStyleBackColor = true;
            this.buttonHistogramStretch.Click += new System.EventHandler(this.buttonHistogramStretch_Click);
            // 
            // comboBoxOptionStretch
            // 
            this.comboBoxOptionStretch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionStretch.FormattingEnabled = true;
            this.comboBoxOptionStretch.Location = new System.Drawing.Point(182, 3);
            this.comboBoxOptionStretch.Name = "comboBoxOptionStretch";
            this.comboBoxOptionStretch.Size = new System.Drawing.Size(52, 21);
            this.comboBoxOptionStretch.TabIndex = 2;
            // 
            // comboBoxModeOriginal
            // 
            this.comboBoxModeOriginal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModeOriginal.FormattingEnabled = true;
            this.comboBoxModeOriginal.Location = new System.Drawing.Point(124, 3);
            this.comboBoxModeOriginal.Name = "comboBoxModeOriginal";
            this.comboBoxModeOriginal.Size = new System.Drawing.Size(52, 21);
            this.comboBoxModeOriginal.TabIndex = 2;
            this.comboBoxModeOriginal.SelectedIndexChanged += new System.EventHandler(this.comboBoxModeOriginal_SelectedIndexChanged);
            // 
            // comboBoxModeStretch
            // 
            this.comboBoxModeStretch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModeStretch.FormattingEnabled = true;
            this.comboBoxModeStretch.Location = new System.Drawing.Point(124, 3);
            this.comboBoxModeStretch.Name = "comboBoxModeStretch";
            this.comboBoxModeStretch.Size = new System.Drawing.Size(52, 21);
            this.comboBoxModeStretch.TabIndex = 3;
            this.comboBoxModeStretch.SelectedIndexChanged += new System.EventHandler(this.comboBoxModeStretch_SelectedIndexChanged);
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
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonHistogramStretch;
        private System.Windows.Forms.ComboBox comboBoxOptionStretch;
        private System.Windows.Forms.ComboBox comboBoxModeOriginal;
        private System.Windows.Forms.ComboBox comboBoxModeStretch;
    }
}
