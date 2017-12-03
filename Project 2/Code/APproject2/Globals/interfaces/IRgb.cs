using System.Collections.Generic;
using System.Drawing;


namespace Globals.interfaces
{
    public interface IRgb
    {
        Dictionary<string, long[]> ValueCollection { get; }
        void AddRgbColor(Color color);
    }
}
