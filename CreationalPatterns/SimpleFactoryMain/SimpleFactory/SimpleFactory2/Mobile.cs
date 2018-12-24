using System;

namespace SimpleFactory.SimpleFactory2
{
    public class Mobile: IDevice
    {
        public string Name { get; set; }

        public void ScreenSize()
        {
            Console.WriteLine("Mobile screen size is 320 x 480 pixels");
        }
    }
}
