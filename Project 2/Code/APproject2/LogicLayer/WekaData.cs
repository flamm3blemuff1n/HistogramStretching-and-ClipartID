using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class WekaData
    {
        public string location { get; set; }
        public Dictionary<string, List<string>> files { get; private set; }

        public WekaData(string location)
        {
            this.location = location;
            this.files = new Dictionary<string, List<string>>();
            this.files.Add("clipart", new List<string>());
            this.files.Add("normal", new List<string>());
        }

        public void addFiles(string[] files, string type)
        {
            foreach(string file in files)
            {
                this.files[type].Add(file);
            }
        }

        public void Generate()
        {
            createFile();

            foreach (string file in this.files["normal"])
            {
                addDataToFile(GenerateData(file, "normal"));
            }

            foreach (string file in this.files["clipart"])
            {
                addDataToFile(GenerateData(file, "clipart"));
            }

        }

        public event Action<string> PartProcessed;

        private void createFile()
        {
            using (StreamWriter file = File.AppendText(location))
            {
                file.WriteLine("@relation Data");
                for (int i = 0; i <= 255; i++)
                {
                    file.WriteLine("@attribute " + i + " numeric");
                }
                file.WriteLine("@attribute type {clipart, normal}");
                file.WriteLine("@DATA");
            }
            PartProcessed?.Invoke("Created file at" + location);
        }

        private void addDataToFile(string data)
        {
            using (StreamWriter file = File.AppendText(location))
            {
                file.WriteLine(data);
            }
        }

        private string GenerateData(string file, string type)
        {
            Histogram h = new Histogram(new Bitmap(file));
            long[] a = h.GetData("LUM");
            String output = "";
            foreach (long i in a)
            {
                output += i + ",";
            }
            output += type;
            PartProcessed?.Invoke("Added " + file);
            return output;
        }
    }
}
