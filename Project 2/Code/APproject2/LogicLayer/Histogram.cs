using Globals.classes;
using Globals.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Histogram : Rgb, IHistogram
    {
        private Bitmap OriginalImage;

        public Histogram(Bitmap bitmap) : base()
        {
            this.OriginalImage = bitmap;
            CalculateHistogram();
        }

        private void CalculateHistogram()
        {
            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    Color color = this.OriginalImage.GetPixel(i, j);

                    base.AddRgbColor(color);
                }
            }
            this.OriginalImage.Dispose();
        }

        public long[] GetData(String mode)
        {
            long[] output = base.ValueCollection[mode];
            return output;
        }
    }
}
