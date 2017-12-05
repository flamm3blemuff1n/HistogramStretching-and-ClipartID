using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.interfaces
{
    public interface IWekaData
    {
        Dictionary<ImageType, List<string>> Files { get; }
        string Location { get; set; }
        void AddFiles(string[] files, ImageType type);
        void Generate();
        event Action<string> PartProcessed;
    }
}
