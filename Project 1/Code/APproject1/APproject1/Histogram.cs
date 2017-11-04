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
        private int[] Values;

        public Histogram(Bitmap bitmap)
        {
            this.OriginalImage = bitmap;
        }

        public void CalculateRGB(String mode)
        {
            this.Values = new int[256];

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    Color color = this.OriginalImage.GetPixel(i, j);
                    int colorSum = 0;

                    if (mode.Equals("R") || mode.Equals("AVG")) colorSum += color.R;
                    if (mode.Equals("G") || mode.Equals("AVG")) colorSum += color.G;
                    if (mode.Equals("B") || mode.Equals("AVG")) colorSum += color.B;

                    int colorAvg = colorSum;
                    if (mode.Equals("AVG")) colorAvg /= 3;

                    this.Values[colorAvg]++;
                }
            }
        }

        public void Draw(Bitmap bitmap)
        {
            using (var g = Graphics.FromImage(bitmap))
            {
                using (Pen pen = new Pen(Color.Black, 1))
                {
                    g.DrawLine(pen, new Point(0, 0), new Point(bitmap.Width, 0));
                    g.DrawLine(pen, new Point(0, 0), new Point(0, bitmap.Height));
                    g.DrawLine(pen, new Point(bitmap.Width - 1, bitmap.Height - 1), new Point(0, bitmap.Height - 1));
                    g.DrawLine(pen, new Point(bitmap.Width - 1, bitmap.Height - 1), new Point(bitmap.Width - 1, 0));

                    float yUnit = (float)bitmap.Height / Values.Max();
                    float xUnit = (float)bitmap.Width / 255;

                    pen.Width = xUnit;

                    for (int i = 0; i<Values.Length; i++)
                    {
                        g.DrawLine(pen, new PointF(i*xUnit, bitmap.Height), new PointF(i*xUnit, bitmap.Height-(Values[i]*yUnit)));
                    }
                }
            }
            
        }
    }
}
