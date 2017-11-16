using Globals.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Histogram : IHistogram
    {
        private Bitmap OriginalImage;
        private Dictionary<string, int[]> ValueCollectionRGB;
        private Dictionary<string, int[]> ValueCollectionCMYK;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bitmap">Image to make histogram from and stretch</param>
        public Histogram(Bitmap bitmap)
        {
            this.OriginalImage = bitmap;
            CalculateHistogram();
        }

        /// <summary>
        /// Calculate the histogram
        /// </summary>
        private void CalculateHistogram()
        {
            InitValues();

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    Color color = this.OriginalImage.GetPixel(i, j);

                    AddRgbColor(color);
                    AddCmykColor(color);
                }
            }

            //fix small histogram with cmyk, lots of 0 values making the histogram very small;
            foreach (string mode in new string[] { "CMYK", "C", "M", "Y", "K" })
            {
                this.ValueCollectionCMYK[mode][0] = 0;
            }

            for (int i = 0; i <= 255; i++)
            {
                this.ValueCollectionRGB["RGB"][i] = this.ValueCollectionRGB["R"][i] + this.ValueCollectionRGB["G"][i] + this.ValueCollectionRGB["B"][i];
            }

            for (int i =0; i <= 1000; i++)
            {
                this.ValueCollectionCMYK["CMYK"][i] = this.ValueCollectionCMYK["C"][i] + this.ValueCollectionCMYK["M"][i] + this.ValueCollectionCMYK["Y"][i] + this.ValueCollectionCMYK["K"][i];
            }
        }

        /// <summary>
        /// Intialize all the dictionaries for the RGB and CMYK values
        /// </summary>
        private void InitValues()
        {
            this.ValueCollectionRGB = new Dictionary<string, int[]>();
            string[] modes = new string[] { "RGB", "LUM", "R", "G", "B" };

            foreach (string mode in modes)
            {
                this.ValueCollectionRGB.Add(mode, new int[256]);
            }

            this.ValueCollectionCMYK = new Dictionary<string, int[]>();
            modes = new string[] { "CMYK", "C", "M", "Y", "K" };

            foreach (string mode in modes)
            {
                this.ValueCollectionCMYK.Add(mode, new int[1001]);
            }
        }

        /// <summary>
        /// Add RGB values to dictionary
        /// </summary>
        /// <param name="color">Color value</param>
        private void AddRgbColor(Color color)
        {
            this.ValueCollectionRGB["R"][color.R]++;
            this.ValueCollectionRGB["G"][color.G]++;
            this.ValueCollectionRGB["B"][color.B]++;
            //formula http://geraldbakker.nl/psnumbers/histograms-1.html
            this.ValueCollectionRGB["LUM"][(int)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B)]++;
        }

        /// <summary>
        /// Add CMYK values to dictionary
        /// </summary>
        /// <param name="color">Color value</param>
        private void AddCmykColor(Color color)
        {
            int[] values = ConvertRgbToCmyk(color);

            this.ValueCollectionCMYK["C"][values[0]]++;
            this.ValueCollectionCMYK["M"][values[1]]++;
            this.ValueCollectionCMYK["Y"][values[2]]++;
            this.ValueCollectionCMYK["K"][values[3]]++;
        }

        /// <summary>
        /// Convert RGB to CMYK
        /// </summary>
        /// <param name="color">the color value</param>
        /// <returns>CMYK values</returns>
        private int[] ConvertRgbToCmyk(Color color)
        {
            //formulas: http://www.rapidtables.com/convert/color/rgb-to-cmyk.htm
            double red = color.R / 255.0;
            double green = color.G / 255.0;
            double blue = color.B / 255.0;
     
            if (red==0 && green==0 && blue == 0)
            {
                return new int[] { 0, 0, 0, 1 };
            }

            double k = 1 - Math.Max(red, Math.Max(green, blue));
            double c = (1 - red - k) / (1 - k);
            double m = (1 - green - k) / (1 - k);
            double y = (1 - blue - k) / (1 - k);

            int key = (int)(Math.Round(k, 3) * 1000);
            int cyan = (int)(Math.Round(c, 3) * 1000);
            int magenta = (int)(Math.Round(m, 3) * 1000);
            int yellow = (int)(Math.Round(y, 3) * 1000);
            return new int[] { cyan, magenta, yellow, key};
        }

        /// <summary>
        /// Stretch original image
        /// </summary>
        /// <param name="lowerLimit">Amount of pixels in percent to ignore for lower border</param>
        /// <param name="upperLimit">Amount of pixels in percent to ignore for upper border</param>
        /// <returns>Stretched image</returns>
        public Bitmap Stretch(int lowerLimit, int upperLimit)
        {
            Bitmap stretched = new Bitmap(OriginalImage);

            int[] red = GetMinMax(this.ValueCollectionRGB["R"], lowerLimit, upperLimit);
            int[] green = GetMinMax(this.ValueCollectionRGB["G"], lowerLimit, upperLimit);
            int[] blue = GetMinMax(this.ValueCollectionRGB["B"], lowerLimit, upperLimit);

            int min = Math.Min(red[0], Math.Min(green[0], blue[0]));
            int max = Math.Min(red[1], Math.Min(green[1], blue[1]));

            for (int i = 0; i < stretched.Width; i++)
            {
                for (int j = 0; j < stretched.Height; j++)
                {
                    Color color = stretched.GetPixel(i, j);

                    //formulas: https://homepages.inf.ed.ac.uk/rbf/HIPR2/stretch.htm
                    int r = (int)((color.R - min) * (255 / (float)(max - min)));
                    int g = (int)((color.G - min) * (255 / (float)(max - min)));
                    int b = (int)((color.B - min) * (255 / (float)(max - min)));
                    
                    if (r > 255) r = 255;
                    if (r < 0) r = 0;
                    if (g > 255) g = 255;
                    if (g < 0) g = 0;
                    if (b > 255) b = 255;
                    if (b < 0) b = 0;

                    Color colorNew = Color.FromArgb(r, g, b);
                    stretched.SetPixel(i, j, colorNew);
                }
            }

            return stretched;
        }

        /// <summary>
        /// Get minimum and maximum border value for a color component
        /// </summary>
        /// <param name="values">All values from a specific Color component</param>
        /// <param name="lower">Amount of pixels in percent to ignore for lower border</param>
        /// <param name="upper">Amount of pixels in percent to ignore for upper border</param>
        /// <returns>Lower and Upper border for a Color component</returns>
        private int[] GetMinMax(int[] values, int lower, int upper)
        {
            int pixels = OriginalImage.Width * OriginalImage.Height;
            int lowerPixelCount = (int)Math.Round(pixels * (lower/100.0), 0);
            int upperPixelCount = (int)pixels - (int)Math.Round(pixels * (upper/100.0), 0);

            int minP = GetMin(values, lowerPixelCount);
            int maxP = GetMax(values, upperPixelCount);

            return new int[] { minP, maxP };
        }

        /// <summary>
        /// Get minimum value for a border.
        /// </summary>
        /// <param name="values">All values from a specific Color component</param>
        /// <param name="lowerPixelCount">Amount of pixels to ignore</param>
        /// <returns>Minumum border</returns>
        private int GetMin(int[] values, int lowerPixelCount)
        {
            int count = 0;
            int minP = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > 0)
                {
                    count += values[i];
                    minP = i;
                    if (count >= lowerPixelCount) break;
                }
            }
            return minP;
        }

        /// <summary>
        /// Get maximum value for a border
        /// </summary>
        /// <param name="values">All values from a specific Color component</param>
        /// <param name="upperPixelCount">Amount of pixels to ignore</param>
        /// <returns>Maximum border</returns>
        private int GetMax(int[] values, int upperPixelCount)
        {
            int count = 0;
            int maxP = 0;
            for (int i = 255; i >= 0; i--)
            {
                if (values[i] > 0)
                {
                    count += values[i];
                    maxP = i;
                    if (count >= upperPixelCount) break;
                }
            }
            return maxP;
        }

        /// <summary>
        /// Draw an histogram
        /// </summary>
        /// <param name="bitmap">Bitmap to draw on</param>
        /// <param name="colorMode">What color mode to use</param>
        /// <param name="color">What color component to use</param>
        public void Draw(Bitmap bitmap, string colorMode, string color)
        {
            Dictionary<string, int[]> values = new Dictionary<string, int[]>();

            switch (colorMode)
            {
                case "CMYK":
                    values = this.ValueCollectionCMYK;
                    break;
                case "RGB":
                    values = this.ValueCollectionRGB;
                    break;
                default:
                    return;
            }

            using (var g = Graphics.FromImage(bitmap))
            {
                using (Pen pen = new Pen(Color.Black, 1))
                {
                    float yUnit = (float)bitmap.Height / values[color].Max();
                    float xUnit = (float)bitmap.Width / 255;

                    pen.Width = xUnit;

                    for (int i = 0; i < values[color].Length; i++)
                    {
                        g.DrawLine(pen, new PointF(i * xUnit, bitmap.Height), new PointF(i * xUnit, bitmap.Height - (values[color][i] * yUnit)));
                    }
                }
            }
        }
    }
}
