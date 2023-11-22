using CommunityToolkit.Mvvm.ComponentModel;
using ESP32_SERVER.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESP32_SERVER.ViewModels;
public class MainPageViewModel : ObservableRecipient
{

    public readonly ObservableCollection<Camera> CamerasUrls = new ObservableCollection<Camera>();

    public MainPageViewModel()
    {
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
        CamerasUrls.Add(new Camera("Living Room", "http://192.168.1.111:81/stream"));
    }

}
