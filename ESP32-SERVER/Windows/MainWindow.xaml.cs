using ESP32_SERVER.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace ESP32_SERVER.Windows
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            // Seetings Clicked
            if (args.IsSettingsInvoked)
            {

                return;
            }

            var pagename = args.InvokedItem;

            // Second Time Clicked Same Page
            if (ContentFrame.SourcePageType != null && ContentFrame.SourcePageType.Name.Equals(pagename))
                return;

            switch (pagename)
            {

                // MainPage Clciked
                case nameof(MainPage):
                    ContentFrame.Navigate(typeof(MainPage));
                    return;

            }
        }

        
    }
}
