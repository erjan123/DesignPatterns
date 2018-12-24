using System;

namespace SimpleFactory.SimpleFactory2
{
    public class DesktopHD : IDevice
    {
        public string Name { get; set; }
        public void ScreenSize()
        {
            Console.WriteLine("Desktop HD screen size is1024 × 768 pixels");
        }

    }
}
