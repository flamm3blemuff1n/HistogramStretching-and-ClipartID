using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.interfaces
{
    public interface IWekaData
    {
        Dictionary<string, List<string>> Files { get; }
        string Location { get; set; }
        void AddFiles(string[] files, string type);
        void Generate();
        event Action<string> PartProcessed;
    }
}
