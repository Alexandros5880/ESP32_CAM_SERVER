using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESP32_SERVER.Models;
public class Camera
{
    public string Name { get; set; }
    public string Url { get; set; }

    public Camera()
    {
        
    }
    public Camera(String name, string url)
    {
        Name = name;
        Url = url;
    }
}