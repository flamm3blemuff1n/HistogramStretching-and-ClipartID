using Globals.interfaces;
using System.Collections.Generic;
using System.Drawing;

namespace Globals.classes
{
    public class Rgb : IRgb
    {
        public Dictionary<string, long[]> ValueCollection { get; private set; }

        public Rgb()
        {
            this.ValueCollection = new Dictionary<string, long[]>();
            string[] modes = new string[] { "LUM", "R", "G", "B" };

            foreach (string mode in modes)
            {
                this.ValueCollection.Add(mode, new long[256]);
            }
        }

        public void AddRgbColor(Color color)
        {
            this.ValueCollection["R"][color.R]++;
            this.ValueCollection["G"][color.G]++;
            this.ValueCollection["B"][color.B]++;
            //formula http://geraldbakker.nl/psnumbers/histograms-1.html
            this.ValueCollection["LUM"][(int)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B)]++;
        }
    }
}
