using Globals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ImageManager : IImageManager
    {
        public string CurrentImagePath { get; private set; }
        public ImageManager(string imagePath)
        {
            SelectImagePath(imagePath);
        }

        public void SelectImagePath(string imagePath)
        {
            CurrentImagePath = imagePath;
        }
    }
}
