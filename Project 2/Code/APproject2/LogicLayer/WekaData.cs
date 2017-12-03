using Globals.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace LogicLayer
{
    public class WekaData : IWekaData
    {
        public string Location { get; set; }
        public Dictionary<string, List<string>> Files { get; private set; }

        private int filesDone;
        private int fileAmount;

        public WekaData(string location)
        {
            this.Location = location;
            this.Files = new Dictionary<string, List<string>>();
            this.Files.Add("clipart", new List<string>());
            this.Files.Add("normal", new List<string>());
        }

        public void AddFiles(string[] files, string type)
        {
            foreach(string file in files)
            {
                this.Files[type].Add(file);
            }
        }

        public void Generate()
        {
            CreateFile();
            this.filesDone = 0;
            this.fileAmount = this.Files["normal"].Count + this.Files["clipart"].Count;

            foreach (string file in this.Files["normal"])
            {
                AddDataToFile(GenerateData(file, "normal"));
            }

            foreach (string file in this.Files["clipart"])
            {
                AddDataToFile(GenerateData(file, "clipart"));
            }

            PartProcessed?.Invoke("Finished");
        }

        public event Action<string> PartProcessed;

        private void CreateFile()
        {
            using (StreamWriter file = File.AppendText(Location))
            {
                file.WriteLine("@relation Data");
                for (int i = 0; i <= 255; i++)
                {
                    file.WriteLine("@attribute " + i + " numeric");
                }
                file.WriteLine("@attribute type {clipart, normal}");
                file.WriteLine("@DATA");
            }
            PartProcessed?.Invoke("Created file at" + Location);
        }

        private void AddDataToFile(string data)
        {
            using (StreamWriter file = File.AppendText(Location))
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
            filesDone++;
            PartProcessed?.Invoke(filesDone + "/" + this.fileAmount + " Added " + file);
            return output;
        }
    }
}
