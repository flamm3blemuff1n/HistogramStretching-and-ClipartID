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
        private int[] ValuesAvg;
        private int[] ValuesR;
        private int[] ValuesG;
        private int[] ValuesB;

        public Histogram(Bitmap bitmap)
        {
            this.OriginalImage = bitmap;
            CalculateRGB();
        }

        private void CalculateRGB()
        {
            this.ValuesAvg = new int[256];
            this.ValuesR = new int[256];
            this.ValuesG = new int[256];
            this.ValuesB = new int[256];

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    Color color = this.OriginalImage.GetPixel(i, j);
                    int colorSumR = 0;
                    int colorSumG = 0;
                    int colorSumB = 0;

                    colorSumR += color.R;
                    colorSumG += color.G;
                    colorSumB += color.B;

                    this.ValuesR[colorSumR]++;
                    this.ValuesG[colorSumG]++;
                    this.ValuesB[colorSumB]++;

                    int colorAvg = (colorSumR + colorSumG + colorSumB)/3;
                    this.ValuesAvg[colorAvg]++;
                }
            }
        }

        public void DrawRGB(Bitmap bitmap, String mode)
        {
            int[] values;
            switch (mode)
            {
                case "R":
                    values = this.ValuesR;
                    break;
                case "G":
                    values = this.ValuesG;
                    break;
                case "B":
                    values = this.ValuesB;
                    break;
                default:
                    values = this.ValuesAvg;
                    break;
            }

            using (var g = Graphics.FromImage(bitmap))
            {
                using (Pen pen = new Pen(Color.Black, 1))
                {
                    g.DrawLine(pen, new Point(0, 0), new Point(bitmap.Width, 0));
                    g.DrawLine(pen, new Point(0, 0), new Point(0, bitmap.Height));
                    g.DrawLine(pen, new Point(bitmap.Width - 1, bitmap.Height - 1), new Point(0, bitmap.Height - 1));
                    g.DrawLine(pen, new Point(bitmap.Width - 1, bitmap.Height - 1), new Point(bitmap.Width - 1, 0));

                    float yUnit = (float)bitmap.Height / values.Max();
                    float xUnit = (float)bitmap.Width / 255;

                    pen.Width = xUnit;

                    for (int i = 0; i<values.Length; i++)
                    {
                        g.DrawLine(pen, new PointF(i*xUnit, bitmap.Height), new PointF(i*xUnit, bitmap.Height-(values[i]*yUnit)));
                    }
                }
            }
        }

        public Bitmap StretchRGB()
        {
            Bitmap stretched = new Bitmap(OriginalImage);

            int[] red = GetMinMax(ValuesR);
            int[] green = GetMinMax(ValuesG);
            int[] blue = GetMinMax(ValuesB);

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
