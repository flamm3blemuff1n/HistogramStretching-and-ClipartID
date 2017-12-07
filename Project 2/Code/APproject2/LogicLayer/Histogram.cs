using Globals.classes;
using Globals.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
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
            Rectangle rect = new Rectangle(0, 0, this.OriginalImage.Width, this.OriginalImage.Height);
            BitmapData bitmapData = this.OriginalImage.LockBits(rect, ImageLockMode.ReadOnly, this.OriginalImage.PixelFormat);

            IntPtr ptr = bitmapData.Scan0;
            int bytes = Math.Abs(bitmapData.Stride) * this.OriginalImage.Height;
            byte[] rgbValues = new byte[bytes];

            Marshal.Copy(ptr, rgbValues, 0, bytes);
            this.OriginalImage.UnlockBits(bitmapData);

            for (int i = 0; i < bitmapData.Width; i++)
            {
                for (int j = 0; j < bitmapData.Height; j++)
                {
                   byte b = (byte)(rgbValues[(j * bitmapData.Stride) + (i * 3)]);
                   byte g = (byte)(rgbValues[(j * bitmapData.Stride) + (i * 3) + 1]);
                   byte r = (byte)(rgbValues[(j * bitmapData.Stride) + (i * 3) + 2]);

                    Color color = Color.FromArgb(r, g, b);

                    base.AddRgbColor(color);
                }
            }
        }

        public long[] GetData(String mode)
        {
            long[] output = base.ValueCollection[mode];
            return output;
        }
    }
}
