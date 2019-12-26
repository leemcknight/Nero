using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Nero
{
    public class FolderExplorer : TreeView
    {
        public static readonly DependencyProperty FolderProperty = DependencyProperty.Register("Folder", typeof(String), typeof(FolderExplorer));
        public String Folder
        {
            get { return (string)GetValue(FolderProperty);  }
            set { SetValue(FolderProperty, value); }
        }
    }
}
