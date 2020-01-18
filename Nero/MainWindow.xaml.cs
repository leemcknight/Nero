using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using McKnight.Nero;
using McKnight.Nero.Commands;

namespace Nero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IInputElement activeEditor;
        public static OpenFolderCommand OpenFolderCommand = new OpenFolderCommand();
        private static MainWindow mainWindow;
        

        private FolderExplorer folderTreeView;

        public MainWindow()
        {
            InitializeComponent();            
            folderTreeView = new FolderExplorer();
            folderTreeView.Folder = "C:\\";
            TabItem tabItem = new TabItem();
            tabItem.Content = folderTreeView;
            tabItem.Header = "Folder Explorer";
            navTab.Items.Add(tabItem);
            mainWindow = this;
        }

        public IInputElement ActiveEditor
        {
            get { return activeEditor; }
            set { activeEditor = value;  }
        }

        public static MainWindow Instance
        {
            get { return mainWindow;  }
        }

        public void AddEditor(Control control, string title)
        {
            TabItem tabItem = new TabItem();
            tabItem.Content = control;
            fileTab.Items.Add(tabItem);
        }
    }
}
