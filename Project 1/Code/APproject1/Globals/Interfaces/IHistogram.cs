using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Interfaces
{
    public interface IHistogram
    {
        void Draw(Bitmap bitmap, string colorMode, string color);
        Bitmap Stretch(int lowerLimit, int upperLimit);
    }
}
