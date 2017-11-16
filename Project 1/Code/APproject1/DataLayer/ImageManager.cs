using Globals.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ImageManager : IImageManager
    {
        public string CurrentImagePath { get; private set; }
        public string ImageName { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="imagePath">Path to set</param>
        public ImageManager(string imagePath)
        {
            SelectImagePath(imagePath);
        }

        /// <summary>
        /// Set CurrentImagePath
        /// </summary>
        /// <param name="imagePath">Path to set</param>
        public void SelectImagePath(string imagePath)
        {
            CurrentImagePath = imagePath;
            if (File.Exists(imagePath))
            {
                ImageName = Path.GetFileName(imagePath);
            }
            else
            {
                ImageName = "";
            }
        }
    }
}
