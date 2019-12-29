using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Nero
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static App app;

        public static App RootApp
        {
            get
            {                
                return app;
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            app = this;
            base.OnStartup(e);
        }
    }
}
