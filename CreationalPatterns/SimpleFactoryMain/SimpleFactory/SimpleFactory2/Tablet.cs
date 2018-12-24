using System;

namespace SimpleFactory.SimpleFactory2
{
    public class Tablet: IDevice
    {
        public string Name { get; set; }

        public void ScreenSize()
        {
            Console.WriteLine("Tablet screen size is 800 x 1280 pixels");
        }

    }
}
