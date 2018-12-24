using System;

namespace SimpleFactory.SimpleFactory2
{
    public class Desktop4k : IDevice
    {
        public string Name { get; set; }
        public void ScreenSize()
        {
            Console.WriteLine("Desktop 4k screen size is 3840 x 2160 pixels");
        }
    }
}
