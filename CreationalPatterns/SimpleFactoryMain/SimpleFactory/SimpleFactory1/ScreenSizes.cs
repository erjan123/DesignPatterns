using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.SimpleFactory1
{
    public class Mobile
    {
        public string Name { get; set; }
        
        public void ScreenSize()
        {
            Console.WriteLine("320 x 480 pixels");
        }
    }

    public class Tablet
    {
        public string  Name { get; set; }
        public void ScreenSize()
        {
            Console.WriteLine("800 x 1280 pixels");
        }

    }

    public class DesktopHD
    {
        public string Name { get; set; }
        public void ScreenSize()
        {
            Console.WriteLine("1024 × 768 pixels");
        }

    }

    public class Desktop4k
    {
        public string Name { get; set; }
        public void ScreenSize()
        {
            Console.WriteLine("3840 x 2160 pixels");
        }
    }

    public enum DeviceType
    {
        Mobile,
        Tablet,
        DesktopHD,
        Desktop4k
    }
}
