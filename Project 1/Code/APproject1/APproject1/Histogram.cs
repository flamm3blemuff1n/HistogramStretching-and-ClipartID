using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APproject1
{
    public class Histogram
    {
        private Bitmap OriginalImage;
        private Dictionary<string, int[]> ValueCollection;

        public Histogram(Bitmap bitmap)
        {
            this.OriginalImage = bitmap;
            CalculateRGB();
        }

        private void CalculateRGB()
        {
            this.ValueCollection = new Dictionary<string, int[]>();
            string[] modes = new string[] { "AVG", "R", "G", "B"};

            foreach (string mode in modes)
            {
                this.ValueCollection.Add(mode, new int[256]);

                for (int i = 0; i < OriginalImage.Width; i++)
                {
                    for (int j = 0; j < OriginalImage.Height; j++)
                    {
                        Color color = this.OriginalImage.GetPixel(i, j);
                        int colorSum = 0;

                        if (mode.Equals("R") || mode.Equals("AVG")) colorSum += color.R;
                        if (mode.Equals("G") || mode.Equals("AVG")) colorSum += color.G;
                        if (mode.Equals("B") || mode.Equals("AVG")) colorSum += color.B;

                        if (mode.Equals("AVG")) colorSum /= 3;

                        this.ValueCollection[mode][colorSum]++;
                    }
                }
            }
        }

        public void DrawRGB(Bitmap bitmap, string mode)
        {
            using (var g = Graphics.FromImage(bitmap))
            {
                using (Pen pen = new Pen(Color.Black, 1))
                {
                    g.DrawLine(pen, new Point(0, 0), new Point(bitmap.Width, 0));
                    g.DrawLine(pen, new Point(0, 0), new Point(0, bitmap.Height));
                    g.DrawLine(pen, new Point(bitmap.Width - 1, bitmap.Height - 1), new Point(0, bitmap.Height - 1));
                    g.DrawLine(pen, new Point(bitmap.Width - 1, bitmap.Height - 1), new Point(bitmap.Width - 1, 0));

                    float yUnit = (float)bitmap.Height / this.ValueCollection[mode].Max();
                    float xUnit = (float)bitmap.Width / 255;

                    pen.Width = xUnit;

                    for (int i = 0; i< this.ValueCollection[mode].Length; i++)
                    {
                        g.DrawLine(pen, new PointF(i*xUnit, bitmap.Height), new PointF(i*xUnit, bitmap.Height-(this.ValueCollection[mode][i]*yUnit)));
                    }
                }
            }
        }

        public void DrawHSV(Bitmap bitmap, string mode)
        {

        }

        public Bitmap StretchRGB()
        {
            Bitmap stretched = new Bitmap(OriginalImage);

            int[] red = GetMinMax(this.ValueCollection["R"]);
            int[] green = GetMinMax(this.ValueCollection["G"]);
            int[] blue = GetMinMax(this.ValueCollection["B"]);

            for (int i = 0; i < stretched.Width; i++ )
            {
                for (int j = 0; j < stretched.Height; j++)
                {
                    Color color = stretched.GetPixel(i, j);
                    int r = (int)((color.R - red[0])* (255/(float)(red[1]-red[0])));
                    int g = (int)((color.G - green[0]) * (255 / (float)(green[1] - green[0])));
                    int b = (int)((color.B - blue[0]) * (255 / (float)(blue[1] - blue[0])));

                    Color colorNew = Color.FromArgb(r, g, b);
                    stretched.SetPixel(i, j, colorNew);
                }
            }

            return stretched;
        }

        private int[] GetMinMax(int[] values)
        {
            int minP = 0;
            int maxP = 0;

            for(int i = 0; i < values.Length; i++)
            {
                if(values[i] > 0)
                {
                    minP = i;
                    break;
                }
            }

            for (int i = 255; i >= 0; i++)
            {
                if (values[i] > 0)
                {
                    maxP = i;
                    break;
                }
            }
            return new int[] {minP, maxP};
        }
    }
}
