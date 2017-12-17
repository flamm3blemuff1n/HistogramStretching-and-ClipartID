using Globals;
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
        public Dictionary<ImageType, List<string>> Files { get; private set; }

        private int filesDone;
        private int fileAmount;

        public WekaData(string location)
        {
            this.Location = location;
            this.Files = new Dictionary<ImageType, List<string>>();
            this.Files.Add(ImageType.Clipart, new List<string>());
            this.Files.Add(ImageType.Normal, new List<string>());
        }

        public void AddFiles(string[] files, ImageType type)
        {
            foreach(string file in files)
            {
                this.Files[type].Add(file);
            }
        }

        public void ResetFiles()
        {
            this.Files[ImageType.Clipart] = new List<string>();
            this.Files[ImageType.Normal] = new List<string>();
        }

        public void Generate()
        {
            CreateFile();
            this.filesDone = 0;
            this.fileAmount = this.Files[ImageType.Normal].Count + this.Files[ImageType.Clipart].Count;

            foreach (string file in this.Files[ImageType.Normal])
            {
                AddDataToFile(GenerateData(file, ImageType.Normal));
            }

            foreach (string file in this.Files[ImageType.Clipart])
            {
                AddDataToFile(GenerateData(file, ImageType.Clipart));
            }

            PartProcessed?.Invoke("Finished");
        }

        public event Action<string> PartProcessed;

        private void CreateFile()
        {
            using (StreamWriter file = File.AppendText(Location))
            {
                file.WriteLine("@relation ClipartClassifier");
                for (int i = 0; i <= 255; i++)
                {
                    file.WriteLine("@attribute " + i + " numeric");
                }
                file.WriteLine("@attribute type {Clipart, Normal}");
                file.WriteLine("@DATA");
            }

            PartProcessed?.Invoke("Created file at " + Location);
        }

        private void AddDataToFile(string data)
        {
            using (StreamWriter file = File.AppendText(Location))
            {
                file.WriteLine(data);
            }
        }

        private string GenerateData(string file, ImageType type)
        {
            try
            {
                Bitmap bitmap = new Bitmap(file);
                Histogram h = new Histogram(bitmap);
                long[] a = h.GetData("LUM");
                bitmap.Dispose();
                String output = "";
                foreach (long i in a)
                {
                    output += i + ",";
                }
                output += type.ToString();
                filesDone++;
                PartProcessed?.Invoke(filesDone + "/" + this.fileAmount + " Added " + file);
                return output;
            }
            catch (Exception e)
            {
                filesDone++;
                PartProcessed?.Invoke(filesDone + "/" + this.fileAmount + " Error using " + file);
                Console.WriteLine("Error making histogram from image " + e);
                return null;
            }
        }
    }
}
