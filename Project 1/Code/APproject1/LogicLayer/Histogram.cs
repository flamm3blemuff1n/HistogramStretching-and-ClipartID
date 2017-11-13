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

        public Histogram(Bitmap bitmap)
        {
            this.OriginalImage = bitmap;
            CalculateRGB();
            CalculateCMYK();
        }

        private void CalculateRGB()
        {
            this.ValueCollectionRGB = new Dictionary<string, int[]>();
            string[] modes = new string[] { "AVG", "LUM", "R", "G", "B" };

            foreach (string mode in modes)
            {
                this.ValueCollectionRGB.Add(mode, new int[256]);
            }

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    Color color = this.OriginalImage.GetPixel(i, j);

                    this.ValueCollectionRGB["R"][color.R]++;
                    this.ValueCollectionRGB["G"][color.G]++;
                    this.ValueCollectionRGB["B"][color.B]++;
                    this.ValueCollectionRGB["AVG"][(color.R+color.G+color.B)/3]++;
                    this.ValueCollectionRGB["LUM"][Math.Max(color.R, Math.Max(color.G, color.B))]++;
                }
            }

        }

        private void CalculateCMYK()
        {
            this.ValueCollectionCMYK = new Dictionary<string, int[]>();
            string[] modes = new string[] { "AVG", "C", "M", "Y", "K" };

            foreach (string mode in modes)
            {
                this.ValueCollectionCMYK.Add(mode, new int[1001]);
            }

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    Color color = this.OriginalImage.GetPixel(i, j);
                    int[] values = ConvertRGB(color);

                    this.ValueCollectionCMYK["C"][values[0]]++;
                    this.ValueCollectionCMYK["M"][values[1]]++;
                    this.ValueCollectionCMYK["Y"][values[2]]++;
                    this.ValueCollectionCMYK["K"][values[3]]++;

                    this.ValueCollectionCMYK["AVG"][(values[0]+ values[1] + values[2] + values[3])/4]++;

                    foreach (string mode in modes)
                    {
                        this.ValueCollectionCMYK[mode][0] = 0;
                    }
                }
            }
        }

        private int[] ConvertRGB(Color color)
        {
            double red = (double)color.R / 255;
            double green = (double)color.G / 255;
            double blue = (double)color.B / 255;

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

        public void Draw(Bitmap bitmap,string colorMode, string color)
        {
            Dictionary<string, int[]> values = new Dictionary<string, int[]>();

            if (colorMode.Equals("CMYK"))
            {
                values = this.ValueCollectionCMYK;
            }
            else
            {
                values = this.ValueCollectionRGB;
            }

            using (var g = Graphics.FromImage(bitmap))
            {
                using (Pen pen = new Pen(Color.Black, 1))
                {
                    g.DrawLine(pen, new Point(0, 0), new Point(bitmap.Width, 0));
                    g.DrawLine(pen, new Point(0, 0), new Point(0, bitmap.Height));
                    g.DrawLine(pen, new Point(bitmap.Width - 1, bitmap.Height - 1), new Point(0, bitmap.Height - 1));
                    g.DrawLine(pen, new Point(bitmap.Width - 1, bitmap.Height - 1), new Point(bitmap.Width - 1, 0));

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

        public Bitmap Stretch(int lowerLimit, int upperLimit)
        {
            Bitmap stretched = new Bitmap(OriginalImage);

            int[] red = GetMinMax(this.ValueCollectionRGB["R"], lowerLimit, upperLimit);
            int[] green = GetMinMax(this.ValueCollectionRGB["G"], lowerLimit, upperLimit);
            int[] blue = GetMinMax(this.ValueCollectionRGB["B"], lowerLimit, upperLimit);

            for (int i = 0; i < stretched.Width; i++)
            {
                for (int j = 0; j < stretched.Height; j++)
                {
                    Color color = stretched.GetPixel(i, j);
                    int r = (int)((color.R - red[0]) * (255 / (float)(red[1] - red[0])));
                    int g = (int)((color.G - green[0]) * (255 / (float)(green[1] - green[0])));
                    int b = (int)((color.B - blue[0]) * (255 / (float)(blue[1] - blue[0])));

                    
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

        private int[] GetMinMax(int[] values, int lower, int upper)
        {
            int pixels = OriginalImage.Width * OriginalImage.Height;
            int lowerPixelCount = (int)Math.Round(pixels * (lower/100.0), 0);
            int upperPixelCount = (int)pixels - (int)Math.Round(pixels * (upper/100.0), 0);

            int minP = GetMin(values, lowerPixelCount);
            int maxP = GetMax(values, upperPixelCount);

            return new int[] { minP, maxP };
        }

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
    }
}
