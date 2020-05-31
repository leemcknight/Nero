using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace McKnight.Nero
{
    class IconResolver
    {        

        public Image Resolve(FileSystemInfo info)
        {
            Image image = new Image();
            image.BeginInit();
            if(info is FileInfo)
                image.Source = new BitmapImage(new Uri("ico/FSFile_16x.png", UriKind.Relative));
            else
                image.Source = new BitmapImage(new Uri("ico/Folder_16x.png", UriKind.Relative));
            image.EndInit();
            return image;
        }
    }
}
