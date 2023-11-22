using ESP32_SERVER.ViewModels;
using Microsoft.Extensions.DependencyInjection;
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

namespace ESP32_SERVER.Pages
{
    public sealed partial class MainPage : Page
    {
        public readonly MainPageViewModel ViewModel;

        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = App.Services.GetRequiredService<MainPageViewModel>();
            DataContext = ViewModel;
        }
    }
}
