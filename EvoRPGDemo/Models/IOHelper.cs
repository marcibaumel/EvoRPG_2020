using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace EvoRPGDemo.Classes
{
    class IOHelper
    {
    
        /// <summary>
        /// Finds the given image file in the given location and returns it as a <see cref="BitmapImage"/>.
        /// </summary>
        /// <param name="imageLocation">Where is the image.</param>
        /// <param name="imageName">Image name without file extension.</param>
        /// <returns>Return with a <see cref="BitmapImage"/></returns>
        public BitmapImage GetBitmapImageByName(string imageLocation, string imageName)
        {
            string imagePath = GetAbsoluteImagePath(imageLocation, imageName);

            return new BitmapImage(new Uri(@"pack://application:,,,/" + imagePath, UriKind.Absolute));
        }

        /// <summary>
        /// Performs a search in the given directory for the given file name.
        /// </summary>
        /// <param name="directoryPath">The directory where the search will be performed.</param>
        /// <param name="imageNameFilter">This parameter is used in the search pattern as a filter for the file name. Use this without the file extension.</param>
        /// <returns>Returns with the found file's absolute path.</returns>
        private string GetAbsoluteImagePath(string directoryPath, string imageNameFilter)
        {
            var a = Directory.GetFiles(directoryPath, $"{imageNameFilter}.*", SearchOption.TopDirectoryOnly);
            return a[0];
        }
    }
}
