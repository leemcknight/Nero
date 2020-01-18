using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using Microsoft.Win32;

namespace McKnight.Nero
{
    public class FolderExplorer : TreeView
    {
        public static readonly DependencyProperty FolderProperty = DependencyProperty.Register("Folder", typeof(String), typeof(FolderExplorer));
        private IconResolver iconResolver = new IconResolver();
        private ContextMenu contextMenu;

        public FolderExplorer() 
        {
            buildContextMenu();            
        }
        public String Folder
        {
            get { return (string)GetValue(FolderProperty);  }
            set { SetValue(FolderProperty, value);
                LoadFolder(value);
            }
        }

        private void buildContextMenu()
        {
            contextMenu = new ContextMenu();
            MenuItem openItem = new MenuItem();
            openItem.Header = "Open";
            openItem.Command = ApplicationCommands.Open;
            contextMenu.Items.Add(openItem);

            MenuItem refreshItem = new MenuItem();
            refreshItem.Header = "Refresh";
            contextMenu.Items.Add(refreshItem);

            MenuItem propertiesItem = new MenuItem();
            propertiesItem.Header = "Properties";
            propertiesItem.Command = ApplicationCommands.Properties;
            contextMenu.Items.Add(propertiesItem);

            
            this.ContextMenu = contextMenu;
        }

        private void LoadFolder(string folder)
        {
            DirectoryInfo info = new DirectoryInfo(folder);

            TreeViewItem root = CreateItem(info);
            Items.Add(root);
            

            foreach(DirectoryInfo dir in info.GetDirectories())
            {
                root.Items.Add(CreateItem(dir));
            }

            foreach(FileInfo file in info.GetFiles())
            {
                root.Items.Add(CreateItem(file));
            }
            
        }
        
        private TreeViewItem CreateItem(FileSystemInfo info)
        {
            TreeViewItem item = new TreeViewItem();
            item.Tag = info;
            
            StackPanel headerPanel = new StackPanel();
            headerPanel.Orientation = Orientation.Horizontal;
            
            headerPanel.Children.Add(iconResolver.Resolve(info));

            TextBlock textBlock = new TextBlock();
            textBlock.Text = info.Name;
            headerPanel.Children.Add(textBlock);

            item.Header = headerPanel;
            item.MouseDoubleClick += Item_MouseDoubleClick;

            item.ContextMenu = contextMenu;
            item.CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, OpenFileCommandExecuted, OpenCommandCanExecute));
            return item;
        }

        private void Item_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("djfljsd");
        }

        private void OpenCommandExecuted(object target, ExecutedRoutedEventArgs args)
        {
            MessageBox.Show("Open");
        }

        private void OpenFileCommandExecuted(object target, ExecutedRoutedEventArgs args)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == true)
            {
                Stream s = dlg.OpenFile();
                StreamReader sr = new StreamReader(s);
                RichTextBox textBox = new RichTextBox();
                textBox.AppendText(sr.ReadToEnd());                

            }            
            
        }

        private void OpenCommandCanExecute(object target, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }
    }
}
